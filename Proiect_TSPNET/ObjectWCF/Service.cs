using Proiect_TSPNET;
using System;
using System.Collections.Generic;

namespace ObjectWCF
{
    public class Service : IService

    {
        private readonly ItemsService _service;

        public Service()
        {
            _service = new ItemsService();
        }
        public bool AddAllMediaFilesFromFolder(string path, bool recursive)
        {
            return _service.localItems.AddAllMediaFilesFromFolder(path, recursive);
        }

        public bool AddDynamicPropery(string name, string value)
        {
            return _service.dbService.editService.AddDynamicPropery(name, value);
        }

        public bool AddLocalFile(string path, string description, DateTime date, bool overwrite)
        {
            return _service.localItems.AddLocalFile(path, description, date, overwrite);
        }

        public bool AddLocation(string name, string country, string region)
        {
            return _service.dbService.editService.AddLocation(name, country, region);
        }

        public bool AddPerson(string firstName, string lastName, string group)
        {
            return _service.dbService.editService.AddPerson(firstName, lastName, group);
        }

        public bool AttachDynamicProperty(string itemPath, string properyName, string propertyValue)
        {
            return _service.dbService.editService.AttachDynamicProperty(itemPath, properyName, propertyValue);
        }

        public bool AttachPerson(string itemPath, string personFirstName, string personLastName, string personGroup)
        {
            return _service.dbService.editService.AttachPerson(itemPath, personFirstName, personLastName, personGroup);
        }

        public bool ChangeDate(string itemPath, DateTime newDate)
        {
            return _service.dbService.editService.ChangeDate(itemPath, newDate);
        }

        public bool ChangeDescription(string itemPath, string description)
        {
            return _service.dbService.editService.ChangeDescription(itemPath, description);
        }

        public bool ChangeEvent(string itemPath, string eventName)
        {
            return _service.dbService.editService.ChangeEvent(itemPath, eventName);
        }

        public bool ChangeLocation(string itemPath, string locationName, string locationCountry, string locationRegion)
        {
            return _service.dbService.editService.ChangeLocation(itemPath, locationName, locationCountry,
                locationRegion);
        }

        public ICollection<string> CheckForMovedOrDeletedFiles()
        {
            return _service.localItems.CheckForMovedOrDeletedFiles();
        }

        public bool EditItem(string itemPath, string newDescription, bool changeDescription, string eventName, bool changeEvent, DateTime newDate, bool changeDate)
        {
            return _service.dbService.editService.EditItem(itemPath, newDescription, changeDescription, eventName,
                changeEvent, newDate, changeDate);
        }

        public bool ExportAsJSON(string path, List<MediaItemDTO> items)
        {
            return _service.localItems.ExportAsJSON(path, items);
        }

        public List<MediaItemDTO> FileterByScalar(List<MediaItemDTO> items, string extension, bool extensionCheck, DateTime date, bool dateChecked, bool isPhoto, bool isPhotoChecked, string eventName, bool eventChecked)
        {
            return _service.dbService.queryService.FileterByScalar(items, extension, extensionCheck, date, dateChecked,
                isPhoto, isPhotoChecked, eventName, eventChecked);
        }

        public List<MediaItemDTO> FilterByRelation(List<MediaItemDTO> items, string value1, string value2, string value3, string filterType)
        {
            return _service.dbService.queryService.FilterByRelation(items, value1, value2, value3, filterType);
        }

        public List<string> GetAllMediaPathsFromFolder(string path, bool recursive)
        {
            return _service.localItems.GetAllMediaPathsFromFolder(path, recursive);
        }

        public List<PropertyDTO> GetItemDynamicProperties(string path)
        {
            return _service.dbService.queryService.GetItemDynamicProperties(path);
        }

        public string GetItemName(string itemPath, bool withExtension)
        {
            return _service.localItems.GetItemName(itemPath, withExtension);
        }

        public List<PersonDTO> GetItemPersons(string path)
        {
            return _service.dbService.queryService.GetItemPersons(path);
        }

        public List<MediaItemDTO> GetItems(bool markedForDelete, bool permanentDelete)
        {
            return _service.dbService.queryService.GetItems(markedForDelete, permanentDelete);
        }

        public List<LocationDTO> GetLocations()
        {
            return _service.dbService.queryService.GetLocations();
        }

        public List<PersonDTO> GetPersons()
        {
            return _service.dbService.queryService.GetPersons();
        }

        public List<PropertyDTO> GetProperties()
        {
            return _service.dbService.queryService.GetProperties();
        }

        public bool IsPhoto(string itemPath)
        {
            return _service.localItems.IsPhoto(itemPath);
        }

        public bool IsVideo(string itemPath)
        {
            return _service.localItems.IsVideo(itemPath);
        }

        public bool MarkForDelete(string itemPath)
        {
            return _service.dbService.editService.MarkForDelete(itemPath);
        }

        public void MoveFile(string oldPath, string newPath)
        {
            _service.localItems.MoveFile(oldPath, newPath);
        }

        public bool RemoveDynamicProperty(string itemPath, string properyName, string propertyValue)
        {
            return _service.dbService.editService.RemoveDynamicProperty(itemPath, properyName, propertyValue);
        }

        public bool RemoveEvent(string itemPath)
        {
            return _service.dbService.editService.RemoveEvent(itemPath);
        }

        public bool RemoveLocation(string itemPath)
        {
            return _service.dbService.editService.RemoveLocation(itemPath);
        }

        public bool RemoveLocationFromContext(string name, string country, string region)
        {
            return _service.dbService.editService.RemoveLocationFromContext(name, country, region);
        }

        public void RemoveMarkedFiles()
        {
            _service.localItems.RemoveMarkedFiles();
        }

        public bool RemovePerson(string itemPath, string personFirstName, string personLastName, string personGroup)
        {
            return _service.dbService.editService.RemovePerson(itemPath, personFirstName, personLastName, personGroup);
        }

        public bool RemovePersonFromContext(string firstName, string lastName, string group)
        {
            return _service.dbService.editService.RemovePersonFromContext(firstName, lastName, group);
        }

        public bool RemovePropertyFromContext(string name, string value)
        {
            return _service.dbService.editService.RemovePropertyFromContext(name, value);
        }

        public bool ViewItem(string itemPath)
        {
            return _service.localItems.ViewItem(itemPath);
        }
    }
}
