using System;
using Task1.BL;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            float result;
            while (true)
            {
                Console.Clear();
                int opt = Menu();
                if (opt == 1)
                {
                    Input(c);
                    result = c.Add();
                }
                else if (opt == 2)
                {
                    Input(c);
                    result = c.Subtract();
                }
                else if (opt == 3)
                {
                    Input(c);
                    result = c.Multiply();
                }
                else if (opt == 4)
                {
                    Input(c);
                    if(c.num2 == 0)
                    {
                        Console.WriteLine("Cannot Divide by Zero:");
                        Console.ReadLine();
                        continue;
                    }
                    result = c.Divide();
                }
                else if (opt == 5)
                {
                    Input(c);
                    result = c.Mod();
                }
                else if (opt == 6)
                {
                    break;
                }
                else
                {
                    continue;
                }

                Console.WriteLine("Result is : "+ result);
                Console.ReadLine();
            }
        }
        static int Menu()
        {
            int opt = 0;

            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Modulo");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter the Option: ");
            opt = int.Parse(Console.ReadLine());

            return opt;
        }
        static void Input(Calculator c)
        {
            Console.WriteLine("Enter First Number ");
            c.num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number ");
            c.num2 = float.Parse(Console.ReadLine());
        }
    }
}
