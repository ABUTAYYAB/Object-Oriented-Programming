using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge;


namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            //s.name = "Test";
            //Console.WriteLine(s.name);

            string option;
            option = print_Menu();

            while (true)
            {
                if (option == "1")
                {

                }
                else if (option == "2")
                {

                }
                else if (option == "3")
                {

                }
                else if (option == "4")
                {

                }
                else
                {
                    break;
                }
            }
        }
        static string print_Menu()
        {
            string option = "5";
            Console.WriteLine("Welcome");
            Console.WriteLine("1.Add Students");
            Console.WriteLine("2.Show Students");
            Console.WriteLine("3.Calculate Aggerate");
            Console.WriteLine("4.Top Students");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Your Option : ");
            option = Console.ReadLine();

            return option;
        }
        static void add_Student()
        {
            string name;
            float metric, fsc,ecat,agg;


        }
    }

}
