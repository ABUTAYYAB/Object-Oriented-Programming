using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.DL
{
    internal class DegreeProgramCRUD
    {
        public static List<DegreeProgram> degreePrograms = new List<DegreeProgram>();

        public static void AddDegree(DegreeProgram degreeProgram)
        {
            degreePrograms.Add(degreeProgram);
        }

        public static DegreeProgram IsDegreeExist(string title)
        {
            foreach (DegreeProgram degreeProgram in degreePrograms)
            {
                if (degreeProgram.Title == title) return degreeProgram;
            }
            return null;
        }
    }
}
