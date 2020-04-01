using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    public class LocationDTO
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public LocationDTO(Locations location)
        {
            this.Name = location.Name;
            this.Country = location.Country;
            this.Region = location.Region;
        }
    }
}
