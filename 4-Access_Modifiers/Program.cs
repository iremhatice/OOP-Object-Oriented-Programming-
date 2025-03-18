namespace _4_Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Access Modifiers (erişim belirleyiciler), bir sınıfın üyelerine (alanlar, özellikler, metotlar vb.) nasıl erişilebileceğini ve hangi kapsamda kullanılabileceğini belirten anahtar kelimelerdir.
                C# aşağıdaki erişim değiştiricilere sahiptir:
                • public: public erişim belirleyicisi, öğenin her yerden erişilebilir olduğunu belirtir. Hem aynı sınıf içinde hem de başka sınıflardan erişilebilir.
                • private: private erişim belirleyicisi, öğenin yalnızca bulunduğu sınıf içinde erişilebilir olduğunu belirtir. Dışarıdan erişilemez.
                • protected: Bir sınıf üyesinin aynı sınıf içinden veya bu sınıftan türetilmiş alt sınıflardan erişilebilir olduğunu belirtir.
                • internal: Bir sınıf üyesinin tanımlandığı derleme biriminden (assembly) erişilebilir olduğunu belirtir.
                • protected internal: Bir sınıf üyesinin hem aynı derleme biriminden hem de bu sınıftan türetilmiş diğer derleme birimlerinden erişilebilir olduğunu belirtir.


               Niçin Access Modifiers Kullanırız?
                Sınıf üyelerinin görünürlüğünü kontrol etmek için (her bir sınıfın ve sınıf üyesinin güvenlik düzeyi). "sensitive (Hassas)" verilerin kullanıcılardan gizlendiğinden emin olma süreci olan "Encapsulation (Kapsülleme)"ye ulaşmak için.

            Not: Bir erişim değiştiricisi belirtmezseniz, varsayılan olarak bir sınıfın tüm üyeleri private’dır
             */
        }
    }
}
