using _12_Extension.Extensions;
using _12_Extension.Models;

namespace _12_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * Extension (genişletme) metotları, mevcut sınıflara veya arayüzlere yeniden derlemeye gerek kalmadan yeni metotlar eklemeyi sağlar. Bu metotlar genellikle yardımcı (utility) metotlar yazarken kullanılır ve bir sınıfın işlevselliğini genişletmeye yardımcı olur.
                * Extension metotlarını yazarken hem sınıfın hem de metodun static olması gerekir. Bunun sebepleri şunlardır:
                       * Mevcut sınıfın örneği (instance) üzerinde değişiklik yapmazlar. Extension metotları, hedef sınıfın örneğine (instance) bağımsız olarak çalışır ve doğrudan nesne örneği oluşturmazlar.
                       * Gerçekten bir sınıfın parçası değillerdir. Bunlar aslında this anahtar kelimesiyle belirlenen bir parametre aracılığıyla çalışırlar. Yani sadece süslü bir "yardımcı" metot gibi çalışırlar, ancak hedef sınıfın içinde tanımlı değillerdir.
                       * Bellek ve performans avantajı sağlar. static sınıflar örneklenemez ve bellekte daha az yer kaplar.

               Extension Metotları Ne Ise Yarar?
                * Mevcut sınıfları değiştirmeden yeni özellikler eklemek
                * Kod tekrarını azaltmak
                * Daha temiz ve okunabilir kod yazmak
             */

            //geliştirme metotları
            Console.WriteLine("Hello World".ReverseString());

            string isim = "irem";
            Console.WriteLine(isim.CapitaliceFirst());
            Console.WriteLine(isim.CapitaliceFirst(3));

            try
            {
                int x = int.Parse("dfdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetFriendlyMessage());
            }

            Student student = new Student();
            student.Scores.Add(70);
            student.Scores.Add(75);
            student.Scores.Add(55);

            Console.WriteLine(student.IsSuccesful());

            MovieCollection collection = new MovieCollection();
            collection[0] = "Inception";
            Console.WriteLine(collection[2]);
        }
    }
}
