using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Category{ get; set; }
        public string Manufacturer{ get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string Recipe { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime SellBeforeDate { get; set; }
        public string PhotoURL { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }

        public string[] Info()
        {
            string[] s = new string[4];
            s[0] = Id.ToString();
            s[1] = Name;
            s[2] = SellingPrice.ToString();
            s[3] = Count.ToString();
            return s;
        }

        public string[] InfoCate()
        {
            string[] s = new string[3];
            s[0] = Name;
            s[1] = SellingPrice.ToString();
            s[2] = Count.ToString();
            return s;
        }

        public string[] InfoNew()
        {
            string[] s = new string[4];
            s[0] = Id.ToString();
            s[1] = Name;
            s[2] = PurchasePrice.ToString();
            s[3] = Count.ToString();
            return s;
        }
    }
}
