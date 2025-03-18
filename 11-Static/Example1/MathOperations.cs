using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Static.Example1
{
    public class MathOperations
    {
        public double Area(int r)
        {
            return Pi * r * r;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        //Static Metotlar (Methods): Nesne oluşturulmadan doğrudan sınıf adı ile çağrılabilen metotlardır. Static metotlar sadece static üyelerle çalışabilir.
        public static double CalculateCircleArea(double radios)
        {
            return Math.PI * radios * radios;
        }

        public static double Pi;

        public static double PI => Math.PI;
    }
}
