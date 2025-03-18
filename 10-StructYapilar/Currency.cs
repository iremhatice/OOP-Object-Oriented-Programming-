using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StructYapilar
{
    public struct Currency
    {
        private bool isStarted;
        public Currency(decimal amount, string symbol, bool isStarted = true)
        {
            Amount = amount;
            Symbol = symbol;
            this.isStarted = isStarted;
        }

        public decimal Amount { get; set; }
        public string Symbol { get; set; }

        public string GetCurrency()
        {
            return isStarted ? $"{Symbol} {Amount}" : $"{Amount} {Symbol}";
        }
    }
}
