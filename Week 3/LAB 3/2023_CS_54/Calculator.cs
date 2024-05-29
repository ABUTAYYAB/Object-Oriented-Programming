using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment2.BL
{
    internal class Calculator
    {
        public Calculator()
        {
        }
        public float var1, var2, result, value;

        public float Add()
        {
            value = this.var1 + this.var2;
            return value;
        }
        public float Multiply()
        {
            value = this.var1 * this.var2;
            return value;
        }
        public float Divide()
        {
            value = this.var1 / this.var2;
            return value;
        }
        public float Subtract()
        {
            value = this.var1 - this.var2;
            return value;
        }
    }
}
