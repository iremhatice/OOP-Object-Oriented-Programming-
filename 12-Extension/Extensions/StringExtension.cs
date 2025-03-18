using _12_Extension.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Extension.Extensions
{
    //Extension sınıfları static olmak zorundadır. Haliyle metotlar da statik olmalı.
    public static class StringExtension
    {
        //Metni tersine çeviren bir extension metot
        public static string ReverseString(this string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        //Ilk harfi buyuk yapan metot
        public static string CapitaliceFirst(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return char.ToUpper(str[0]) + str.Substring(1);
        }

        public static string CapitaliceFirst(this string str, int index)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return str.Substring(0, index) + char.ToUpper(str[index]) + str.Substring(1);
        }

        public static bool IsSuccesful(this Student student)
        {
            return student.Scores.Average() >= 70;
        }
    }
}
