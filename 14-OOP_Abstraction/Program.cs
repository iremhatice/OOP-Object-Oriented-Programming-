using _14_OOP_Abstraction.Example1;
using _14_OOP_Abstraction.Example2;

namespace _14_OOP_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Abstraction: Oop nin soyutlama ilkesi, bir sınıftan nesne üretmek mantıksız geliyorsa o sınıf soyutlanabilir. Alt sınıfların ortak özelliklerini ve işlevlerinin taşıyan ama nesne olmayan üst sınıf oluşturmak istiyorsak abstract şeklinde üst sınıf oluşturabiliriz.  
            * Soyut sınıfların doğrudan bir örneği oluşturulamaz, ancak bu sınıflardan türetilmiş alt sınıflar tanımlanabilir ve soyut metotlar bu alt sınıflar tarafından zorunlu olarak uygulanmalıdır.   
            
            * Abstract Class: Nesne oluşturmak için kullanılamayan kısıtlı bir sınıftır (erişmek için başka bir sınıftan miras alınmalıdır).
            * Abstract bir class'ın en önemli özelliği içerisinde abstract olan veya olmayan metotlar barındırabilmesidir.
            * Abstract sınıflar, genellikle ortak özellikleri ve davranışları içerir.
            * Alt sınıflar, abstract sınıfın ortak özelliklerini miras alabilir ve gerektiğinde bu özellikleri değiştirebilir.
            * Abstract Class'lar, sadece base class olarak davranmasını (Yani instance çıkartılmamasını) istediğimiz durumlarda kullanışlıdır. (Merkeziyetçilik)
            
            * Abstract Method: Sadece soyut bir sınıfta kullanılabilir ve gövdesi yoktur. Gövde türetilmiş sınıf tarafından sağlanır (miras alınır).
            *  Abstract Metotlar (Abstract metotlar tanımlanırken aşağıda ki kurallara dikkat etmeliyiz.)
                - Abstract bir metot private olarak tanımlanamazlar. Çünkü private metotlar, miras alınan classlarda implement edilmezler. Bu da abstract yapısına ters  düşmektedir.
                - Abstract metotlar sadece abstract class'ların içerisinde tanımlanır.
                - Abstract metotlar virtual olarak tanımlanamazlar. Her abstract class virtual'dır.
                - Abstract static olarakta tanımlanamazlar.
                - Abstact metot'un GÖVDESİ OLAMAZ.
                - Abstract Metotlar, kalıtım aldığı class'da implement edilerek uygulanması zorunludur.

            * Abstract Sınıfların Kullanımı:
                - Ortak Özellikleri ve Davranışları Gruplamak: Birden fazla sınıfın ortak özellikleri veya davranışları varsa, bu ortaklıkları abstract bir sınıfta toplayarak kod tekrarından kaçınabilirsiniz.
                - Temel Bir Yapıyı Tanımlamak: Bir abstract sınıf, bir temel yapının (örneğin, bir arabayı temsil eden) tanımlandığı yerdir. Bu sınıflar, alt sınıfların bu temel yapının özelliklerini ve davranışlarını genişletebileceği bir temel sağlar.
                - Metotları Zorunlu Kılmak: Abstract sınıflar içinde tanımlanan soyut metotlar, alt sınıflarca zorunlu olarak uygulanmalıdır. Bu sayede alt sınıflar belirli bir davranışı uygulamak zorunda kalır. 
                - Türetilmiş Sınıfları Gruplamak: Abstract sınıflar, alt sınıfların mantıklı bir şekilde gruplandırılmasını sağlar. Örneğin, farklı türdeki hayvanları temsil eden alt sınıflar, abstract bir "Hayvan" sınıfından türebilir.
                - Base Class'ın Değişebileceği Durumlar: Eğer bir türetilmiş sınıfın türleri arasında aynı temel yapının olmasını istiyorsanız, abstract sınıflar kullanabilirsiniz. Bu şekilde temel yapının alt sınıflar arasında değiştirilmesi kolaylaşır.
 
            * Abstract Metotların Kullanımı:
                 - Alt Sınıfların Farklı Davranışlar Sergilemesi: Bir abstract metot, alt sınıfların aynı isimli metotları farklı davranışlar sergilemesini sağlar. Polymorphism prensibini uygulamanın bir yoludur.
                - Alt Sınıfların Zorunlu İmplementasyonu: Eğer alt sınıfların belirli bir davranışı zorunlu olarak uygulamasını istiyorsanız, bu davranışı abstract bir metot olarak tanımlayabilirsiniz.
                - Interfacelerle Alternatif Karşılaştırma: Soyut metotlar, interfaceler gibi türetilmiş sınıfların belirli bir davranışı uygulamasını sağlar. Ancak abstract sınıflar, ortak özellikleri ve davranışları da içerebilir.
                - Kodun Daha Anlaşılır Olması: Abstract metotlar, türetilmiş sınıfların belirli bir davranışı uyguladığını açıkça ifade eder. Bu sayede kodun daha anlaşılır olmasını sağlar.
    
            */

            #region Example-1
            //Tur tur = new Tur(); //Abstract class oldugundan hata verir.Ornegi olusturulamaz.

            Insan insan = new Insan();
            insan.CanliTuru = "İnsan";
            insan.Aile = "Homo sapiens";
            insan.Familya = "sapiens sapiens";
            insan.TurGoster();
            insan.AileGoster();
            insan.FamilyaGoster();

            Hayvan hayvan = new Hayvan();
            hayvan.CanliTuru = "Hayvan";
            hayvan.Aile = "hhh";
            hayvan.Familya = "nsjds";
            hayvan.TurGoster();
            hayvan.AileGoster();
            hayvan.FamilyaGoster();
            Console.ReadLine();
            #endregion

            #region Example-2

            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new SavingsAccount("SA123", "Emre")); //0
            accounts.Add(new CurrentAccount("SA123", "Emre")); //1

            while (true)
            {
                Console.Write("Çekmek istediğiniz miktar: ");
                double amount = double.Parse(Console.ReadLine());

                Console.Write("Hangi hesabından çekmek istiyorun [0] Vadeli Hesap [1] Cari Hesap: ");
                int result = int.Parse(Console.ReadLine());

                accounts[result].Withdraw(amount);
                Console.WriteLine(accounts[result].DisplayBalance());
            }
            #endregion
        }
    }
}
