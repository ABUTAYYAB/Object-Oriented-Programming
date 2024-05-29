using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class Calculator
    {
        List<float> Result = new List <float> ();
        public Calculator() 
        {
        }
        public float var1, var2, result, value;

        public float Add()
        {
            value = this.var1 + this.var2;
            Result.Add (value);
            return value;
        }
        public float Multiply()
        {
            value = this.var1 * this.var2;
            Result.Add(value);
            return value;
        }
        public float Divide()
        {
            value = this.var1 / this.var2;
            Result.Add(value);
            return value;
        }
        public float Subtract()
        {
            value = this.var1 - this.var2;
            Result.Add(value);
            return value;
        }
        public string Seeprevious()
        {
            string result = "";
            for(int i = 0; i <  Result.Count; i++) 
            {
                result += Result[i].ToString();
                result += "\n";

            }
            return result;
        }


    }
}
