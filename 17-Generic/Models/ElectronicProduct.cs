using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Generic.Models
{
    public class ElectronicProduct : Product
    {
        public int WarrantyPeriod { get; set; }
        public ElectronicProduct(string name, int stock, int warrantyPeriod) : base(name, stock)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public override decimal TaxPrice()
        {
            return Price * 1.20m;
        }

        public override string ToString()
        {
            return base.ToString() + $" Warranty Period: {WarrantyPeriod} years.";
        }
    }
}
