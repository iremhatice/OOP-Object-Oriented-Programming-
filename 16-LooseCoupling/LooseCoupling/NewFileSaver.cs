using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_LooseCoupling.LooseCoupling
{
    public class NewFileSaver : INewFileSaver
    {
        public void SaveFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }
    }
}
