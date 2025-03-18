using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Inheritance.Example1
{
    public class Phone
    {
        //protected: kalıtım aldığın yerde kullanılır.
        private string _brand;
        protected string _phoneType;
        protected string _connectionType;

        public Phone()
        {
            _phoneType = "Ahizeli Telefon";
        }
        public Phone(string brand, string connectionType)
        {
            _brand = brand;
            _connectionType = connectionType;
        }

        protected string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        protected string PhoneType
        {
            get { return _phoneType; }
        }

        protected string ConnectionType
        {
            get { return _connectionType; }
            set { _connectionType = value; }
        }

        public virtual string Call()
        {
            return "Ahizeli Telefon Çalıyor...";
        }

        public virtual string ConnectionStatus() //virtual sanallaştırır.
        {
            return "Kablolu bağlantısı mevcut";
        }
    }
}
