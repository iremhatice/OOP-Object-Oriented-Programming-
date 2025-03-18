using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_Interface.Example1
{
    public interface IMailService
    {
        string From { get; set; }
        List<string> To { get; set; }
        string Title { get; set; }
        string Body { get; set; }
        void Send();
    }
}
