using _9_Enum.Enums;
using _9_Enum.Models;

namespace _8_Enum
{
    internal class Program
    {
        //Enum: Numeratör ya da enum sabitleri olarak adlandırılır.
        static void Main(string[] args)
        {
            Console.WriteLine(Renkler.Sari); //Çıktı: Sari

            //inte cast etmek
            Console.WriteLine((int)Renkler.Sari); //Çıktı: 0

            Console.WriteLine("Renkler Enumundaki Değerleri okumak");
            foreach (int item in Enum.GetValues(typeof(Renkler))) //GetValues: enum degerlerini okur.
            {
                Console.WriteLine(item);  // 1 2 3 4 5
            }
            Console.WriteLine(new string('#', 50));

            //Enuma cast etmek
            Console.WriteLine((Renkler)5);

            Console.WriteLine("Renkler Enumundaki Adları okumak için"); //Enum adlarini okur.
            foreach (string item in Enum.GetNames(typeof(Renkler)))
            {
                Console.WriteLine(item);  // Sari Turuncu Kirmizi Mavi Siyah Beyaz
            }
            Console.WriteLine(new string('#', 50));

            foreach (string item in Enum.GetNames<Renkler>())
            {
                Console.WriteLine(item); // Sari Turuncu Kirmizi Mavi Siyah Beyaz
            }

            Renk renk = new Renk() { Id = 1, Renkler = Renkler.Sari };
            renk.Renkler = Renkler.Kirmizi;

            Personel personel = new Personel();
            personel.Id = 1;
            personel.Name = "Irem";
            personel.Department = PersonelTip.IT;

            Personel personel2 = new Personel();
            personel2.Id = 2;
            personel2.Name = "Mehmet";
            personel2.Department = PersonelTip.IT;

            Personel personel3 = new Personel();
            personel3.Id = 3;
            personel3.Name = "Tuğba";
            personel3.Department = PersonelTip.Yazilim;

            List<Personel> personels = new List<Personel>();
            personels.Add(personel);
            personels.Add(personel2);
            personels.Add(personel3);
            personels.Add(new Personel() { Id = 4, Name = "Hasan", Department = PersonelTip.IT });


            foreach (var item in personels)
            {
                if (item.Department is PersonelTip.IT)
                {
                    Console.WriteLine(item.Name);
                }
            }

        }
    }
}
