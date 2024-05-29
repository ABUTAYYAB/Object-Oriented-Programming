using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Utility
    {
        public static int MainMenu()
        {
            int opt;
            Console.WriteLine("1. Add Student ");
            Console.WriteLine("2. Add Degree Program ");
            opt =  int.Parse(Console.ReadLine());

            return opt;
        }
    }
}
