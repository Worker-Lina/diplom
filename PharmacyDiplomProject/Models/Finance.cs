using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Models
{
    public class Finance
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal Summa { get; set; }

        public string[] Info()
        {
            string[] s = new string[5];
            s[0] = ProductId.ToString();
            s[1] = Name;
            s[2] = Price.ToString();
            s[3] = Count.ToString();
            s[4] = Summa.ToString();
            return s;
        }
    }

}
