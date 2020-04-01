using System;

namespace Proiect_TSPNET
{
    public interface IItemsEditAddRemoveService
    {
        bool AddDynamicPropery(string name, string value);
        bool AddLocation(string name, string country, string region);
        bool AddPerson(string firstName, string lastName, string group);
        bool AttachDynamicProperty(string itemPath, string properyName, string propertyValue);
        bool AttachPerson(string itemPath, string personFirstName, string personLastName, string personGroup);
        bool ChangeDate(string itemPath, DateTime newDate);
        bool ChangeDescription(string itemPath, string description);
        bool ChangeEvent(string itemPath, string eventName);
        bool ChangeLocation(string itemPath, string locationName, string locationCountry, string locationRegion);
        bool EditItem(string itemPath, string newDescription, bool changeDescription, string eventName, bool changeEvent, DateTime newDate, bool changeDate);
        bool MarkForDelete(string itemPath);
        bool RemoveDynamicProperty(string itemPath, string properyName, string propertyValue);
        bool RemoveEvent(string itemPath);
        bool RemoveLocation(string itemPath);
        bool RemoveLocationFromContext(string name, string country, string region);
        bool RemovePerson(string itemPath, string personFirstName, string personLastName, string personGroup);
        bool RemovePersonFromContext(string firstName, string lastName, string group);
        bool RemovePropertyFromContext(string name, string value);
    }
}