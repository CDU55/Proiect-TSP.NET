using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    public class ItemsQueryService : IItemsQueryService
    {
        private readonly ModelContainer context;
        public ItemsQueryService()
        {
            this.context = ModelContainer.GetContext();
        }

        public List<MediaItemDTO> GetItems(bool markedForDelete, bool permanentDelete)
        {
            List<MediaItemDTO> mediaItemDTOs = new List<MediaItemDTO>();
            List<MediaItems> items = context.MediaItems.Where(i => (i.MarkedForDelete == markedForDelete && i.PermanentDelete == permanentDelete)).ToList();
            foreach (var item in items)
            {
                mediaItemDTOs.Add(new MediaItemDTO(item));
            }
            return mediaItemDTOs;
        }

        public List<PersonDTO> GetPersons()
        {
            List<PersonDTO> persons = new List<PersonDTO>();
            foreach (var person in context.Persons.ToList())
            {
                persons.Add(new PersonDTO(person));
            }
            return persons;
        }
        public List<LocationDTO> GetLocations()
        {
            List<LocationDTO> locations = new List<LocationDTO>();
            foreach (var location in context.Locations.ToList())
            {
                locations.Add(new LocationDTO(location));
            }
            return locations;
        }
        public List<PropertyDTO> GetProperties()
        {
            List<PropertyDTO> properties = new List<PropertyDTO>();
            foreach (var property in context.DynamicProperties.ToList())
            {
                properties.Add(new PropertyDTO(property));
            }
            return properties;
        }
        public List<PersonDTO> GetItemPersons(string path)
        {
            List<PersonDTO> personDTOs = new List<PersonDTO>();
            var item = context.MediaItems.FirstOrDefault(i => i.Path == path);
            if (item != null)
            {
                foreach (var person in item.Persons)
                {
                    personDTOs.Add(new PersonDTO(person));
                }
            }
            return personDTOs;
        }

        public List<PropertyDTO> GetItemDynamicProperties(string path)
        {
            List<PropertyDTO> propertyDTOs = new List<PropertyDTO>();
            var item = context.MediaItems.FirstOrDefault(i => i.Path == path);
            if (item != null)
            {
                foreach (var property in item.DynamicProperties)
                {
                    propertyDTOs.Add(new PropertyDTO(property));
                }
            }
            return propertyDTOs;
        }

        public List<MediaItemDTO> FileterByScalar(List<MediaItemDTO> items, string extension, bool extensionCheck, DateTime date, bool dateChecked,
            bool isPhoto, bool isPhotoChecked, string eventName, bool eventChecked)
        {
            if (extensionCheck)
            {
                items = items.Where(i => i.Extension == extension).ToList();
            }
            if (dateChecked)
            {
                items = items.Where(i => i.Date.Year == date.Year && i.Date.Month == date.Month && i.Date.Day == date.Day).ToList();
            }
            if (isPhotoChecked)
            {
                items = items.Where(i => i.IsPhoto == isPhoto).ToList();
            }
            if (eventChecked)
            {
                items = items.Where(i => i.Event == eventName).ToList();
            }
            return items;
        }

        public List<MediaItemDTO> FilterByRelation(List<MediaItemDTO> items, string value1, string value2, string value3, string filterType)
        {
            List<MediaItems> correspondingDbItems = new List<MediaItems>();
            foreach (var item in items)
            {
                var dbItem = context.MediaItems.FirstOrDefault(i => i.Path == item.Path);
                if (dbItem != null)
                {
                    correspondingDbItems.Add(dbItem);
                }
            }
            if (filterType == "People")
            {
                correspondingDbItems = correspondingDbItems.Where(i => i.Persons.Any(p =>
                p.FirstName == value1 && p.LastName == value2 && p.Group == value3)).ToList();
            }
            else if (filterType == "Locations")
            {
                correspondingDbItems = correspondingDbItems.Where(i => i.Location != null && i.Location.Name == value1
                && i.Location.Country == value2 && i.Location.Region == value3).ToList();
            }
            else if (filterType == "Properties")
            {
                correspondingDbItems = correspondingDbItems.Where(i => i.DynamicProperties.Any(p => p.Name == value1 && p.Value == value2)).ToList();
            }
            List<MediaItemDTO> filteredItems = new List<MediaItemDTO>();
            foreach (var item in correspondingDbItems)
            {
                filteredItems.Add(new MediaItemDTO(item));
            }
            return filteredItems;
        }
    }
}
