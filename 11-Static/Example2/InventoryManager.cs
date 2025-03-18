using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Static.Example2
{
    public class InventoryManager
    {
        private List<Product> products;
        public InventoryManager()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"{product.Name} added to inventory");
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Inventory: ");
            foreach (var product in products)
            {
                product.DisplayProductInfo();
            }
        }
    }
}
