using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_LooseCoupling.LooseTightlyCoupling
{
    public class FileReader
    {
        private const int deneme = 5;  //const, sadece oluştuğu anda atama yapılır.
        private readonly string _filename; //readonly ilk instance alındığında atama yapılmasına izin verilir. 
        private string _contents;

        public FileReader(string filename)
        {
            _filename = filename;
        }

        public void StartReading()
        {
            _contents = File.ReadAllText(_filename);
        }
        public void SaveData()
        {
            var saver = new FileSaver(_filename.Replace(".txt", ".doc"), _contents);
            saver.SaveData();
        }
    }
}
