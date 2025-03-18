using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SealedClass
{
    public class YeniKitap : Kitap
    {
        //override dediğimizde sadece Getlog() metodunu override edebiliriz. GetUser metodu sealed olduğundan override edilemez.
        public override void GetLog()
        {
            base.GetLog();  
        }
    }
}
