using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proiect_TSPNET
{
    public class LocalItemsService : ILocalItemsService
    {
        private readonly ModelContainer context;
        private readonly LocalFilesManager manager;
        public LocalItemsService()
        {
            this.context = ModelContainer.GetContext();
            manager = new LocalFilesManager();
        }
        public bool AddLocalFile(string path, string description, DateTime date, bool overwrite)
        {
            if (!manager.IsImage(path) && !manager.IsVideo(path))
            {
                return false;
            }
            bool alreadyExists = context.MediaItems.Any(i => i.Path == path);
            if (alreadyExists && !overwrite)
            {
                return false;
            }
            else
            {
                if (!alreadyExists)
                {
                    bool isPhoto = manager.IsImage(path);
                    string name = manager.GetFileName(path, false);
                    string extension = manager.GetFileExtension(path);
                    MediaItems item = new MediaItems()
                    {
                        Path = path,
                        Title = name,
                        Extension = extension,
                        IsPhoto = isPhoto,
                        Description = description,
                        Date = date,
                        MarkedForDelete = false,
                        PermanentDelete = false
                    };
                    context.MediaItems.Add(item);
                }
                else if (alreadyExists && overwrite)
                {
                    var item = context.MediaItems.FirstOrDefault(i => i.Path == path);
                    foreach (var person in context.Persons.ToList())
                    {
                        if (person.MediaItems.Any(i => i.Path == path))
                        {
                            person.MediaItems.Remove(item);
                            item.Persons.Remove(person);
                        }
                    }
                    foreach (var property in context.DynamicProperties.ToList())
                    {
                        if (property.MediaItems.Any(i => i.Path == path))
                        {
                            property.MediaItems.Remove(item);
                            item.DynamicProperties.Remove(property);
                        }
                    }
                    if (item.Event != null)
                    {
                        item.Event.MediaItems1.Remove(item);
                        item.Event = null;
                    }
                    item.Description = description;
                    item.MarkedForDelete = false;
                    item.PermanentDelete = false;
                }
                context.SaveChanges();
                return true;
            }
        }
        public List<string> GetAllMediaPathsFromFolder(string path, bool recursive)
        {
            List<string> paths = new List<string>();
            if (!manager.DirectoryExists(path))
            {
                return paths;
            }
            else
            {
                List<string> photos = manager.GetAllPhotos(path, recursive).ToList();
                List<string> videos = manager.GetAllVideos(path, recursive).ToList();
                paths.AddRange(photos);
                paths.AddRange(videos);
                return paths;
            }
        }
        public bool AddAllMediaFilesFromFolder(string path, bool recursive)
        {
            if (!manager.DirectoryExists(path))
            {
                return false;
            }
            else
            {
                List<string> photos = manager.GetAllPhotos(path, recursive).ToList();
                List<string> videos = manager.GetAllVideos(path, recursive).ToList();
                foreach (var photo in photos)
                {
                    if (!context.MediaItems.Any(i => i.Path == photo))
                    {
                        MediaItems item = new MediaItems()
                        {
                            Path = photo,
                            Title = manager.GetFileName(photo, false),
                            Extension = manager.GetFileExtension(photo),
                            IsPhoto = true,
                            Description = string.Empty,
                            MarkedForDelete = false,
                            PermanentDelete = false
                        };
                        context.MediaItems.Add(item);
                    }

                }
                foreach (var video in videos)
                {
                    if (context.MediaItems.Any(i => i.Path == video))
                    {
                        MediaItems item = new MediaItems()
                        {
                            Path = video,
                            Title = manager.GetFileName(video, false),
                            Extension = manager.GetFileExtension(video),
                            IsPhoto = true,
                            Description = string.Empty,
                            MarkedForDelete = false,
                            PermanentDelete = false
                        };
                        context.MediaItems.Add(item);
                    }

                }
                context.SaveChanges();
                return true;
            }
        }

        public ICollection<string> CheckForMovedOrDeletedFiles()
        {
            List<string> movedOrDeletedFiles = new List<string>();
            foreach (var item in context.MediaItems.ToList())
            {
                if (!manager.FileExists(item.Path) && !item.PermanentDelete)
                {
                    movedOrDeletedFiles.Add(item.Title);
                }
            }
            return movedOrDeletedFiles;
        }
        public void RemoveMarkedFiles()
        {
            foreach (var item in context.MediaItems.ToList())
            {
                if (item.MarkedForDelete && manager.FileExists(item.Path))
                {
                    item.PermanentDelete = true;
                    manager.RemoveFile(item.Path);
                }
            }
            context.SaveChanges();
        }
        public void MoveFile(string oldPath, string newPath)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == oldPath);
            if (item != null)
            {
                item.Path = newPath;
                manager.MoveFile(oldPath, newPath);
                context.SaveChanges();
            }
        }
        public bool ViewItem(string itemPath)
        {
            return this.manager.OpenFile(itemPath);
        }

        public string GetItemName(string itemPath, bool withExtension)
        {
            return this.manager.GetFileName(itemPath, withExtension);
        }
        public bool ExportAsJSON(string path, List<MediaItemDTO> items)
        {
            string itemsAsJSON = JsonConvert.SerializeObject(items);
            try
            {
                System.IO.File.WriteAllText(path, itemsAsJSON);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public bool IsVideo(string itemPath)
        {
            return manager.IsVideo(itemPath);
        }

        public bool IsPhoto(string itemPath)
        {
            return manager.IsImage(itemPath);
        }
    }



}
