using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_Interface.Example2
{
    public interface IFutbolcu
    {
        string AdiSoyadi { get; set; }
        string FormaNumarasi { get; set; }
        int SutGucu { get; set; }
        int PasGucu { get; set; }
        int KosmaHizi { get; set; }
        bool Sakatmi { get; set; }
        void Kos();
        void SutCek();
        void PasVer();
    }
}
