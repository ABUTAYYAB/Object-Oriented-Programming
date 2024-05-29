using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Angle
    {

        public Angle() 
        {

        }
        public int degrees;
        public float minutes;
        public char direction;
        public string location;



        public void Changeangle()
        {
            Console.Write("Enter degrees:");
            degrees = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes:");
            minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter direction:");
            direction = char.Parse(Console.ReadLine());

        }

        public string viewangle()
        {
            location = $"{degrees}\u00b0{minutes}'{direction}";
            return location;
        }
    }
}
