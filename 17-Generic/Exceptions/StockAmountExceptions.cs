using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Generic.Exceptions
{
    public class StockAmountException : Exception
    {
        public StockAmountException()
        {
            Console.WriteLine($"Stok sıfırdan küçük olamaz. Tarih: {DateTime.Now}");
        }

        public StockAmountException(string message) : base(message)
        {
            Console.WriteLine($"Stok sıfırdan küçük olamaz. Tarih: {DateTime.Now}");
            Console.WriteLine($"Mesaj: {message}");
        }

        public StockAmountException(string message, Exception exception) : base(message, exception)
        {
            Console.WriteLine($"Stok sıfırdan küçük olamaz. Tarih: {DateTime.Now}");
            Console.WriteLine($"Mesaj: {message}");
            Console.WriteLine($"Trace: {exception.StackTrace}");
        }
    }
}
