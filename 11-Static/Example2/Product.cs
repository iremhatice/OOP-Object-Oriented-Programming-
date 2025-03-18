using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Static.Example2
{
    public class Product
    {
        public Product(string name, double price)
        {
            ProductId = GenerateProductId();
            Name = name;
            Price = price;
            TotalProductsInInventory++;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //Static Özellikler (Properties): Static özellikler, sınıfın örneklerinden bağımsız olarak değer alıp verebilir.
        public static int TotalProductsInInventory { get; private set; }

        private int GenerateProductId()
        {
            return TotalProductsInInventory + 1;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Id: {ProductId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price:  {Price}");
        }

    }
}
