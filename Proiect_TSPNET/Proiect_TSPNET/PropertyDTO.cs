using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    public class PropertyDTO
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public PropertyDTO(DynamicProperties propery)
        {
            this.Name = propery.Name;
            this.Value = propery.Value;
        }
    }
}
