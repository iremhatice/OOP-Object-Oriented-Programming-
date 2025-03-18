using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_Polymorphism.Example2
{
     /*
        Ders adındaki temel sınfıta öğrenci, dersAdi, Double geçmenotu prop. ve GecmeHesapla adında geriye double sonuc döndüren metot olucak. 

        Fizik dersi için gecmenotu= gecmeNotu*1.1
        Kimya dersi için gecmenotu= gecmeNotu*0.8
        Matematik dersi için gecmenotu= gecmeNotu*1.2
     */
    public class Ders
    {
        public string Ogrenci { get; set; }
        public string DersAdi { get; set; }

        private double _gecmeNotu = 50;
        public double GecmeNotu
        {
            get { return _gecmeNotu; }
            private set {; }
        }

        public virtual double GecmeHesapla()
        {
            return _gecmeNotu;
        }
    }
}
