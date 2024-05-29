using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BL;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>();
            while (true) 
            {
                int option = Menu();
                if(option == 1)
                {
                    Book b = new Book();
                    b.GetTitle();
                    b.GetAuthor();
                    b.GetPublictionYear();
                    b.Price();
                    b.Quantity();
                    list.Add(b);
                }
                else if(option == 2) 
                {
                    displayStock(list);
                }
                else if (option == 3)
                {
                    Console.Write("Enter The Title of the Book: ");
                    string title = Console.ReadLine();
                    string author = getAuthor(title, list);
                    Console.Write("Author is  {0}: ",author);
                    Console.ReadLine();
                }
                else if (option == 4)
                {
                    Console.Write("Enter The Title of the Book: ");
                    string title = Console.ReadLine();
                    string result = AddStock(title, list);
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
                else if (option == 5)
                {
                    Console.Write("Enter The Title of the Book: ");
                    string title = Console.ReadLine();
                    string result = Sell(title, list);
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
                else if (option == 6)
                {
                    Console.WriteLine("Total No of Books Avialable is : {0}",list.Count);
                    Console.ReadLine();
                }
                else if (option == 7)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Author Details");
            Console.WriteLine("4. Sold Copies");
            Console.WriteLine("5. Restock");
            Console.WriteLine("6. See the count of books");
            Console.WriteLine("7. Exit");
            option = int.Parse(Console.ReadLine());

            return option;
        }
        static void displayStock( List <Book> list)
        {
            for(int i = 0;i < list.Count; i++)
            {
                Console.WriteLine("\nBook Title is: {0}", list[i].title);
                Console.WriteLine("Book Author is: {0}", list[i].author);
                Console.WriteLine("Book PublictionYear is: {0}", list[i].publictionYear);
                Console.WriteLine("Book price is: {0}", list[i].price);
            }

            Console.WriteLine("Press Enter To Continue:");
            Console.ReadLine();
        }
        static string getAuthor(string title, List<Book> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if(title == list[i].title)
                {
                    return list[i].author;
                }
            }
            return "notfound";
        }
        static string Sell(string title, List<Book> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (title == list[i].title)
                {
                    list[i].SoldStock();
                    return "Task Done";
                }
            }
            return "notfound";
        }

        static string AddStock(string title, List<Book> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (title == list[i].title)
                {
                    list[i].AddStock();
                    return "Task Done";
                }
            }
            return "notfound";
        }

    }
}
