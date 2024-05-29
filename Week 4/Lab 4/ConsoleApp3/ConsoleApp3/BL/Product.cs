using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.BL
{
    internal class Product
    {
        public Product (string name,string category,double price)
        {
            this.Name = name;
            this.category = category;
            this.Price = price;
        }
        private string Name,category;
        private double Price,tax;


        public double CalculateTax()
        {
            double result;
            result = Price - Price * 0.1;
            tax = result;
            return tax;
        }
        public string AllData()
        {
            String Line = "Name is {0} Category is {1} Price is {2} Tax is {3}:" ;
            string result = string.Format(Line, Name, category, Price, tax);
            return result;

        }


    }
}
