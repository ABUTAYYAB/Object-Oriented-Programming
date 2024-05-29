using System;

namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            while (true)
            {
                Console.Write("Enter Value 1: ");
                float var1 = float.Parse(Console.ReadLine());
                Console.Write("Enter Value 2: ");
                float var2 = float.Parse(Console.ReadLine());
                Console.Write("Enter\n 1 for Add \n 2 for Subtrract \n 3 for Multiply \n 4 for Divide :");
                float op = float.Parse(Console.ReadLine());
                float result;
                if (op == 1)
                {

                    c.var1 = var1;
                    c.var2 = var2;
                    result = c.Add();

                }
                else if (op == 2)
                {
                    c.var1 = var1;
                    c.var2 = var2;
                    result = c.Subtract();
                }
                else if (op == 3)
                {
                    c.var1 = var1;
                    c.var2 = var2;
                    result = c.Multiply();
                }
                else if (op == 4)
                {
                    c.var1 = var1;
                    c.var2 = var2;
                    result = c.Divide();
                }
                else
                {
                    Console.WriteLine("Wrong Input ");
                    Console.ReadKey();
                    continue;

                }

                Console.WriteLine("Result is :{0}", result);
                Console.WriteLine("See Previous result if Yes press Y");
                string previous = Console.ReadLine();
                if (previous == "y" || previous == "Y")
                {
                    string pre = c.Seeprevious();
                    Console.WriteLine("Previous Result is :");
                    Console.WriteLine(pre);
                }

                Console.WriteLine("Would You Try it again if Yes enter y ");
                string ans = Console.ReadLine();
                if (ans == "y" || ans == "Y")
                {
                    continue;

                }






            }


        }
    }
}
