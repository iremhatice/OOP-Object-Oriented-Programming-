using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_Polymorphism.Example2
{
    // Fizik dersi için gecmenotu= gecmeNotu*1.1

    public class Fizik : Ders
    {  
        public override double GecmeHesapla()
        {
            return GecmeNotu * 1.1;
        }
    }
}
