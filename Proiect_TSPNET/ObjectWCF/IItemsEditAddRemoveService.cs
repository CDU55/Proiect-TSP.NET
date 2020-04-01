using System;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    public interface IItemsEditAddRemoveService
    {
        [OperationContract]
        bool AddDynamicPropery(string name, string value);
        [OperationContract]
        bool AddLocation(string name, string country, string region);
        [OperationContract]
        bool AddPerson(string firstName, string lastName, string group);
        [OperationContract]
        bool AttachDynamicProperty(string itemPath, string properyName, string propertyValue);
        [OperationContract]
        bool AttachPerson(string itemPath, string personFirstName, string personLastName, string personGroup);
        [OperationContract]
        bool ChangeDate(string itemPath, DateTime newDate);
        [OperationContract]
        bool ChangeDescription(string itemPath, string description);
        [OperationContract]
        bool ChangeEvent(string itemPath, string eventName);
        [OperationContract]
        bool ChangeLocation(string itemPath, string locationName, string locationCountry, string locationRegion);
        [OperationContract]
        bool EditItem(string itemPath, string newDescription, bool changeDescription, string eventName, bool changeEvent, DateTime newDate, bool changeDate);
        [OperationContract]
        bool MarkForDelete(string itemPath);
        [OperationContract]
        bool RemoveDynamicProperty(string itemPath, string properyName, string propertyValue);
        [OperationContract]
        bool RemoveEvent(string itemPath);
        [OperationContract]
        bool RemoveLocation(string itemPath);
        [OperationContract]
        bool RemoveLocationFromContext(string name, string country, string region);
        [OperationContract]
        bool RemovePerson(string itemPath, string personFirstName, string personLastName, string personGroup);
        [OperationContract]
        bool RemovePersonFromContext(string firstName, string lastName, string group);
        [OperationContract]
        bool RemovePropertyFromContext(string name, string value);
    }
}