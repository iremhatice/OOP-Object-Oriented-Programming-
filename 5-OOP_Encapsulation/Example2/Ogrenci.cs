using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP_Encapsulation.Example2
{
    //Öğrenci nesnesi oluşacak.İçerisinde Ad,Soyad,Bolum,Sınıf,OgrenciNo propertyleri olucak.
    //Girilen ad değeri set edilirken ilk harfi büyük olacak şekilde değişsin.
    //Girilen soyad okunurken tüm harfleri büyük olarak ayarlansın.
    //Öğrenci no ya değer ataması yapılmasın.Oğrenci numarasına değer olarak bölümün ilk harfinin büyük hali+sınıf+rastgele oluşan bir sayı atansın.

    public class Ogrenci
    {
        private string _ad;
        private string _soyad;
        int sayi;
        Random rnd = new Random();

        public Ogrenci()
        {
            sayi = rnd.Next(1000, 9000);
        }

        public string Ad
        {
            get { return _ad; }
            set { _ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); }

        }

        public string Soyad
        {
            get { return _soyad.ToUpper(); }
            set { _soyad = value; }
        }

        public string Bolum { get; set; }
        public string Sinif { get; set; }

        private string _ogrenciNo;

        public string OgrenciNo
        {
            get
            {
                return _ogrenciNo = Bolum.Substring(0, 1).ToUpper() + Sinif + sayi;
            }
            private set { _ogrenciNo = value; }

        }
    }
}
