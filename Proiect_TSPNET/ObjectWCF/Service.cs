using Proiect_TSPNET;
using System;
using System.Collections.Generic;

namespace ObjectWCF
{
    public class Service : IService

    {
        private readonly ItemsService service;

        public Service()
        {
            service = new ItemsService();
        }
        public bool AddAllMediaFilesFromFolder(string path, bool recursive)
        {
            return service.localItems.AddAllMediaFilesFromFolder(path, recursive);
        }

        public bool AddDynamicPropery(string name, string value)
        {
            return service.dbService.editService.AddDynamicPropery(name, value);
        }

        public bool AddLocalFile(string path, string description, DateTime date, bool overwrite)
        {
            return service.localItems.AddLocalFile(path, description, date, overwrite);
        }

        public bool AddLocation(string name, string country, string region)
        {
            return service.dbService.editService.AddLocation(name, country, region);
        }

        public bool AddPerson(string firstName, string lastName, string group)
        {
            return service.dbService.editService.AddPerson(firstName, lastName, group);
        }

        public bool AttachDynamicProperty(string itemPath, string properyName, string propertyValue)
        {
            return service.dbService.editService.AttachDynamicProperty(itemPath, properyName, propertyValue);
        }

        public bool AttachPerson(string itemPath, string personFirstName, string personLastName, string personGroup)
        {
            return service.dbService.editService.AttachPerson(itemPath, personFirstName, personLastName, personGroup);
        }

        public bool ChangeDate(string itemPath, DateTime newDate)
        {
            return service.dbService.editService.ChangeDate(itemPath, newDate);
        }

        public bool ChangeDescription(string itemPath, string description)
        {
            return service.dbService.editService.ChangeDescription(itemPath, description);
        }

        public bool ChangeEvent(string itemPath, string eventName)
        {
            return service.dbService.editService.ChangeEvent(itemPath, eventName);
        }

        public bool ChangeLocation(string itemPath, string locationName, string locationCountry, string locationRegion)
        {
            return service.dbService.editService.ChangeLocation(itemPath, locationName, locationCountry,
                locationRegion);
        }

        public ICollection<string> CheckForMovedOrDeletedFiles()
        {
            return service.localItems.CheckForMovedOrDeletedFiles();
        }

        public bool EditItem(string itemPath, string newDescription, bool changeDescription, string eventName, bool changeEvent, DateTime newDate, bool changeDate)
        {
            return service.dbService.editService.EditItem(itemPath, newDescription, changeDescription, eventName,
                changeEvent, newDate, changeDate);
        }

        public bool ExportAsJSON(string path, List<MediaItemDTO> items)
        {
            return service.localItems.ExportAsJSON(path, items);
        }

        public List<MediaItemDTO> FileterByScalar(List<MediaItemDTO> items, string extension, bool extensionCheck, DateTime date, bool dateChecked, bool isPhoto, bool isPhotoChecked, string eventName, bool eventChecked)
        {
            return service.dbService.queryService.FileterByScalar(items, extension, extensionCheck, date, dateChecked,
                isPhoto, isPhotoChecked, eventName, eventChecked);
        }

        public List<MediaItemDTO> FilterByRelation(List<MediaItemDTO> items, string value1, string value2, string value3, string filterType)
        {
            return service.dbService.queryService.FilterByRelation(items, value1, value2, value3, filterType);
        }

        public List<string> GetAllMediaPathsFromFolder(string path, bool recursive)
        {
            return service.localItems.GetAllMediaPathsFromFolder(path, recursive);
        }

        public MediaItemDTO GetItemById(int Id)
        {
            return service.dbService.queryService.GetItemById(Id);
        }

        public MediaItemDTO GetItemByPath(string path)
        {
            return service.dbService.queryService.GetItemByPath(path);
        }

        public List<PropertyDTO> GetItemDynamicProperties(string path)
        {
            return service.dbService.queryService.GetItemDynamicProperties(path);
        }

        public string GetItemName(string itemPath, bool withExtension)
        {
            return service.localItems.GetItemName(itemPath, withExtension);
        }

        public List<PersonDTO> GetItemPersons(string path)
        {
            return service.dbService.queryService.GetItemPersons(path);
        }

        public List<MediaItemDTO> GetItems(bool markedForDelete, bool permanentDelete)
        {
            return service.dbService.queryService.GetItems(markedForDelete, permanentDelete);
        }

        public List<LocationDTO> GetLocations()
        {
            return service.dbService.queryService.GetLocations();
        }

        public List<PersonDTO> GetPersons()
        {
            return service.dbService.queryService.GetPersons();
        }

        public List<PropertyDTO> GetProperties()
        {
            return service.dbService.queryService.GetProperties();
        }

        public bool IsPhoto(string itemPath)
        {
            return service.localItems.IsPhoto(itemPath);
        }

        public bool IsVideo(string itemPath)
        {
            return service.localItems.IsVideo(itemPath);
        }

        public bool ItemExists(string path)
        {
            return service.dbService.queryService.ItemExists(path);
        }

        public bool MarkForDelete(string itemPath)
        {
            return service.dbService.editService.MarkForDelete(itemPath);
        }

        public void MoveFile(string oldPath, string newPath)
        {
            service.localItems.MoveFile(oldPath, newPath);
        }

        public bool RemoveDynamicProperty(string itemPath, string properyName, string propertyValue)
        {
            return service.dbService.editService.RemoveDynamicProperty(itemPath, properyName, propertyValue);
        }

        public bool RemoveEvent(string itemPath)
        {
            return service.dbService.editService.RemoveEvent(itemPath);
        }

        public bool RemoveLocation(string itemPath)
        {
            return service.dbService.editService.RemoveLocation(itemPath);
        }

        public bool RemoveLocationFromContext(string name, string country, string region)
        {
            return service.dbService.editService.RemoveLocationFromContext(name, country, region);
        }

        public void RemoveMarkedFiles()
        {
            service.localItems.RemoveMarkedFiles();
        }

        public bool RemovePerson(string itemPath, string personFirstName, string personLastName, string personGroup)
        {
            return service.dbService.editService.RemovePerson(itemPath, personFirstName, personLastName, personGroup);
        }

        public bool RemovePersonFromContext(string firstName, string lastName, string group)
        {
            return service.dbService.editService.RemovePersonFromContext(firstName, lastName, group);
        }

        public bool RemovePropertyFromContext(string name, string value)
        {
            return service.dbService.editService.RemovePropertyFromContext(name, value);
        }

        public bool ViewItem(string itemPath)
        {
            return service.localItems.ViewItem(itemPath);
        }
    }
}
