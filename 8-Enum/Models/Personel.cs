using _9_Enum.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Enum.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PersonelTip Department { get; set; }

    }
}
