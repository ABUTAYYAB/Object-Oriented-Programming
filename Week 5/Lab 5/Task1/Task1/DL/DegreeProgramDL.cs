using System.Collections.Generic;
using Task1.BL;

namespace Task1.DL
{
    internal class DegreeProgramDL
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
