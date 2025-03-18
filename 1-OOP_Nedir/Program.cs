namespace _1_OOP_Nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Nesne Yönelimli Programlama (OOP - Object-Oriented Programming), yazılım geliştirme sürecinde kodun daha modüler, esnek ve yeniden kullanılabilir olmasını sağlamak için kullanılan bir programlama paradigmasıdır. OOP, programları nesneler (objects) ve sınıflar (classes) etrafında organize eder.
             * Programlama dünyasını iki ana başlık altında gruplayabiliriz: Procedural programming (Prosedürel programlama) ve Object-Oriented Programming (Nesne Tabanlı Programlama).
             * Prosedürel programlama, veriler üzerinde işlemler gerçekleştiren prosedürler veya metotlar yazmakla ilgiliyken, nesne tabanlı programlama hem verileri hem de metotları içeren nesneler oluşturmakla ilgilidir.
             * Nesne tabanlı programlamanın prosedürel programlamaya göre birçok avantajı vardır:
                • OOP daha hızlı ve yürütmesi daha kolaydır.
                • OOP, programlar için net bir yapı sağlar.
                • OOP, C# kodunu DRY "Kendinizi Tekrarlamayın" ilkesine yardımcı olur ve kodun bakımını, değiştirilmesini ve hata ayıklamasını kolaylaştırır.
                • OOP, daha az kod ve daha kısa geliştirme süresi ile tamamen yeniden kullanılabilir uygulamalar oluşturmayı mümkün kılar.
            * Her nesne, veri (alanlar) ve bu veri üzerinde işlem yapabilen metotları içerir. OOP’nin temel prensipleri arasında miras (inheritance), çok biçimlilik (polymorphism), kapsülleme (encapsulation) ve soyutlama (abstraction) bulunmaktadır.
            * Mirasa izin veren OOP, bir sınıfın başka bir sınıftan özellik ve davranışları miras almasını sağlar, bu da kodun tekrar kullanılabilirliğini artırır. Çok biçimlilik, aynı adı taşıyan ancak farklı işlevlere sahip metotları ifade eder, bu da programın esnekliğini artırır.
            * Kapsülleme, bir nesnenin iç detaylarını gizleyerek sadece gerekli olanları kullanıcıya sunar ve böylece güvenliği artırır. Soyutlama, karmaşık sistemleri basitleştirir ve sadece önemli özelliklere odaklanarak programın anlaşılabilirliğini artırır. Nesne Yönelimli Programlama, büyük ölçekli yazılım projelerinde tasarım, geliştirme ve bakım süreçlerini optimize ederek kaliteli ve sürdürülebilir kod yazma konusunda önemli bir rol oynar.

            Nesne Yönelimli Programlamanın Özellikleri Nelerdir?
             * Nesne Yönelimli Programlama (OOP), yazılım geliştirmenin temel bir paradigması olarak öne çıkar. Bu programlama yaklaşımı, kodun modüler ve anlaşılır olmasını sağlamak adına belirli özelliklere dayanır. OOP’nin özellikleri, yazılım projelerini daha organize ve yönetilebilir kılar. Böylece geliştiricilere daha etkili bir çalışma ortamı sunar.
             * 
               • Mirasa İzin Verme (Inheritance): Bir sınıfın diğerinden özellikleri ve davranışları miras almasını sağlar.  Sınıflar arasında özellikleri ve davranışları paylaşma yeteneği, kodun tekrar kullanılabilirliğini artırır ve aynı zamanda kodun genişletilebilir olmasını sağlar.
               • Çok Biçimlilik (Polymorphism): Aynı isimde farklı işlevlere sahip metotların kullanılmasına olanak tanır.
               • Kapsülleme (Encapsulation): Nesnelerin iç detaylarını gizleyerek sadece gerekli olanlara erişim sağlar. Bu, kodun daha güvenli ve değişime daha dirençli olması anlamını taşır.
               • Soyutlama (Abstraction): OOP, karmaşık sistemleri basitleştirerek sadece önemli detaylara odaklanmayı sağlar. Bu da kodun kısa sürede anlaşılabilirliğini artırır ve geliştiricilere yüksek seviyeli bir bakış açısı sunarak işlerin çok daha rahat ilerlemesi anlamına gelir.
               • Sınıflar ve Nesneler (Classes and Objects): Kodu modülerleştirmek için nesneleri temsil eden sınıflar kullanır.
               • Mesajlaşma (Messaging): Nesneler arasındaki etkileşimi sağlamak için mesajlaşma konseptini kullanır.

            * Nesne Yönelimli Programlama, bu özellikleriyle yazılım geliştirme süreçlerini düzenler, kodun bakımını kolaylaştırır ve daha sürdürülebilir projeler oluşturmayı mümkün kılar. Bu sayede, geliştiriciler karmaşık sistemleri daha etkili bir şekilde yönetebilir, kodun anlaşılırlığı artar ve uzun vadeli projelerde başarı sağlanabilir.
               
            OOP'nin avantajları şunlardır:
               1. Modülerlik ve Kapsülleme: Nesnelerin verileri ve davranışları bir arada tutulduğundan, kod modüler hale gelir. Her nesne kendi içindeki detayları gizleyerek diğer nesnelerle daha düşük bağımlılık içinde çalışabilir. Bu, kodun daha düzenli ve anlaşılır olmasını sağlar.
               2. Kodun Yeniden Kullanılabilirliği: Sınıflar ve miras alma sayesinde, mevcut kodu yeniden kullanarak yeni sınıflar ve nesneler oluşturabilirsiniz. Bu, kod tekrarını azaltır, geliştirme süreçlerini hızlandırır ve bakımı kolaylaştırır.
               3. Sürdürülebilirlik: Kodun daha modüler olması, değişikliklerin yapılmasını ve hataların düzeltilmesini daha kolay hale getirir. Değişiklikler bir sınıfın içinde yapılırsa, bu sadece ilgili sınıfı etkiler ve diğer kodlara minimum müdahale gerektirir.
               4. Esneklik ve Genişletilebilirlik: Yeni özellikler veya davranışlar eklemek için sınıfları ve nesneleri genişletebilirsiniz. Bu sayede mevcut kodunuzu bozmadan yeni özellikler eklemek daha kolay olur.
               5. Ekipler Arası İşbirliği: OOP'nin standartlaşmış yapıları, farklı programcıların aynı projede çalışmasını kolaylaştırır. Sınıflar, metotlar ve arayüzler sayesinde herkesin birbirinin kodunu anlaması ve kullanması daha kolaydır.
               6. Kodun Anlaşılabilirliği: Nesnelerin gerçek dünya nesnelerine benzetilmesi, kodun daha anlaşılır olmasını sağlar. Bir nesnenin ismi ve metodları, o nesnenin ne iş yaptığını daha hızlı anlamanıza yardımcı olur.
               7. Veri ve Davranışların Birleşimi: Nesneler, verileri ve bu verileri işleyen metodları bir araya getirir. Bu, veri manipülasyonunun ve işlemlerinin daha organize ve tutarlı olmasını sağlar.
               8. Çok Biçimlilik (Polymorphism): Farklı nesnelerin aynı arayüzü kullanarak farklı davranışlar sergileyebilmesi, kodun daha esnek ve özelleştirilebilir olmasını sağlar.
               9. Hataların Yönetimi: Hataların kaynağını belirlemek ve sınırlamak daha kolaydır. Bir nesnenin içeriğine sınırlı bir erişim olduğundan, hataların etki alanı daha dar olabilir.

            Temel olarak OOP, gerçek dünyadaki nesneleri (objects) ve onların arasındaki ilişkileri modellemeye dayanır. Bu yaklaşım, programları daha düzenli, anlaşılır ve yönetilebilir hale getirmeyi amaçlar.

              OOP'nin temel kavramları şunlardır:
               1. Nesne (Object): Gerçek dünyadaki varlıkların temsilidir. Her nesne, veri ve bu verileri işleyen metotlar içerir.
               2. Sınıf (Class): Nesnelerin temel taslağını oluşturan bir yapıdır. Sınıflar, nesneleri oluşturmak  için kullanılan bir kalıptır. Bir sınıf, nesnelerin özelliklerini ve davranışlarını tanımlayan veri ve metodları içerir.
               3. Encapsulation (Kapsülleme): Nesnelerin verilerinin ve metodlarının bir araya getirilerek sınırlı bir erişimle bütünleştirilmesidir. Bu, verilerin yanlışlıkla değiştirilmesini veya yetkisiz erişimi engeller.
               4. Inheritance (Miras Alma): Bir sınıfın, başka bir sınıfın özelliklerini ve metodlarını miras alarak genişletilmesidir. Bu, kod tekrarını azaltır ve mevcut kodun daha fazla kullanılabilirliğini sağlar.
               5. Polymorphism (Çok Biçimlilik): Aynı arayüzü paylaşan farklı sınıfların farklı şekillerde davranabilmesidir. Bu, farklı nesnelerin aynı metod adını kullanarak farklı işlevleri gerçekleştirmesini sağlar.
             */

        }
    }
}
