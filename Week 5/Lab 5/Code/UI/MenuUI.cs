using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork.UI
{
    internal class MenuUI
    {
        public static int MainMenu()
        {
            Console.WriteLine("1 to Add Student");
            Console.WriteLine("2 to Add Degree Program");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
