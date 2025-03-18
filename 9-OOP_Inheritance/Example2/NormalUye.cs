using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Inheritance.Example2
{
    public class NormalUye : Uye
    {
        public NormalUye()
        {
            Console.WriteLine("Parametresiz Ana Yapıcı");
        }

        public NormalUye(int ID, string adi, int tarihi, int aylik) : base(ID, adi, tarihi)
        {
            Console.WriteLine("4 Parametreli Normal Üye Ana Yapıcı ");
            aylikUcret = aylik;
        }

        public override int AidatHesapla()
        {
            return base.AidatHesapla() + aylikUcret * 12;
        }
    }
}
