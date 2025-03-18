namespace _8_SealedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            
             *  "sealed" anahtar kelimesi, bir sınıfın başka sınıflar tarafından miras alınmasını engellemek için kullanılır. Bir sınıf "sealed" olarak işaretlendiğinde, bu sınıfın başka bir sınıf tarafından miras alınması engellenir ve alt sınıf olarak kullanılamaz.
             *  "sealed" anahtar kelimesi genellikle belli bir noktada sınıfların daha fazla türetilmesini engellemek veya belirli bir tasarımın sabit kalmasını sağlamak amacıyla kullanılır. Örneğin, C# içerisinde .NET Framework'de bazı temel sınıflar "sealed" olarak tanımlanmıştır. Bu sayede bu sınıfların doğrudan türetilmesi engellenir ve bu sınıfların tasarımının değiştirilmesinin önüne geçilir.
             *  Sealed anahtar sözcüğü,kendisinden nesne türetebilir,fakat miras verilemez anlamına gelir.
           
             */

            YeniKitap yeniKitap = new YeniKitap();

        }
    }
}
