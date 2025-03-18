using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_LooseCoupling.LooseTightlyCoupling
{
    public class FileSaver
    {
        private readonly string _filename;
        private string _content;

        public FileSaver(string filename, string content)
        {
            _filename = filename;
            _content = content;
        }
        public void SaveData()
        {
            File.WriteAllText(_filename, _content);
        }
    }
}
