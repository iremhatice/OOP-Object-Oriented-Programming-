using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SealedClass
{
    public class BaseKitap
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime DeletedDate { get; set; }

        public virtual void GetLog()
        {
            Console.WriteLine("Log Kayıt Başladı.");
        }
        public virtual void GetUser()
        {
            Console.WriteLine("Kullanıcı bilgileri getiriliyor.");
        }
    }
}
