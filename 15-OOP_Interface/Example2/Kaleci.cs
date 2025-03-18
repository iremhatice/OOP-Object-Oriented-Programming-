using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_Interface.Example2
{
    public class Kaleci : IFutbolcu, IKaleci
    {
        public string AdiSoyadi { get; set; }
        public string FormaNumarasi { get; set; }
        public int SutGucu { get; set; }
        public int PasGucu { get; set; }
        public int KosmaHizi { get; set; }
        public bool Sakatmi { get; set; }
        public int Degaj { get; set; }

        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void PasVer()
        {
            throw new NotImplementedException();
        }

        public void SutCek()
        {
            throw new NotImplementedException();
        }

        public void TopKurtar()
        {
            throw new NotImplementedException();
        }
    }
}
