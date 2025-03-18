using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StructYapilar
{
    public struct Color
    {
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public string GetColor()
        {
            return $"RGB({Red} {Green} {Blue})";
        }
    }
}
