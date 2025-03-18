using _5_OOP_Encapsulation.Example1;
using _5_OOP_Encapsulation.Example2;

namespace _5_OOP_Encapsulation
{
    internal class Program
    {
        // Encapsulation: Dışarıdan aldığımız datayı fielda yüklemektir. Encapsulation, bir sınıfın verilerini (alanları) ve bu verilere erişim yöntemlerini (metotları) bir arada toplayarak, sınıfın iç durumunu gizlemesini ve dışarıdan sadece belirlenen arayüzlerle erişim sağlanmasını ifade eder.
        // Nesne içindeki verilerin gizlenmesi ve sadece dışarıya belirli metotlar aracılığıyla erişilmesini sağlar. Bu, verilerin dışarıdan yanlış bir şekilde değiştirilmesini engeller.
        // Diğer nesneler, nesnenin iç yapısına doğrudan erişemez, sadece tanımlanmış metotlar aracılığıyla erişebilir.
        static void Main(string[] args)
        {
            #region Example-1

            Musteri m = new Musteri();
            //m.id = 5; set metoduna private kullandıgımız için atama yapamayız.
            Console.WriteLine(m.Id);
            m.Ad = "irem";
            m.Soyad = "Kars";
            m.TCKimlik = "23324234332";
            Console.WriteLine(m.Soyad);
            Console.WriteLine(m.TCKimlik);
            Console.WriteLine(m.Email);
            #endregion

            #region Example-2

            Ogrenci ogrenci = new Ogrenci()
            {
                Ad = "ırem",
                Soyad = "Kars",
                Bolum = "web",
                Sinif = "19",

            };

            Console.WriteLine(ogrenci.Ad);
            Console.WriteLine(ogrenci.Soyad);
            Console.WriteLine(ogrenci.OgrenciNo);
            Ogrenci ogrenci2 = new Ogrenci()
            {
                Ad = "mert",
                Soyad = "Saltas",
                Bolum = "web",
                Sinif = "19",

            };

            Console.WriteLine(ogrenci2.Ad);
            Console.WriteLine(ogrenci2.Soyad);
            Console.WriteLine(ogrenci2.OgrenciNo);
            #endregion
        }
    }
}
