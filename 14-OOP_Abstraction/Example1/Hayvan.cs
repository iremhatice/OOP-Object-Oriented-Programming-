using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_Abstraction.Example1
{
    public class Hayvan : Tur
    {
        public override void FamilyaGoster()
        {
            Console.WriteLine($"Hayvan sınıfının familyası {Familya}");
        }
        public override void TurGoster()
        {
            Console.WriteLine("base halini ezdim.");
        }
    }
}
