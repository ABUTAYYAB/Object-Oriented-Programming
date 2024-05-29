using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                string mainoption = print_Menu();
                if(mainoption == "1")
                {

                }
                else if (mainoption == "2")
                {

                }
                else if (mainoption == "3")
                {

                }
                else if (mainoption == "4")
                {

                }
                else if (mainoption == "5")
                {

                }
                else if (mainoption == "6")
                {
                    break;
                }
                else
                {
                    continue;
                }

            }
        }
        static string print_Menu()
        {
            string option = "5";
            Console.WriteLine("Welcome");
            Console.WriteLine("1. Add Ship");
            Console.WriteLine("2.Add Passenger");
            Console.WriteLine("3. Remove Ship");
            Console.WriteLine("4. View Ship");
            Console.WriteLine("5. Remove Passenger");
            Console.WriteLine("6. Exit");
            Console.Write("Enter Your Option : ");
            option = Console.ReadLine();

            return option;
        }
    }
}
