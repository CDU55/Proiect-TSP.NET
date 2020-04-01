using Proiect_TSPNET;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    public interface ILocalItemsService
    {
        [OperationContract]
        bool AddAllMediaFilesFromFolder(string path, bool recursive);
        [OperationContract]
        bool AddLocalFile(string path, string description, DateTime date, bool overwrite);
        [OperationContract]
        ICollection<string> CheckForMovedOrDeletedFiles();
        [OperationContract]
        bool ExportAsJSON(string path, List<MediaItemDTO> items);
        [OperationContract]
        List<string> GetAllMediaPathsFromFolder(string path, bool recursive);
        [OperationContract]
        string GetItemName(string itemPath, bool withExtension);
        [OperationContract]
        bool IsPhoto(string itemPath);
        [OperationContract]
        bool IsVideo(string itemPath);
        [OperationContract]
        void MoveFile(string oldPath, string newPath);
        [OperationContract]
        void RemoveMarkedFiles();
        [OperationContract]
        bool ViewItem(string itemPath);
    }
}