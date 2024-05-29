using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3tiermodel.UI
{
    internal class MenuUI
    {
        public static string EnterID()
        {
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            return id;
        }
        public  static string EnterPassword()
        {
            Console.Write("Enter Password: ");
            string Password = Console.ReadLine();
            return Password;
        }
        public static string EnterRole()
        {
            Console.Write("Enter Role (Admin , Employee or Customer ): ");
            string Role = Console.ReadLine();
            return Role;
        }
        public static string EnterName()
        {
            Console.Write("Enter the Name of the product: ");
            string name = Console.ReadLine();
            return name;
        }
        public static double EnterPrice()
        {
            Console.Write("Enter the Price of the product: ");
            double price = double.Parse(Console.ReadLine());
            return price;
        }
        public static double EnterQuantity()
        {
            Console.Write("Enter the Quantity of the product: ");
            double quantity = double.Parse(Console.ReadLine());
            return quantity;
        }
        public static void Successfull()
        {
            Console.WriteLine("Operation Successfull :)");
            Console.ReadKey();
        }
        public static void Unsuccessfull()
        {
            Console.WriteLine("Operation Unsuccessfull :)");
            Console.ReadKey();
        }
        public static void ClearScreen()
        {
            Console.Clear();
        }
        public static string MainMenu()
        {
            Console.Clear();
            string option = "5";
            Console.WriteLine("Welcome");
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2.sign Up");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Your Option : ");
            option = Console.ReadLine();

            return option;
        }
        public static string AdminMenu()
        {
            Console.Clear();
            string option;
            Console.WriteLine("                      ************************************************************ Admin Menu ************************************************************");
            Console.WriteLine();
            Console.WriteLine("1. Add New Employee");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. Update Password");
            Console.WriteLine("4. Logout");
            Console.Write("Enter Your Option Here: ");
            option = Console.ReadLine();


            return option;
        }
        public static string EmployeeMenu()
        {
            Console.Clear();
            string option;
            Console.WriteLine("                           ******************************************************** Employee Menu ********************************************************");
            Console.WriteLine();
            Console.WriteLine("1.View products");
            Console.WriteLine("2.Add products");
            Console.WriteLine("3.Remove products");
            Console.WriteLine("4.Update Price");
            Console.WriteLine("5.Update Quantity");
            Console.WriteLine("6.Logout");
            Console.Write("Enter Your Option Here: ");

            option = Console.ReadLine();

            return option;
        }
        public static string CustomerMenu()
        {
            Console.Clear();
            string option;
            Console.WriteLine("                     ************************************************************** Customer Menu **************************************************************");
            Console.WriteLine();
            Console.WriteLine("1.View products");
            Console.WriteLine("2.Buy Product");
            Console.WriteLine("3. Logout");
            Console.Write("Enter Your Option Here:");
            option = Console.ReadLine();
            return option;
        }

    }
}
