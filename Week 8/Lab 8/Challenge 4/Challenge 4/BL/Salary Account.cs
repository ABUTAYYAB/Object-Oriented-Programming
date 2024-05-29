using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4.BL
{
    internal class Salary_Account : Account
    {
        private double Tax;
        public Salary_Account(string accountTitle, string accountNumber, double balance, double tax) : base(accountTitle, accountNumber, balance)
        {
            Tax = tax;
        }
        public void SetTax(double amount)
        {
            this.Tax = amount*0.5;
        }
        public double GetTax()
        {
            return this.Tax;
        }
    }
}
