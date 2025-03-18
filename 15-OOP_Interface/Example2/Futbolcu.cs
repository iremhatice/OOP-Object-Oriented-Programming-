using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_Interface.Example2
{
    public class Futbolcu : IFutbolcu
    {
        public string AdiSoyadi { get; set; }
        public string FormaNumarasi { get; set; }
        public int SutGucu { get; set; }
        public int PasGucu { get; set; }
        public int KosmaHizi { get; set; }
        public bool Sakatmi { get; set; }

        public void Kos()
        {

        }

        public void PasVer()
        {

        }

        public void SutCek()
        {
            if (SutGucu > 70)
            {
                Console.WriteLine("Gol olur.");
            }
            else
            {
                Console.WriteLine("Taç attı.");
            }
        }

        public void TopKurtar()
        {

        }
    }
}
