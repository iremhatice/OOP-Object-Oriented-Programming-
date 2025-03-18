using _11_Static.Example1;
using _11_Static.Example2;

namespace _11_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * Static anahtar kelimesi bir elemanın (alan, özellik veya metot) bağlı olduğu bir örneği (nesne) olmadan kullanılabilir. Ve üretilen tüm nesneler bu elemanın değerine bağımlı olur.
                * Eğer nesneye bağımlı işlemler gerçekleştirmiyorsanız - Amac sadece belirli bir duruma hizmet eden birden fazla öğeyi bir araya toplamak ise static sınıf tercih edilebilir. Instance almadan tüm öğeleri kullanılabilir.
                * Static classlar içerisinde yalnızca static öğeler barınabilir.
                * Kalıtım alamaz.
                * Static classların içinde yalnızca statik öğeler bulunurken statik bir field veya metot normal classlarda bulunabilir.
                * static üyeler sınıfın bir örneği oluşturulmadan doğrudan sınıf adı ile erişilebilir.
                * static anahtar kelimesi, sınıf üyelerinin her bir nesne için ayrı kopyalarının oluşturulmasını engeller ve tüm nesneler için ortak bir üyeye sahip olmasını sağlar.
                * static etiketini alan tum ozellikler ram uzerinde hayatta kalir. Yani isleri bitse dahi garbage collector statikleri temizleyemez. Statiklerin nesne ornegi uretilemez. Sistem ayaga kalkarken kendisi bir kez olusturur daha sonra o olusmus olan kullanilir. Sinif icerisindeki staticleri kullanmak istersek tip uzerinden gideriz. Eger static olmayanlari kullanmak istersek instance ureterek kullanmamiz gerekir.

                
             Örnekleme: Static Class nesne oluşturulmasına gerek yok.
                        Class nesne (instance) bağlantıda kullanılır.
                        Static elemanlar örnek oluşturulmasına gerek yok.
                        Static olmayan elemanlar nesne bağlamında kullanılır.

            Bellek Yönetimi: Static classlarda heap bölgesinde çalışır. Program başladığından bitimine kadar depolanmaya devam eder.
                             Sınıflarda heap bölgesinde depolanır ama garbage collector tarafından yönetilir.
            Kullanım Alanları: Static classslar, yardımcı metotlar/classlar (helper class) gibi genel işlevleri ve paylaşılan verileri yönetmek için. Nesne gerektirmeyen durumlar.

            Sınıf, Nesne gerektiren ve OOP prensiplerine uymak durumunda olduğumuz durumlar.    

             */

            #region Example-1

            int result = MathOperations.Add(9, 10);  //Nesnenin değil classın öğeleri
            double piValue = MathOperations.Pi;

            MathOperations.Pi = 2;
            Logger.Log("pi sayısına 2 atandı.");

            MathOperations mathOperations = new MathOperations();
            Console.WriteLine("Sonuç: " + mathOperations.Area(10)); //Çıktı: 200
            Logger.Log("Nesne Oluşturuldu."); //Nesne oluşturulmadan doğrudan sınıf adı ile çağrıldı.

            MathOperations mathOperations2 = new MathOperations();
            Console.WriteLine("Sonuç: " + mathOperations2.Area(30)); //Çıktı: 1800

            MathOperations mathOperations3 = new MathOperations();
            Console.WriteLine("Sonuç: " + mathOperations3.Area(50)); //Çıktı: 5000


            Console.WriteLine("Çemberin Alanı: " + MathOperations.CalculateCircleArea(12.5)); //Çıktı: Çemberin Alanı: 490,8738521234052 - Doğrudan sınıf adı ile çağrıldı.

            Counter counter1 = new Counter();
            counter1.Artis();
            counter1.Artis();
            counter1 = new Counter();
            Console.WriteLine(Counter.count); //Çıktı: 2
            counter1.Artis();
            counter1.Artis();
            counter1.Artis();
            Console.WriteLine(Counter.count); //Çıktı: 5

            Counter counter2 = new Counter();
            Console.WriteLine(Counter.count); //Çıktı: 5
            #endregion

            #region Example-2

            InventoryManager inventory = new InventoryManager();
            inventory.AddProduct(new Product("Kalem-1", 30));
            inventory.AddProduct(new Product("Kalem-2", 40));
            inventory.AddProduct(new Product("Kalem-3", 50));
            inventory.AddProduct(new Product("Kalem-4", 60));
            inventory.AddProduct(new Product("Kalem-5", 70));

            inventory.DisplayInventory();

            InventoryManager ınventory2 = new InventoryManager();
            ınventory2.AddProduct(new Product("Kitap-1", 100));
            ınventory2.AddProduct(new Product("Kitap-2", 100));
            ınventory2.AddProduct(new Product("Kitap-3", 100));

            ınventory2.DisplayInventory();
            #endregion
        }
    }
}
