using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            double result;
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
                    if (c.num2 == 0)
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
                    NewInput(c);
                    result = c.Sqrt();
                }
                else if (opt == 7)
                {
                    Input(c);
                    result = c.Power();
                }
                else if (opt == 8)
                {
                    NewInput(c);
                    result = c.Log();
                }
                else if (opt == 9)
                {
                    NewInput(c);
                    result = c.Sin();
                }
                else if (opt == 10)
                {
                    NewInput(c);
                    result = c.Cos();
                }
                else if (opt == 11)
                {
                    NewInput(c);
                    result = c.Tan();
                }
                else if (opt == 12)
                {
                    break;
                }
                else
                {
                    continue;
                }

                Console.WriteLine("Result is : " + result);
                Console.ReadLine();
            }

        }
        static int Menu()
        {
            int opt;
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Modulo");
            Console.WriteLine("6. Sqrt");
            Console.WriteLine("7. Exponention");
            Console.WriteLine("8. Log");
            Console.WriteLine("9. Sin");
            Console.WriteLine("10. Cos");
            Console.WriteLine("11. Tan");
            Console.WriteLine("12. Exit");
            Console.WriteLine("Enter the Option: ");
            opt = int.Parse(Console.ReadLine());

            return opt;
        }
        static void Input(Calculator c)
        {
            Console.WriteLine("Enter First Number ");

            c.num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number ");
            c.num2 = double.Parse(Console.ReadLine());
        }
        static void NewInput(Calculator c)
        {
            Console.WriteLine("Enter Number ");
            c.num1 = double.Parse(Console.ReadLine());
        }
    }
}
