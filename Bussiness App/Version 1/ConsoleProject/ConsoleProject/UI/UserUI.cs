using DairydelightsDLL.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.UI
{
    internal class UserUI
    {
        public static User MakeUser()
        {
            User u = new User(EnterID(),EnterPassword(), EnterRole());
            return u;
        }

        public static string EnterID()
        {
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            return id;
        }
        public static string EnterPassword()
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
    }
}
