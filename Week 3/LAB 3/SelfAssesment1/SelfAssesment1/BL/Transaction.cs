using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment1.BL
{
    internal class Transaction
    {
        public Transaction(string TransactionId, string ProductName, string Amount, string Date, string Time)
        {
            this.TransactionId = TransactionId;
            this.ProductName = ProductName;
            this.Amount = Amount;
            this.Date = Date;
            this.Time = Time;
        }
        public Transaction(Transaction t)
        {
            this.TransactionId = t.TransactionId;
            this.ProductName = t.ProductName;
            this.Amount = t.Amount;
            this.Date = t.Date;
            this.Time = t.Time;
        }
        public string TransactionId, ProductName, Amount, Date, Time;
    }
}
