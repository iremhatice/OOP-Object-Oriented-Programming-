using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Generic.Models
{
    public class FoodProduct : Product
    {
        public DateTime ExpirationTime { get; set; }
        public FoodProduct(string name, int stock, DateTime expirationTime) : base(name, stock)
        {
            ExpirationTime = expirationTime;
        }

        public override decimal TaxPrice()
        {
            return Price * 1.10m;
        }

        public override string ToString()
        {
            return base.ToString() + $" Expiration Date: {ExpirationTime}";
        }
    }
}
