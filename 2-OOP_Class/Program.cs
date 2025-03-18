namespace _2_OOP_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance: Nesne Oluşturma
            Person yasar = new Person();
            yasar.Id = 1;
            yasar.Name = "Yasar";
            yasar.Surname = "Şimsek";
            yasar.Age = 28;

            //Salary yi person classında private tanımladığımız için buraya çağıramadık.
            //Nesnenin bilgilerini yazdır.
            Console.WriteLine("Kişi Adı: " + yasar.Name + " Code: " + yasar.GetHashCode());

            Person melih = new Person();
            melih.Id = 7;
            melih.Name = "Melih";
            melih.Surname = "Ar";
            melih.Age = 30;

            Console.WriteLine("Adı: " + yasar.Name);
            Console.WriteLine("Adı: " + melih.Name);

            Person fatih = new Person();
            fatih.Age = 36;

            int yas = fatih.Age;
            Console.WriteLine("Yaşı: ");

            Person deneme = new Person();
            deneme.Age = 120;

            #region Ornek2
            Person irem = new Person();
            irem.Name = "Irem";
            irem.Surname = "Kars";
            irem.Age = 25;

            Person elif = new Person() { Name = "Elif", Surname = "Yıldız", Age = 30 }; // İki türlüde yazılabilir.

            Person mert = new Person() { Name = "Mert", Surname = "Saltas", Age = 27 };
            Person ilknur = new Person() { Name = "Ilknur", Surname = "Karslı", Age = 24 };
            Person tugba = new Person() { Name = "Tugba", Surname = "Yıldız", Age = 31 };

            List<Person> list = new List<Person>();
            list.Add(yasar);
            list.Add(melih);
            list.Add(fatih);
            list.Add(ilknur);
            list.Add(irem);

            foreach (Person person2 in list)
            {
                if (person2.Age >= 30)
                {
                    Console.WriteLine(person2.Name);
                }
            }
            #endregion

            Person person;
            List<Person> list2 = new List<Person>();

            Console.WriteLine("Kaç Adet Personel Tanımlamak İstiyorsunuz? ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                person = new Person();
                Console.WriteLine("Adı: ");
                person.Name = Console.ReadLine();
                Console.WriteLine("Soyadı: ");
                person.Surname = Console.ReadLine();
                Console.WriteLine("Yaş: ");
                person.Age = Convert.ToInt32(Console.ReadLine());

                list2.Add(person);
            }

            foreach (var item in list2)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("*********************");
            person = list[0]; // ilk yazılanı alır.
            Console.WriteLine(person.Name);

            List<Person> list3 = new List<Person>()
            {
                new Person() { Name="Azra",Surname="Ak",Age=45},
                new Person() { Name="Buse",Surname="Çelik",Age=14},
                new Person() { Name="Büşra",Surname="Bilgücü",Age=25},
                new Person() { Name="Irem",Surname="KARS",Age=25},
            };

            foreach (var kisi in list3)
            {
                Console.WriteLine(kisi.Name + kisi.Surname);
            }


        }
    }
}
