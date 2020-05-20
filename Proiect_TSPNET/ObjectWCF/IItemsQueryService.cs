using Proiect_TSPNET;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    public interface IItemsQueryService
    {
        [OperationContract]
        List<MediaItemDTO> FileterByScalar(List<MediaItemDTO> items, string extension, bool extensionCheck, DateTime date, bool dateChecked, bool isPhoto, bool isPhotoChecked, string eventName, bool eventChecked);
        [OperationContract]
        List<MediaItemDTO> FilterByRelation(List<MediaItemDTO> items, string value1, string value2, string value3, string filterType);
        [OperationContract]
        List<PropertyDTO> GetItemDynamicProperties(string path);
        [OperationContract]
        List<PersonDTO> GetItemPersons(string path);
        [OperationContract]
        List<MediaItemDTO> GetItems(bool markedForDelete, bool permanentDelete);
        [OperationContract]
        List<LocationDTO> GetLocations();
        [OperationContract]
        List<PersonDTO> GetPersons();
        [OperationContract]
        List<PropertyDTO> GetProperties();
        [OperationContract]
        MediaItemDTO GetItemByPath(string path);

        [OperationContract]
        MediaItemDTO GetItemById(int Id);
        [OperationContract]
        bool ItemExists(string path);


    }
}