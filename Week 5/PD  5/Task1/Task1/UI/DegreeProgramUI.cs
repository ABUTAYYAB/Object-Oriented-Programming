using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    internal class DegreeProgramUI
    {
        public static DegreeProgramUI AddDegree()
        {
            Console.Write("Enter The Title of Degree: ");
            string title = Console.ReadLine();
            Console.Write("Enter The Duration of Degree: ");
            double duration = double.Parse(Console.ReadLine());
            DegreeProgram degreeProgram = new DegreeProgram(title,duration);

            return degreeProgram;
        }
    }
}
