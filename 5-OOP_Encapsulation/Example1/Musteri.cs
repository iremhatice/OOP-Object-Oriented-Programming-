using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP_Encapsulation.Example1
{
    // this : Ilgili sinifi temsil eder.  
    public class Musteri
    {
        public Musteri()
        {
            this.Id=IdAtama();
        }

        private int IdAtama()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 9000);
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            private set { _id = value; }   //değer ataması yapacağımız zaman bu alan çalışır.
        }

        public string Ad { get; set; }
        public string _soyad;

        //Encapsulation
        public string Soyad
        {
            get { return _soyad.ToUpper(); }
            set
            {
                _soyad = value;
                _email = string.Format("{0}.{1}@gmail.com", Ad, Soyad);
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            private set { }
        }

        private string _tc;
        public string TCKimlik
        {
            get
            {
                return _tc.Substring(0, 3).PadRight(11, '*');
            }
            set
            {
                if (value.Length == 11)
                {
                    bool kontrol = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (!karakterKontrol)
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("Tc sayılardan oluşmalı.");
                    }
                    else
                    {
                        _tc = value;
                    }
                }
                else
                {
                    _tc = "";
                }
            }

        }


    }
}
