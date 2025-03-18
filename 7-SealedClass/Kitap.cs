using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SealedClass
{
    //Sealed anahtar sözcüğü,kendisinden nesne türetebilir,fakat miras verilemez anlamına gelir.
    public /* sealed */ class Kitap : BaseKitap //Sealed,katılım almasını engeller.
    {
        public string KitapAdi { get; set; }
        public string KitapTuru { get; set; }
        public string ISBNNo { get; set; }
        public string YazarAdi { get; set; }

        public override void GetLog()
        {
            Console.WriteLine("Kitap Class'ından kayıt getiriliyor.");
        }

        //Sadece belirli bir metotuda mühürleyebiliriz.
        public sealed override void GetUser()
        {
            Console.WriteLine("Kitap Class'ından kullanıcı getiriliyor.");
        }
    }
}
