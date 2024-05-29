using SelfAssesment3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            atm.Deposit(1000);
            atm.Withdraw(1000);
            Console.Write(atm.CheckBalance());
            atm.SeeTransaction();
            Console.ReadLine();


        }
    }
}
