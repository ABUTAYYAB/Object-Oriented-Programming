using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfAssesment1.BL;

namespace SelfAssesment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction t = new Transaction("1234", "apple", "120", "12Sep", "10Am");
            Transaction t1 = new Transaction(t);
            Console.WriteLine("Transaction ID: {0}", t.TransactionId);
            Console.WriteLine("Product Name: {0}", t.ProductName);
            Console.WriteLine("Product Amount: {0}", t.Amount);
            Console.WriteLine("Date : {0}", t.Date);
            Console.WriteLine("Time : {0}", t.Time);


            Console.WriteLine("Copy Constructor: ");
            Console.WriteLine("Transaction ID: {0}", t1.TransactionId);
            Console.WriteLine("Product Name: {0}", t1.ProductName);
            Console.WriteLine("Product Amount: {0}", t1.Amount);
            Console.WriteLine("Date : {0}", t1.Date);
            Console.WriteLine("Time : {0}", t1.Time);
            Console.ReadLine();
        }
    }
}
