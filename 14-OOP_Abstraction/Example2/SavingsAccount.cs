using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_Abstraction.Example2
{
    public class SavingsAccount : BankAccount
    {
        private double _interestRate = 0.03;
        public SavingsAccount(string accountNumber, string accountHolder) : base(accountNumber, accountHolder)
        {

        }

        public override void Deposit(double amount) //Yatırma
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount} into Savings Account");
            AddInterest();
        }

        public override void Withdraw(double amount) //Para Çekme
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawl ${amount} from Savings Account");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawl");
            }
        }

        private void AddInterest() //Faiz
        {
            Balance += Balance * _interestRate;
            Console.WriteLine($"Interest added. New Balance: ${Balance}");
        }
    }
}
