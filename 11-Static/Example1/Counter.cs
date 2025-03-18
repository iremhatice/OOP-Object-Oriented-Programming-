using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Static.Example1
{
    public class Counter
    {
        //Static Değişkenler (Fields): Bir sınıfın tüm örnekleri arasında paylaşılan bir değeri tutar. Tüm Counter örneklerinde ortak bir değişken
        public static int count = 0; 

        public void Artis()
        {
            count++;
        }
    }
}
