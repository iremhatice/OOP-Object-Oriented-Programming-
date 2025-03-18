using _13_OOP_Polymorphism.Example1;
using _13_OOP_Polymorphism.Example2;

namespace _13_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Çok Biçimlilik
               Metotlar dönüş tipi, giriş parametresi ve tipleri bakımından aynı olsa da bazı durumlarda birbirinden farklı şekilde çalışmasını isteyebiliriz. Böyle durumlarda temel sınıfta bulunan bir metodun türetilen sınıf tarafından yeniden şekillendiirp çalıştırılmasına çok biçimlilik denir.

             * Nesnelerin aynı yöntemi veya özelliği farklı şekillerde uygulama yeteneğini ifade eder. Bu, bir üst sınıftan türetilen alt sınıfların aynı isimdeki yöntemleri veya özellikleri farklı şekillerde uygulayabilmesini sağlar.
             
             * Polymorphism, nesnelerin farklı alt sınıflarında aynı isimdeki yöntemleri veya özellikleri uygulayarak kodun daha esnek ve genişletilebilir olmasını sağlar.
             
             * Virtual, bir üst sınıftaki bir methodun alt sınıflar tarafından override edilerek değiştirilebileceğini belirtir. Bu anahtar kelime, bir methodun türetilmiş sınıflarca farklı bir şekilde uygulanabileceğini ifade eder.
             
             * Override, bir alt sınıfın bir üst sınıfın `virtual` olarak işaretlenmiş methodunu değiştirerek aynı isimde ve imzada bir method uygulamasını ifade eder.
             
             * Polymorphism (Çok Biçimlilik) Kullanımı:
             * Farklı Davranışlar İçin Kullanım: Polymorphism, aynı isimli methodların farklı alt sınıflar tarafından farklı şekillerde uygulanmasını sağlar. Bu sayede nesneler farklı durum ve gereksinimlere uygun davranışlar sergileyebilir.
             * Üst Sınıfı Alt Sınıflardan Bağımsız Tutma: Polymorphism, üst sınıfın alt sınıflardan bağımsız olarak kullanılmasını sağlar. Bu, kodun daha esnek ve genişletilebilir olmasını sağlar.
             * Daha Genel ve Soyut Kod Oluşturma: Üst sınıfın referansı kullanılarak daha genel ve soyut kod parçaları oluşturabilirsiniz. Bu, kodunuzun daha modüler hale gelmesine yardımcı olur.
             * Alternatif İmplementasyonlar İçin Kullanım: Farklı alt sınıfların aynı isimli methodları farklı şekillerde uygulayabilmesini sağlayarak, alternatif davranışlar sunabilirsiniz
      
             */

            #region Example-1

            Urun u = new Urun();
            u.Ekranayaz("Bilgisayar");
            Televizyon t = new Televizyon();
            t.Ekranayaz("samsung");

            #endregion

            #region Example-2

            Ders ders = new Ders();
            Fizik f = new Fizik();

            Kimya k = new Kimya();

            Matematik m = new Matematik();

            Console.WriteLine($"Ders: {ders.GecmeHesapla()} \nFizikten Geçme Notu= {f.GecmeHesapla()} \nKimyadan Geçme Notu= {k.GecmeHesapla()} \nMatematikten Geçme Notu={m.GecmeHesapla()}");
            #endregion

        }
    }
}
