using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_Abstraction.Example2
{
    public abstract class BankAccount
    {
        protected BankAccount(string accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
        }

        public string AccountNumber { get; private set; } //ctorda isteyeceğim için bir daha propertyde istenmesin. Hesap numarası verilmeden oluşturulmasın diye tekrardan değiştirilemesin nesne oluşturulma anında hesap numarası istensin.
        public string AccountHolder { get; private set; } //Hesap sahibi okunabilir olmalı ama değiştirilememeli.
        protected double Balance { get; set; } //Alt sınıflar değiştirebilmeli, ama dışarıdan erişim kısıtlanmalı.

        //Abstract Method
        public abstract void Deposit(double amount); //Tum hesaplarda para yatirma ve cekme olucak fakat hepsinde farklı parametrelerle calisacak.
        public abstract void Withdraw(double amount);
        public virtual string DisplayBalance() //Alt sinifın isine yaradigi taktirde override edip kullanabilsin.
        {
            return $"Account Number: {AccountNumber}, Account Holder: {AccountHolder},Balance: {Balance}";
        }
    }
}
