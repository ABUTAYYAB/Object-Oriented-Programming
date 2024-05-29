using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4.BL
{
    internal class Saving_Account : Account
    {
        private double Profit,Zakat;

        public Saving_Account(string accountTitle, string accountNumber, double balance,double profit, double zakat) :base(accountTitle, accountNumber, balance)
        {
            Profit = profit;
            Zakat = zakat;
        }
        public void SetProfit(double profit) 
        {
            this.Profit = profit;
        }
        public double GetProfit()
        {
            return this.Profit;
        }

        public void SetZakat(double zakat)
        {
            this.Zakat = zakat;
        }
        public double GetZakat()
        {
            return this.Zakat;
        }
    }
}
