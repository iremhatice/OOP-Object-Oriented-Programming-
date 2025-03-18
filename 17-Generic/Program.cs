using _17_Generic.Exceptions;
using _17_Generic.Models;
using _17_Generic.Repository.Concrete;

namespace _17_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Generic yapılar,belirli bir tipe bağlı olmak yerine herhangi bir veri tipiyle çalışabilen sınıfların, interfacelerin, metotlarını field..oluşturulmasına izin verir.
                * Generic yapılar farklı türlerdeki verilerle çalışabilen kod oluşturmamız gerektiğinde kullanışlıdır.
                * Constraint: generic yapılarda tipleri sınırlamak için üç anahtar kelime kullanılır class,struct ve BaseClass
                    - Class: sadece referans tiplerin kabul edilmesini güvence altına alır.
                    - Struct: sadece value tiplerin kabul edilmesini güvence altına alır.
                    - BaseClass: sadece belirli bir temel sınıftan türetilmesini güvence altına alır.
                * 
             */

            InventoryManagement<FoodProduct> inventoryFood = new InventoryManagement<FoodProduct>();

            foreach (var item in inventoryFood.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n" + new string('*', 20) + "\n");
            inventoryFood.Add(new FoodProduct("Kivi", 100, DateTime.Now.AddDays(10)) { Price = 100 });

            foreach (var item in inventoryFood.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n" + new string('*', 20) + "\n");

            var product = inventoryFood.Get(3);
            Console.WriteLine(product);

            Console.WriteLine("\n" + new string('*', 20) + "\n");

            inventoryFood.Add(product);

            foreach (var item in inventoryFood.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n" + new string('*', 20) + "\n");

            try
            {
                inventoryFood.Update(new FoodProduct("Kivi", 200, DateTime.Now.AddDays(10)), 6);

                Console.WriteLine("\n" + new string('*', 20) + "\n");

                foreach (var item in inventoryFood.GetAll())
                {
                    Console.WriteLine(item);
                }
            }
            catch (StockAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            InventoryManagement<ElectronicProduct> inventoryManagement = new InventoryManagement<ElectronicProduct>();

            foreach (var item in inventoryManagement.GetAll())
            {
                Console.WriteLine(item);
            }

        }
    }
}
