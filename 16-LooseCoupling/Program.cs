using _16_LooseCoupling.LooseTightlyCoupling;

namespace _16_LooseCoupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               * C#’ta Coupling, C#’taki modüller arasındaki ilişkiyi, sınıfların ve nesnelerin nasıl bağlandığını ve ayrıca bunların birbirlerine ne kadar bağımlı olduklarını açıklar. Bu aynı zamanda kodun esneklik ve yeniden kullanılabilirlik kısmını da açıklar.
               
               * Loose Coupling (Gevşek Bağlılık), yazılım geliştirme sürecinde bileşenler arasındaki bağımlılıkları minimize etmeyi hedefleyen bir tasarım prensibidir. Bir sistemin modülleri veya bileşenleri birbirine sıkı sıkıya bağlı olmadığında, değişiklikler bir bileşenden diğerine minimum etkiyle yansır. Bu, sistemin daha esnek, sürdürülebilir ve ölçeklenebilir olmasını sağlar.
               
               * Loose Coupling, yazılımın modüler olmasını sağlar ve değişikliklerin sistemin geri kalanını etkilemeden yapılmasına olanak tanır. Yazılım geliştirme sürecinde arayüzler, bağımlılık enjeksiyonu ve tasarım kalıpları gibi yöntemlerle bu prensip uygulanabilir.

               Loose Coupling’in Faydaları:
                 *  Bakım Kolaylığı – Bir bileşeni değiştirdiğinizde diğer bileşenleri etkileme olasılığı düşer.
                 *  Yeniden Kullanılabilirlik – Bileşenler bağımsız olarak tasarlandığında, başka projelerde veya sistemlerde kolayca yeniden kullanılabilir.
                 *  Esneklik ve Genişletilebilirlik – Yeni özellikler eklemek veya mevcut bileşenleri değiştirmek daha kolay hale gelir.
                 *  Test Edilebilirlik – Bağımsız bileşenlerin test edilmesi daha kolaydır, çünkü diğer modüllerden izole bir şekilde çalıştırılabilirler.
                 
               Loose Coupling Nasıl Sağlanır?
                 * Arayüzler (Interfaces) Kullanmak → Sınıfların doğrudan birbirine bağımlı olmasını engeller.
                 * Bağımlılık Ters Çevirme Prensibi (Dependency Inversion Principle - DIP) → Üst seviye bileşenler, alt seviye bileşenlere doğrudan bağımlı olmak yerine, arayüzler veya soyutlamalar üzerinden iletişim kurar.
                 * Bağımlılık Enjeksiyonu (Dependency Injection - DI) → Sınıfların bağımlılıklarını dışarıdan almasını sağlar.
                 * Observer, Factory, Strategy gibi Tasarım Kalıpları → Bileşenler arasındaki bağımlılığı azaltarak esneklik kazandırır.
                 * Service-Oriented Architecture (SOA) veya Mikroservis Mimarisi Kullanmak → Sistem bileşenlerinin birbirinden bağımsız çalışmasını destekler.
             */

            #region Loose Tightly Coupling

            var fileReader = new FileReader("C:\\Users\\irem.kars\\Desktop\\product.txt");
            fileReader.StartReading();
            fileReader.SaveData();
            #endregion
        }
    }
}
