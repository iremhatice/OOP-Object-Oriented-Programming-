using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_Polymorphism.Example2
{
    //Kimya dersi için gecmenotu = gecmeNotu * 0.8
    public class Kimya : Ders
    {    
        public override double GecmeHesapla()
        {
            return GecmeNotu * 0.8;
        }
    }
}
