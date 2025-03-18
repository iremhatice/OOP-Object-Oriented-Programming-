using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_Abstraction.Example1
{
    // Alt sınıfların ortak özelliklerini tasir. Nesne uretmek mantıksızdir.
    public abstract class Tur
    {
        public Tur()
        {
            Console.WriteLine("Class Ctor");
        }

        public string CanliTuru { get; set; }
        public string Aile { get; set; }
        public string Familya { get; set; }
        public virtual void TurGoster()
        {
            Console.WriteLine($"Tanımlanan canlı türü: {CanliTuru}");
        }

        public void AileGoster()
        {
            Console.WriteLine($"Tanımlanan Canlının Ailesi: {Aile}");
        }

        //Abstract Metotlar, kalıtım aldığı class'da implement edilerek uygulanması zorunludur.
        public abstract void FamilyaGoster();

    }
}
