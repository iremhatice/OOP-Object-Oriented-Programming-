using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_LooseCoupling.LooseCoupling
{
    public interface INewFileSaver
    {
        void SaveFile(string filename, string content);
    }
}
