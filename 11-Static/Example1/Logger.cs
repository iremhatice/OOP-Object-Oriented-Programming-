using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Static.Example1
{
    // Static Sınıflar: Tüm üyeleri static olan sınıflardır. Static sınıflar, nesne örneği oluşturulamayacak şekilde tasarlanır ve yalnızca static üyeler içerir.
    public static class Logger
    {
        //Static Metotlar(Methods): Nesne oluşturulmadan doğrudan sınıf adı ile çağrılabilen metotlardır.Static metotlar sadece static üyelerle çalışabilir.
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
