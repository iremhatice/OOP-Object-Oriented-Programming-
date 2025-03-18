using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Extension.Extensions
{
    public static class ExceptionExtensions
    {
        public static string GetFriendlyMessage(this Exception exception)
        {
            return $"Error: {exception.Message}\n Occured at: {exception.StackTrace?.Split('\n')[0]}\n Date Time: {DateTime.UtcNow}";
        }
    }
}
