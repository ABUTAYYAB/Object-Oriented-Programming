using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment3.BL
{
    internal class ATM
    {
        List <String> list = new List <String> ();
        public ATM()
        {

        }
        public float Balance = 10000;
        public void Deposit(int Amount)
        {
            this.Balance += Amount;
            list.Add("Deposit : "+ Amount);
        }
        public void Withdraw(int Amount)
        {
            if(this.Balance >= Amount)
            {
                this.Balance -= Amount;
                list.Add("Withdrawed : "+ Amount);

            }
        }
        public float CheckBalance()
        {
            return this.Balance;
        }

        public void SeeTransaction()
        {
            Console.WriteLine("\nHistory is Following:");
            for(int i = 0; i < list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
        }


    }
}
