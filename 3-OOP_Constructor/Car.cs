using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOP_Constructor
{
    public class Car
    {
        //Constructor (yapıcı metot), bir sınıfın instance'nın alındığında anda çalışacak metot. Constructor, nesnenin başlangıç durumunu ayarlamak, gerekli verileri hazırlamak veya bazı başlangıç işlemlerini gerçekleştirmek için kullanılır.Constructor’lar, sınıfın bir örneği(nesnesi) oluşturulduğunda otomatik olarak çalışır.Genellikle Field (Alanlar) için başlangıç değerlerini ayarlamak için kullanılabilir.
        //Main metoda benzetilir.Genellikle bir sınıfın özelliklerini/alanlarını nesne oluşturma esnasında çalıştırmak için kullanılır.

        // Yapıcı metod (constructor)
        public Car()
        {

        }
        public Car(string brand,string name)
        {
            Brand = brand; // Property üzerinden atama yapılıyor
            _name = name;   // field'a değer atanıyor
        }

        public Car(string brand, string model, int engine)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
        }

        public Car(int color)
        {
            Color = color;
        }

        //Field
        private string _name;

        // Destructor : Yikici metot. Nesne bellekten silindiğinde otomatik olarak çalışan bir metodur. Bu metod, genellikle nesnenin kaynaklarını(örneğin, dosya işaretçileri veya veritabanı bağlantıları) serbest bırakmak için kullanılır. Bu metot ram uzerinden ilgili nesnenin isi bitirilip kaldirilacagi esnada calistirilir. Zaman bagimsiz calismaktadir kullanimi tercih edilmez.
        ~Car()
        {
            Console.WriteLine(Brand);
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Engine { get; set; }
        public int Color { get; set; }

        // Metot: Nesnenin davranışlarını ifade eder. Metodlar, nesnenin işlevlerini gerçekleştirmek için kullanılır.
        public void CarNameShow()
        {
            Console.WriteLine($"Arabanın Ismi: {_name}");
        }
    }
}
