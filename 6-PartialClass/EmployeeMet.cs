using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _7_PartialClass
{
    public partial class Employee
    {
        public Employee(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Ekrana Yaz...");
        }

        public void ChangeName(string name)
        {
            Name = name;
            OnNameChanged(); //Eğer partial method implement edilmemişse derleme sırasında yok sayılır.
        }

        partial void OnNameChanged();
    }
}
