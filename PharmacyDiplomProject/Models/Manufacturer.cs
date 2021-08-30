using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Models
{
    public class Manufacturer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public string[] Info()
        {
            string[] s = new string[6];
            s[0] = Id.ToString();
            s[1] = Name;
            s[2] = City;
            s[3] = Country;
            s[4] = Address;
            s[5] = Phone;
            return s;
        }
    }
}
