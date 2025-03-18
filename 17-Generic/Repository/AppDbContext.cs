using _17_Generic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Generic.Repository
{
    public static class AppDbContext
    {
        public static List<Product> products = new List<Product>()
        {
            new FoodProduct("Elma", 1000, DateTime.Now.AddMonths(1)) { Price=50 },
            new FoodProduct("Muz", 1200, DateTime.Now.AddDays(4)) { Price=80 },
            new FoodProduct("Portakal", 1500, DateTime.Now.AddDays(20)) { Price=70 },
            new ElectronicProduct("Laptop", 15, 2) { Price=70000 },
            new ElectronicProduct("TV", 25, 5) { Price=130000 },
        };
    }
}
