using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Validation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.UI.Menu
{
    internal class AdminMenuUI
    {
        public static string AdminMenu()
        {
            Console.Clear();
            string option;
            Console.WriteLine("                      ************************************************************ Admin Menu ************************************************************");
            Console.WriteLine();
            Console.WriteLine("1. Add New Employee");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. Change Others Password");
            Console.WriteLine("4. Update Password");
            Console.WriteLine("5. Logout");
            Console.Write("Enter Your Option Here: ");
            option = Console.ReadLine();

            return option;
        }
        public static User AddUser() 
        {
            Console.Clear();
            Console.Write("Enter UserName : ");
            string username = Console.ReadLine();
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();
            Console.Write("Enter Role (Worker or DeliveryBoy): ");
            string role = Console.ReadLine();

            if (username != "" && password != "" && role != "")
            {
                if (UserValidation.IsStringValid(username) && UserValidation.IsStringValid(password))
                {
                    if(role == "Worker" ||role == "DeliveryBoy")
                    {
                        User user = new User(username, password, role);
                        return user;
                    }
                }
            }
            return null;
        }
        public static void DisplayAllUsersOnScreen(List<User> users) 
        {
            foreach(User user in users) 
            {
                Console.WriteLine("UserName = " + user.GetUserName() + ", Password = " + user.GetPassword() + ", Role = " + user.GetRole());
            }
        }
    }
}
