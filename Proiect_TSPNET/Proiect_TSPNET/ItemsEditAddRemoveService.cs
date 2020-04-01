using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    public class ItemsEditAddRemoveService : IItemsEditAddRemoveService
    {
        private readonly ModelContainer context;
        public ItemsEditAddRemoveService()
        {
            this.context = ModelContainer.GetContext();
        }

        public bool AddPerson(string firstName, string lastName, string group)
        {
            var alreadyExists = context.Persons.Any(p => p.FirstName == firstName && p.LastName == lastName && p.Group == group);
            if (alreadyExists)
            {
                return false;
            }
            else
            {
                Persons p = new Persons()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Group = group
                };
                context.Persons.Add(p);
                context.SaveChanges();
                return true;
            }
        }

        public bool AddLocation(string name, string country, string region)
        {
            var alreadyExists = context.Locations.Any(l => l.Name == name && l.Country == country && l.Region == region);
            if (alreadyExists)
            {
                return false;
            }
            else
            {
                Locations l = new Locations()
                {
                    Name = name,
                    Country = country,
                    Region = region
                };
                context.Locations.Add(l);
                context.SaveChanges();
                return true;
            }
        }

        public bool AddDynamicPropery(string name, string value)
        {
            var alreadyExists = context.DynamicProperties.Any(p => p.Name == name && p.Value == value);
            if (alreadyExists)
            {
                return false;
            }
            else
            {
                DynamicProperties p = new DynamicProperties()
                {
                    Name = name,
                    Value = value
                };
                context.DynamicProperties.Add(p);
                context.SaveChanges();
                return true;
            }
        }

        public bool AttachDynamicProperty(string itemPath, string properyName, string propertyValue)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            var property = context.DynamicProperties.FirstOrDefault(p => p.Name == properyName && p.Value == propertyValue);
            if (item == null || property == null)
            {
                return false;
            }
            else
            {
                if (property.MediaItems.Any(i => i.Path == itemPath))
                {
                    return false;
                }
                else
                {
                    item.DynamicProperties.Add(property);
                    property.MediaItems.Add(item);
                    context.SaveChanges();
                    return true;
                }
            }
        }
        public bool ChangeLocation(string itemPath, string locationName, string locationCountry, string locationRegion)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            var location = context.Locations.FirstOrDefault(l => l.Name == locationName && l.Country == locationCountry && l.Region == locationRegion);
            if (item == null || location == null)
            {
                return false;
            }
            else
            {
                if (item.Location != null && item.Location.Name == location.Name
                    && item.Location.Country == location.Country && item.Location.Region == location.Region)
                {
                    return false;
                }
                else
                {
                    if (item.Location != null)
                    {
                        item.Location.MediaItems.Remove(item);
                    }
                    item.Location = location;
                    location.MediaItems.Add(item);
                    context.SaveChanges();
                    return true;
                }
            }
        }
        public bool RemoveLocation(string itemPath)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            if (item == null || item.Location == null)
            {
                return false;
            }
            else
            {
                item.Location.MediaItems.Remove(item);
                item.Location = null;
                context.SaveChanges();
                return true;
            }
        }
        public bool ChangeEvent(string itemPath, string eventName)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            var eventt = context.Events.FirstOrDefault(e => e.Name == eventName);
            if (item == null)
            {
                return false;
            }
            else
            {
                if (eventt == null)
                {
                    Events e = new Events()
                    {
                        Name = eventName
                    };
                    eventt = e;
                    context.Events.Add(e);
                    context.SaveChanges();
                }
                if (item.Event != null && item.Event.Name == eventt.Name)
                {
                    return false;
                }
                else
                {
                    if (item.Event != null)
                    {
                        item.Event.MediaItems1.Remove(item);
                    }
                    item.Event = eventt;
                    eventt.MediaItems1.Add(item);
                    context.SaveChanges();
                    return true;
                }
            }
        }
        public bool RemoveEvent(string itemPath)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            if (item == null || item.Event == null)
            {
                return false;
            }
            else
            {
                item.Event.MediaItems1.Remove(item);
                item.Event = null;
                context.SaveChanges();
                return true;
            }
        }
        public bool ChangeDate(string itemPath, DateTime newDate)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            if (item == null)
            {
                return false;
            }
            else
            {
                item.Date = newDate;
                context.SaveChanges();
                return true;
            }
        }

        public bool EditItem(string itemPath, string newDescription, bool changeDescription, string eventName, bool changeEvent, DateTime newDate, bool changeDate)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            if (item == null)
            {
                return false;
            }
            else
            {
                if (!changeDate && !changeDescription && !changeEvent)
                {
                    return false;
                }
                else
                {
                    if (changeDescription)
                    {
                        ChangeDescription(itemPath, newDescription);
                    }
                    if (changeDate)
                    {
                        ChangeDate(itemPath, newDate);
                    }
                    if (changeEvent)
                    {
                        ChangeEvent(itemPath, eventName);
                    }
                    return true;
                }
            }
        }
        public bool AttachPerson(string itemPath, string personFirstName, string personLastName, string personGroup)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            var person = context.Persons.FirstOrDefault(p => p.FirstName == personFirstName && p.LastName == personLastName && p.Group == personGroup);
            if (item == null || person == null)
            {
                return false;
            }
            else
            {
                if (person.MediaItems.Any(i => i.Path == itemPath))
                {
                    return false;
                }
                else
                {
                    item.Persons.Add(person);
                    person.MediaItems.Add(item);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public bool RemovePerson(string itemPath, string personFirstName, string personLastName, string personGroup)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            var person = context.Persons.FirstOrDefault(p => p.FirstName == personFirstName && p.LastName == personLastName && p.Group == personGroup);
            if (item == null || person == null)
            {
                return false;
            }
            else
            {
                if (!item.Persons.Any(p => p.FirstName == personFirstName && p.LastName == personLastName && p.Group == personGroup))
                {
                    return false;
                }
                else
                {
                    item.Persons.Remove(person);
                    person.MediaItems.Remove(item);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public bool RemoveDynamicProperty(string itemPath, string properyName, string propertyValue)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            var property = context.DynamicProperties.FirstOrDefault(p => p.Name == properyName && p.Value == propertyValue);
            if (item == null || property == null)
            {
                return false;
            }
            else
            {
                if (!item.DynamicProperties.Any(p => p.Name == properyName && p.Value == propertyValue))
                {
                    return false;
                }
                else
                {
                    item.DynamicProperties.Remove(property);
                    property.MediaItems.Remove(item);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public bool MarkForDelete(string itemPath)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            if (item == null)
            {
                return false;
            }
            else
            {
                item.MarkedForDelete = !item.MarkedForDelete;
                context.SaveChanges();
                return true;
            }
        }

        public bool ChangeDescription(string itemPath, string description)
        {
            var item = context.MediaItems.FirstOrDefault(i => i.Path == itemPath);
            if (item == null)
            {
                return false;
            }
            else
            {
                item.Description = description;
                context.SaveChanges();
                return true;
            }
        }

        public bool RemovePersonFromContext(string firstName, string lastName, string group)
        {
            var person = context.Persons.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName && p.Group == group);
            if (person == null)
            {
                return false;
            }
            else
            {
                foreach (var item in person.MediaItems)
                {
                    item.Persons.Remove(person);
                }
                context.Persons.Remove(person);
                context.SaveChanges();
                return true;
            }
        }
        public bool RemovePropertyFromContext(string name, string value)
        {
            var property = context.DynamicProperties.FirstOrDefault(p => p.Name == name && p.Value == value);
            if (property == null)
            {
                return false;
            }
            else
            {
                foreach (var item in property.MediaItems)
                {
                    item.DynamicProperties.Remove(property);
                }
                context.DynamicProperties.Remove(property);
                context.SaveChanges();
                return true;
            }
        }
        public bool RemoveLocationFromContext(string name, string country, string region)
        {
            var location = context.Locations.FirstOrDefault(l => l.Name == name && l.Country == country && l.Region == region);
            if (location == null)
            {
                return false;
            }
            else
            {
                foreach (var item in location.MediaItems)
                {
                    item.Location = null;
                }
                context.Locations.Remove(location);
                context.SaveChanges();
                return true;

            }
        }

    }

}
