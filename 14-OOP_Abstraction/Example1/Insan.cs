using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_Abstraction.Example1
{
    public class Insan : Tur
    {
        public override void FamilyaGoster()
        {
            Console.WriteLine($"İnsan sınıfının familyası {Familya}");
        }
    }
}
