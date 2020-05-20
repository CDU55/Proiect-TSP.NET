using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proiect_TSPNET;

namespace Interfata_ASP.Filter
{
    public static class ItemFilter
    {
        public static bool Filter(MediaItemDTO item, string filter, string filterValue)
        {
            if (filter == "Title")
            {
                return FilterByTitle(item, filterValue);
            }
            else if (filter == "Extension")
            {
                return FilterByExtension(item, filterValue);
            }
            else if (filter == "Description")
            {
                return FilterByDescription(item, filterValue);
            }
            else if (filter == "Location")
            {
                return FilterByLocation(item, filterValue);
            }
            else if (filter == "Event")
            {
                return FilterByEvent(item, filterValue);
            }
            else if (filter == "Persons")
            {
                return FilterByPerson(item, filterValue);
            }
            else if (filter == "Property")
            {
                return FilterByProperty(item, filterValue);
            }
            else
            {
                return true;
            }
        }
        private static bool FilterByTitle(MediaItemDTO item, string titleFilter)
        {
            if (item.Title.Contains(titleFilter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FilterByExtension(MediaItemDTO item, string extensionFilter)
        {
            if (item.Extension.Contains(extensionFilter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FilterByLocation(MediaItemDTO item, string locationFilter)
        {
            if (item.Location.Contains(locationFilter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FilterByEvent(MediaItemDTO item, string eventFilter)
        {
            if (item.Event.Contains(eventFilter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FilterByDescription(MediaItemDTO item, string descriptionFilter)
        {
            if (item.Description.Contains(descriptionFilter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool FilterByPerson(MediaItemDTO item, string personFilter)
        {
            if (item.persons.Length == 0)
            {
                return false;
            }
            else
            {
                foreach (var person in item.persons)
                {
                    string personName = person.FirstName + " " + person.LastName;
                    if (personName.Contains(personFilter) || person.Group.Contains(personFilter))
                    {
                        return true;
                    }
                }
                return true;
            }

        }

        private static bool FilterByProperty(MediaItemDTO item, string propertyFilter)
        {
            if (item.properties.Length == 0)
            {
                return false;
            }
            else
            {
                foreach (var property in item.properties)
                {
                    if (property.Value.Contains(propertyFilter))
                    {
                        return false;
                    }
                }
                return false;
            }
        }


    }
}
