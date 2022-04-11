using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    class Account : CreditAccount
    {
        private double _balance;
        public override void getFullInfo()
        {
            Console.WriteLine($"Баланс {_balance}"); 
        }
        public void getBalance()
        {
            Console.WriteLine(@"Баланс: " + _balance + ".");
        }
        public void deposit(double sum)
        {
            _balance += sum;
        }
        public void withdraw(double sum)
        {
            _balance -= sum;
        }
    }
}
