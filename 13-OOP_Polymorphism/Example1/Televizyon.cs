using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_Polymorphism.Example1
{
    public class Televizyon : Urun
    {
        public override void Ekranayaz(string data) //override anahtar kelimesiyle ezme işlemi yaptik.
        {
            Console.WriteLine($"Datamız {data}");
        }

    }
}
