using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.UI
{
    internal class MenuUI
    {
        public static int MainMenu()
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of specific Program");
            Console.WriteLine("6. Register Subject for specific Student");
            Console.WriteLine("7. Calculate fees for all register students");
            Console.WriteLine("8. Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
