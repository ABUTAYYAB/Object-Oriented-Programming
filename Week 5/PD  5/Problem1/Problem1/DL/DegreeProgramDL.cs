using Problem1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.DL
{
    internal class DegreeProgramDL
    {
        public static List<DegreeProgram> DegreeProgramList = new List<DegreeProgram>();

        public static DegreeProgram IsDegreeExist(string title)
        {
            foreach (DegreeProgram degreeProgram in DegreeProgramList)
            {
                if (degreeProgram.Title == title)
                { return degreeProgram; }
            }
            return null;
        }
        public static int CalculateCH(List<Subject> Subjects)
        {
            int CH = 0;
            foreach (Subject sub in Subjects)
            {
                CH += sub.CreditHours;

            }
            return CH;
        }

        public static void showdegreeprograms()
        {
            Console.WriteLine("Available Degree Programs");
            foreach (DegreeProgram degreeProgram in DegreeProgramList)
            {
                Console.Write($"{degreeProgram.Title},");
            }
        }
    }
}
