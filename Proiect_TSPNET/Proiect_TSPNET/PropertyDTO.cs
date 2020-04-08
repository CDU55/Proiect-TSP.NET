using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    [DataContract]
    public class PropertyDTO
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Value { get; set; }
        public PropertyDTO(DynamicProperties propery)
        {
            this.Name = propery.Name;
            this.Value = propery.Value;
        }
    }
}
