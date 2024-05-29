using ConsoleApp1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("malik", "12345", 999, 980, 340, "uehfrieufb", true);
            double merit = s.CalculateMerit();
            bool scholarship = s.IsTakingScholarship(70);
            Console.WriteLine("Merit is : " + merit);
            Console.WriteLine("Schorlarship Available: " + scholarship);
            Console.ReadLine();
        }
    }
}
