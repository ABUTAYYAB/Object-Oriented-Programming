using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Calculator
    {
        public Calculator()
        {
            this.num1 = 10;
            this.num2 = 10;
        }
        public Calculator (float num1,float num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public float num1, num2,result;
        public float Add()
        {
            result = num1 + num2;
            return result;
        }
        public float Subtract()
        {
            result = num1 - num2;
            return result;
        }
        public float Multiply()
        {
            result = num1 * num2;
            return result;
        }
        public float Divide()
        {
            result = num1 / num2;
            return result;
        }
        public float Mod()
        {
            result = num1 % num2;
            return result;
        }

    }
}
