using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4.BL
{
    internal class Account
    {
        public string AccountTitle, AccountNumber;
        public double Balance;
        public Account() { }    

        public Account(string accountTitle, string accountNumber, double balance) 
        {
            AccountTitle = accountTitle;
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public void Depit(double amount)
        {
                Balance -= amount;
        }
        public void Credit(double amount)
        {
            Balance += amount;
        }
    }
}
