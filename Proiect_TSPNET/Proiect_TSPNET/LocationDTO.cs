using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    [DataContract]
    public class LocationDTO
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Region { get; set; }
        [DataMember]
        public string Country { get; set; }
        public LocationDTO(Locations location)
        {
            this.Name = location.Name;
            this.Country = location.Country;
            this.Region = location.Region;
        }
    }
}
