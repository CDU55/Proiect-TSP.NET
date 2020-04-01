using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace Proiect_TSPNET
{
    internal class LocalFilesManager
    {
        private readonly List<string> imageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG", ".JPEG" };
        private readonly List<string> videoExtensions = new List<string> { ".MP4", ".AVI", ".GIF", ".AMV", ".MKV" };

        public bool IsImage(string path)
        {
            if (!this.FileExists(path))
            {
                return false;
            }
            else
            {
                string fileExtension = Path.GetExtension(path);
                return imageExtensions.Contains(fileExtension.ToUpperInvariant());
            }
        }

        public bool IsVideo(string path)
        {
            if (!this.FileExists(path))
            {
                return false;
            }
            else
            {
                string fileExtension = Path.GetExtension(path);
                return videoExtensions.Contains(fileExtension.ToUpperInvariant());
            }
        }
        public bool FileExists(string path)
        {
            return File.Exists(path);
        }
        public bool DirectoryExists(string directoryPath)
        {
            return Directory.Exists(directoryPath);
        }

        public string[] GetAllFiles(string directoryPath, bool recursive)
        {
            if (recursive)
            {
                return Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
            }
            else
            {
                return Directory.GetFiles(directoryPath, "*", SearchOption.TopDirectoryOnly);
            }
        }
        public string GetFileName(string path, bool withExtension)
        {
            if (withExtension)
            {
                return Path.GetFileName(path);
            }
            else
            {
                return Path.GetFileNameWithoutExtension(path);
            }
        }
        public string GetFileExtension(string path)
        {
            return Path.GetExtension(path);
        }
        public ICollection<string> GetAllPhotos(string directoryPath, bool recursive)
        {
            List<string> photos = new List<string>();
            string[] allFiles = this.GetAllFiles(directoryPath, recursive);
            foreach (var file in allFiles)
            {
                if (this.IsImage(file))
                {
                    photos.Add(file);
                }
            }
            return photos;
        }
        public ICollection<string> GetAllVideos(string directoryPath, bool recursive)
        {
            List<string> videos = new List<string>();
            string[] allFiles = this.GetAllFiles(directoryPath, recursive);
            foreach (var file in allFiles)
            {
                if (this.IsVideo(file))
                {
                    videos.Add(file);
                }
            }
            return videos;
        }
        public bool MoveFile(string oldPath, string newPath)
        {
            if (!this.FileExists(oldPath))
            {
                return false;
            }
            else
            {
                try
                {
                    File.Move(oldPath, newPath);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool RemoveFile(string path)
        {
            try
            {
                File.Delete(path);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool OpenFile(string path)
        {
            if (this.IsImage(path) || this.IsVideo(path))
            {
                Process p = new Process();
                p.StartInfo.FileName = path;
                p.Start();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
