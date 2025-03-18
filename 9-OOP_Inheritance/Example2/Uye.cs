using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Inheritance.Example2
{
    public class Uye
    {
        private int uyeID;
        private string uyeAdi;
        private int uyelikTarihi;
        protected int aylikUcret;

        public Uye()
        {
            Console.WriteLine("Parametresiz Ana Yapıcı");
        }

        public Uye(int uyeID, string uyeAdi, int uyelikTarihi)
        {
            Console.WriteLine("3 Parametreli Ana Yapıcı");
            this.uyeID = uyeID;
            this.uyeAdi = uyeAdi;
            this.uyelikTarihi = uyelikTarihi;
        }

        public virtual int AidatHesapla()
        {
            return 1000;
        }

        public override string ToString()
        {
            return $"\nÜye Adı: {uyeAdi} \nUye Id: {uyeID} \nÜye Kayıt Tarihi: {uyelikTarihi} \nÜcret: {aylikUcret}";
        }
    }
}