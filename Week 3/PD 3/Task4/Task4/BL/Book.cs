using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BL
{
    internal class Book
    {
        public Book()
        {


        }


        public int quantityInStock, stock, sell;
        public string title, author, publictionYear;
        public float price;
        public void GetTitle()
        {
            Console.WriteLine("Enter the title of this book: ");
            title = Console.ReadLine();

        }
        public void Price()
        {

            Console.WriteLine("Enter the price of the book: ");
            price = float.Parse(Console.ReadLine());
        }
        public void GetAuthor()
        {
            Console.WriteLine("Enter the author of this book: ");
            author = Console.ReadLine();
        }
        public void GetPublictionYear()
        {
            Console.WriteLine("Enter the Publication year of this book: ");
            publictionYear = Console.ReadLine();
        }
        public void Quantity()
        {

            Console.WriteLine("Enter the Stock: ");
            quantityInStock = int.Parse(Console.ReadLine());
        }
        public void AddStock()
        {
            Console.WriteLine("Enter the quantity you want to add: ");
            stock = int.Parse(Console.ReadLine());
            quantityInStock += stock;
        }
        public void SoldStock()
        {

            Console.WriteLine("Enter the quantity you want to Sell: ");
            sell = int.Parse(Console.ReadLine());
            quantityInStock -= sell;
        }

    }
}
