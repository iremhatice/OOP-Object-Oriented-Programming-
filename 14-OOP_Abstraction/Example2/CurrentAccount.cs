using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_Abstraction.Example2
{
    public class CurrentAccount : BankAccount
    {
        private double _overdraftlimit = 1000.0;
        public CurrentAccount(string accountNumber, string accountHolder) : base(accountNumber, accountHolder)
        {

        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount} into Current account");   
        }

        public override void Withdraw(double amount)
        {
            if ((Balance - amount) >= -_overdraftlimit)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw ${amount} from Current account");
            }
            else
            {
                Console.WriteLine("Withdraw exceeds overdraft limit.");
            }
        }
    }
}
