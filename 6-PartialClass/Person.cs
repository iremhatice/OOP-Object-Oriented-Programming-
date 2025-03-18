using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_PartialClass
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Ekrana Yaz...");
        }
    }
}