using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Models
{
    public class Employee 
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Login { get; set; }
        public string Password { get; set; }
        public string FIO { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfEmployment { get; set; } = DateTime.Now;
        public string PhotoURL { get; set; }

        public string[] Info()
        {
            string[] s = new string[5];
            s[0] = Id.ToString();
            s[1] = FIO;
            s[2] = Position;
            s[3] = Salary.ToString();
            s[4] = Phone;
            return s;
        }
    }
}
