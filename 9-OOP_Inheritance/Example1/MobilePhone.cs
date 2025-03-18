using _6_OOP_Inheritance.Example1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Inheritance
{
    //Base Classdan aldığımız bir metodun özelliğini değiştirmeye polymorphism denir.
    public class MobilePhone : Phone
    {
        public MobilePhone(bool HasCamera, string brand, string connectionType, bool hasCamera) : base(brand, connectionType)
        {
            HasCamera = hasCamera;
            this.Brand = brand;
        }

        public bool HasCamera { get; set; }

        public bool IsTouched { get; set; }

        public MobilePhone()
        {
            _phoneType = "Mobile Phone";
        }

        public string TakePhoto()
        {
            if (HasCamera)
                return "You can take a photo";
            else
                return "There is no cam";
        }

        public override string Call() //override metodu değiştirir.
        {
            return "Polifonik Müzik Cendere...";
        }

        public override string ConnectionStatus() //eskisi gibi çalışır.
        {
            return base.ConnectionStatus();
        }
    }
}
