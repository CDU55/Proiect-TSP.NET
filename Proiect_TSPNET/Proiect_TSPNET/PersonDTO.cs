using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    [DataContract]
    public class PersonDTO
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Group { get; set; }

        public PersonDTO(Persons person)
        {
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.Group = person.Group;
        }
    }
}
