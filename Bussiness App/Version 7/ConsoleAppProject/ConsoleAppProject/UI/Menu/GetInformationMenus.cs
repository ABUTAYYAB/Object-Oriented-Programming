using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Validation;
using System;
using System.Data;
using System.Security.Cryptography;

namespace ConsoleAppProject.UI.Menu
{
    internal class GetInformationMenus
    {
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
        public static User SignIN() 
        {
            Console.Clear();
            Console.Write("Enter UserName : ");
            string username = Console.ReadLine();
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();

            User user = new User(username, password);
            return user;
        }
        public static User SignUp()
        {

            Console.Clear();
            Console.Write("Enter UserName : ");
            string username = Console.ReadLine();
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();
            string role = "Customer";
            if (username != "" && password != "")
            {
                if (UserValidation.IsStringValid(username) && UserValidation.IsStringValid(password))
                {
                    User user = new User(username, password, role);
                    return user;
                }
            }
            return null;
        }
        public static string EnterUserName()
        {
            Console.Write("Enter UserName: ");
            string id = Console.ReadLine();
            return id;
        }
        public static string EnterPassword()
        {
            Console.Write("Enter Password: ");
            string Password = Console.ReadLine();
            return Password;
        }
        public static string EnterNewPassword()
        {
            Console.Write("Enter New Password: ");
            string Password = Console.ReadLine();
            return Password;
        }
        public static string EnterRole()
        {
            Console.Write("Enter Role (Worker or DeliveryBoy): ");
            string Role = Console.ReadLine();
            return Role;
        }
        public static void ClearScreen()
        {
            Console.Clear();
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
    }
}
