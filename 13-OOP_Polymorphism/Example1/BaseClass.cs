using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_Polymorphism.Example1
{
    public class BaseClass
    {
        public virtual void Ekranayaz(string data) //virtual anahtar kelimesiyle bu metodu ezilebilir hale getirdik.
        {
            Console.WriteLine(data);
        }
    }
}
