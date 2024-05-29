using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeNo2.BL;

namespace ChallengeNo2
{
    internal class Program
    {
        static List <Product> products = new List<Product>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string option = Mainmenu();
                if (option == "1")
                {
                    addstudent();
                }
                else if (option == "2")
                {
                    showProducts();
                    Console.ReadLine();
                }
                else if (option == "3")
                {
                    ShowWorth();
                    Console.ReadLine();
                }
                else
                {
                    continue;
                }


            }
        }
        static String Mainmenu()
        {
            string option;
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Product");
            Console.WriteLine("3. Total Store worth");
            option = Console.ReadLine();
            return option;
        }
        static void addstudent()
        {
            string id,name,category,brand,country;
            float price;
            Console.Write("Enter The ID: ");
            id = Console.ReadLine();
            Console.Write("Enter The name of the product: ");
            name = Console.ReadLine();
            Console.Write("Enter Price of the product: ");
            price = float.Parse(Console.ReadLine());
            Console.Write("Enter The Category of the product: ");
            category = Console.ReadLine();
            Console.Write("Enter The Brand of the product: ");
            brand = Console.ReadLine();
            Console.Write("Enter The country of the product: ");
            country  = Console.ReadLine();



            
            Product s = new Product(id,name,price,category,brand,country);
            products.Add(s);
        }
        static void showProducts()
        {
            for(int i = 0; i < products.Count; i++) 
            {
                Console.WriteLine("\n{0}",products[i].show());
            }
        }
        static void ShowWorth()
        {
            double Sum = totalWorth();
            Console.WriteLine("Total Worth of the Store is :{0}",Sum);
        }
        static double totalWorth()
        {
            double sum = 0;
            for (int i = 0; i < products.Count; i++) 
            {
                sum = sum + products[i].price;
            }
            return sum;
        }

    }
}
