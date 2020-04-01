using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    public class PersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }

        public PersonDTO(Persons person)
        {
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.Group = person.Group;
        }
    }
}
