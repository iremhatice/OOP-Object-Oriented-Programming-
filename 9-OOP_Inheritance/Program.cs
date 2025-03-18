using _6_OOP_Inheritance.Example1;
using _6_OOP_Inheritance.Example2;
using System.Security.Claims;

namespace _6_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
              * Inheritance: Bir sınıfa ait alanların, özellliklerin ve metotların kalıtım yoluyla diğer sınıflara aktarılmasına denir. C# programlamada bir sınıfın başka bir sınıftan özelliklerini (alanlar, metotlar) ve davranışlarını miras alması anlamına gelir.Yani bir sınıf, başka bir sınıfın tüm veri ve davranışlarını kullanabilir ve bunları genişletebilir veya değiştirebilir.Miras veren sınıf “üst sınıf” veya “temel sınıf” olarak adlandırılırken, miras alan sınıf “alt sınıf” veya “türetilmiş sınıf” olarak adlandırılır.

              * Yani Kalıtım, bir sınıfın (alt sınıf) başka bir sınıfın (üst sınıf) özelliklerini ve metotlarını devralmasıdır. Alt sınıf, üst sınıfın tüm özelliklerini ve davranışlarını kullanabilir, ayrıca yeni özellikler ekleyebilir.

              * Base Class (Parent): miras/kalıtım alınan sınıf.
              * Sub Class (Child): miras/kalıtım veren sınıf.

              * Inheritance (Miras Alma) Kullanımı:
              * Ortak Özellikleri ve Davranışları Gruplamak: Birden fazla sınıfın ortak özellikleri veya davranışları varsa, bu ortaklıkları bir üst sınıfta gruplayarak kod tekrarını önleyebilirsiniz.
              * Kod Tekrarından Kaçınmak: Miras alma, aynı veya benzer kod bloklarının birden fazla sınıfta tekrar edilmesini engeller. Bu şekilde kodunuz daha temiz ve daha az hata yapma olasılığı yüksek olur.
              * IS-A İlişkisini Yansıtmak: Alt sınıfların, üst sınıfın bir türü olduğunu ve üst sınıfın özelliklerini taşıdığını yansıtmak için inheritance kullanılır. Örneğin, “Otomobil” bir “Araba” türüdür.
              * Türetilmiş Sınıfları Gruplamak: İlgili türetilmiş sınıfları aynı hiyerarşide gruplayarak kodunuzun daha düzenli ve anlaşılır olmasını sağlayabilirsiniz.
            */

            #region Example-1

            MobilePhone mobilePhone = new MobilePhone();
            mobilePhone.HasCamera = true;
            Console.WriteLine(mobilePhone.TakePhoto());
            Console.WriteLine(mobilePhone.Call());
            Console.WriteLine(mobilePhone.ConnectionStatus());
            #endregion

            #region Example-2

            NormalUye normalUye = new NormalUye();

            NormalUye normalUye1 = new NormalUye(1, "Fatih", 2021, 500);
            Console.WriteLine(normalUye1.ToString());
            Console.WriteLine("Yıllık ücret: " + normalUye1.AidatHesapla());

            NormalUye normalUye2 = new NormalUye(2, "Ilknur", 2022, 500);
            Console.WriteLine(normalUye1.ToString());
            Console.WriteLine("Yıllık ücret: " + normalUye2.AidatHesapla());

            VIPUye VIPUye1 = new VIPUye(3, "Mehmet", 2022, 850);
            Console.WriteLine(VIPUye1.ToString());
            Console.WriteLine("Yıllık VIP Ücret: " + VIPUye1.AidatHesapla());

            VIPUye VIPUye2 = new VIPUye(4, "Irem", 2022, 750);
            Console.WriteLine(VIPUye2.ToString());
            Console.WriteLine("Yıllık VIP Ücret: " + VIPUye2.AidatHesapla());

            VIPUye VIPUye3 = new VIPUye(5, "Tugba", 2022, 950);
            Console.WriteLine(VIPUye3.ToString());
            Console.WriteLine("Yıllık VIP Ücret: " + VIPUye3.AidatHesapla());

            List<Uye> list = new List<Uye>();
            list.Add(normalUye1);
            list.Add(normalUye2);
            list.Add(VIPUye1);
            list.Add(VIPUye2);
            list.Add(VIPUye3);

            foreach (Uye item in list)
            {
                // Console.WriteLine("Yıllık ücret: " + item.AidatHesapla());
                if (item.GetType() == typeof(VIPUye))
                {
                    Console.WriteLine("VIP Üye");
                    var item2 = (VIPUye)item;
                }
                else
                {
                    var item2 = (NormalUye)item;
                }
            }
            #endregion
        }
    }
}
