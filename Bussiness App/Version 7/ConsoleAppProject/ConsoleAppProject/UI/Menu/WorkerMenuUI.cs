using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.UI.Menu
{
    internal class WorkerMenuUI
    {
        public static string WorkerMenu()
        {
            Console.Clear();
            string option;
            Console.WriteLine("                           ******************************************************** Worker Menu ********************************************************");
            Console.WriteLine();
            Console.WriteLine("1.Change Password");
            Console.WriteLine("2.Logout");
            Console.Write("Enter Your Option Here: ");

            option = Console.ReadLine();

            return option;
        }
    }
}
