using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Calculator
    {
        public Calculator()
        {
            this.num1 = 10;
            this.num2 = 10;
        }
        public Calculator(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public double num1, num2, result;
        public double Add()
        {
            result = num1 + num2;
            return result;
        }
        public double Subtract()
        {
            result = num1 - num2;
            return result;
        }
        public double Multiply()
        {
            result = num1 * num2;
            return result;
        }
        public double Divide()
        {
            result = num1 / num2;
            return result;
        }
        public double Mod()
        {
            result = num1 % num2;
            return result;
        }
        public double Sqrt()
        {
            result = Math.Sqrt(num1);
            return result;
        }
        public double Power()
        {
            result = Math.Pow(num1, num2);
            return result;
        }
        public double Log()
        {
            result = Math.Log(num1);
            return result;
        }
        public double Sin()
        {
            result = Math.Sin(num1);
            return result;
        }
        public double Cos()
        {
            result = Math.Cos(num1);
            return result;
        }
        public double Tan()
        {
            result = Math.Tan(num1);
            return result; ;
        }
    }
}
