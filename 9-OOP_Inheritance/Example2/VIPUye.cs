using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Inheritance.Example2
{
    internal class VIPUye : Uye
    {
        public VIPUye()
        {
            Console.WriteLine("Parametresiz VIP Uye Ana Yapıcı");
        }

        public VIPUye(int uyeID, string uyeadi, int uyeliktarihi, int aylik) : base(uyeID, uyeadi, uyeliktarihi)
        {
            aylikUcret = aylik;
            Console.WriteLine("4 Parametreli Normal Üye Ana Yapıcı ");
        }

        public override int AidatHesapla()
        {
            return base.AidatHesapla() + (aylikUcret * 12) + 500;
        }

    }
}
