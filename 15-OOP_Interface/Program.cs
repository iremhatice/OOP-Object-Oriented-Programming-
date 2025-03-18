using _15_OOP_Interface.Example1;
using _15_OOP_Interface.Example2;
using _15_OOP_Interface.Example3;

namespace _15_OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Interface (arayüz): Sadece gövdesi olmayan metotlar ve properties içerebilir. Ek olarak field, constructor oluşturulamaz.(nesne oluşturmak için kullanılamadığı için)

             Interface, yalnızca soyut metotları ve özellikleri (boş gövdelerle) içerebilen tamamen soyut bir yapıdır.

             * Bir alt sınıf bir interface'i miras aldığında bu interface uygulamak zorundadır.Interface'i bir sözleşmenin maddeleri gibi düşünebilirsiniz. Kalıtım alan taraf bu sözleşmenin tüm maddelerini uygulamak zorundadır.
             * Bir sınıf birden fazla interface'den kalıtım alabilir.
             * Içerisinde kendisinden türeyecek sınıfların kullanacağı metotların boş halini ve yazılması gereken özellikleri barındırır.
             * Metotların sadece imzası kullanılır.Içi onu miras alan sınıfta doldurulur.
             * Kalıtım alırken önce class kalıtım alınır sonra interface alınır.
             * Abstact sınıflar gibi, interfaceler nesne oluşturmak için kullanılamaz .
             * Interface metodlarının bir gövdesi yoktur - gövde "uygulama" sınıfı tarafından sağlanır.
             * Bir interface’in uygulanmasında, tüm metotlarını override etmeniz gerekir.

             
               Interface Kısıtlamaları
             * Erişim belirleyicisi tanımlanmaz. Içsel olarak publictir.
             * Kurucu metot içermezler.
             * Metot gövdesi yazılmaz.
             * Arayüzler sadece arayüzlerden türetilebiir.
             * Interfacelerde field tanımlanamaz.

             */

            #region Example-1

            IMailService mailService = new MyMailService();
            mailService.Title = "Başlık";
            mailService.Body = "Gövde";
            mailService.From = "mail@mail.com";
            mailService.To.Add("fatih@mail.com");
            mailService.Send();
            #endregion

            #region Example-2

            Futbolcu defans = new Futbolcu()
            {
                AdiSoyadi = "Eren Aslan",
                FormaNumarasi = "54",
                KosmaHizi = 80,
                PasGucu = 60,
                SutGucu = 70,
                Sakatmi = true
            };

            Kaleci kaleci = new Kaleci();

            List<IFutbolcu> takim = new List<IFutbolcu>();
            takim.Add(defans);
            takim.Add(kaleci);

            #endregion

            #region Example-3

            IDataService dataService = new XSqlService();
            dataService.Create();
            dataService.Update(3);
            dataService.Delete(2);
            #endregion
        }
    }
}
