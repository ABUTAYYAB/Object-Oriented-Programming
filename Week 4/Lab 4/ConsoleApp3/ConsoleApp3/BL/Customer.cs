using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.BL
{
    internal class Customer
    {
        public Customer (string name,string Address,string Contact)
        {
            this.Name = name;
            this.Address = Address;
            this.Contact = Contact;
        }
        private string Name;
        private string Address;
        private string Contact;
        public List<Product> products = new List<Product>();

        public List<Product> getAllProducts()
        {
            return products;
        }

        public void addProduct()
        {
            string nam, cat;
            double price;
            Console.Write("\nEnter Product Name: ");
            nam = Console.ReadLine();
            Console.Write("Enter Category: ");
            cat = Console.ReadLine();
            Console.Write("Enter Price: ");
            price = double.Parse(Console.ReadLine());
            Product p = new Product(nam,cat,price);
            //Console.Write("Product Tax: "+ p.CalculateTax());
        }

    }
}
