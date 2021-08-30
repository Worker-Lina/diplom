using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Models
{
    public class Purchase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public List<Product> products;
        public Dictionary<Product, int> producttes;
        public decimal sum;
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
