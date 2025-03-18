using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_Interface.Example1
{
    public class MyMailService : IMailService
    {
        public string From { get; set; }
        public List<string> To { get; set; } = new List<string>();
        public string Title { get; set; }
        public string Body { get; set; }

        public void Send()
        {
            Console.WriteLine($"My Mail System ile mail gönderildi Kimden: {From} Başlık: {Title} \nKonu: {Body}");
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Kimlere");
            foreach (var item in To)
            {
                Console.WriteLine(item);
            }
        }
    }
}
