using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_Interface.Example3
{
    public class Bicim : IBicim
    {
        private int numaram;
        public int Numaram
        {
            get { return numaram; }
            set { numaram = value; }
        }

        public void InterfaceMetot()
        {
            Console.WriteLine("Numara: {0}", numaram);
        }
    }
}
