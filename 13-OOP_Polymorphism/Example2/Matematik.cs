using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_Polymorphism.Example2
{
    //Matematik dersi için gecmenotu = gecmeNotu * 1.2
    public class Matematik : Ders
    {
        public override double GecmeHesapla()
        {
            return GecmeNotu * 1.2;
        }
    }
}
