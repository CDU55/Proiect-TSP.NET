using System;
using System.Collections.Generic;

namespace Proiect_TSPNET
{
    public interface ILocalItemsService
    {
        bool AddAllMediaFilesFromFolder(string path, bool recursive);
        bool AddLocalFile(string path, string description, DateTime date, bool overwrite);
        ICollection<string> CheckForMovedOrDeletedFiles();
        bool ExportAsJSON(string path, List<MediaItemDTO> items);
        List<string> GetAllMediaPathsFromFolder(string path, bool recursive);
        string GetItemName(string itemPath, bool withExtension);
        bool IsPhoto(string itemPath);
        bool IsVideo(string itemPath);
        void MoveFile(string oldPath, string newPath);
        void RemoveMarkedFiles();
        bool ViewItem(string itemPath);
    }
}