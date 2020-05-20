using System;
using System.Collections.Generic;

namespace Proiect_TSPNET
{
    public interface IItemsQueryService
    {
        List<MediaItemDTO> FileterByScalar(List<MediaItemDTO> items, string extension, bool extensionCheck, DateTime date, bool dateChecked, bool isPhoto, bool isPhotoChecked, string eventName, bool eventChecked);
        List<MediaItemDTO> FilterByRelation(List<MediaItemDTO> items, string value1, string value2, string value3, string filterType);
        List<PropertyDTO> GetItemDynamicProperties(string path);
        List<PersonDTO> GetItemPersons(string path);
        List<MediaItemDTO> GetItems(bool markedForDelete, bool permanentDelete);
        List<LocationDTO> GetLocations();
        List<PersonDTO> GetPersons();
        List<PropertyDTO> GetProperties();
        bool ItemExists(string path);
        MediaItemDTO GetItemByPath(string path);
        MediaItemDTO GetItemById(int Id);


    }
}