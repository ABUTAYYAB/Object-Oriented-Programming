using Labwork.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork.DL
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
            foreach(DegreeProgram degreeProgram in degreePrograms)
            {
                if(degreeProgram.Title == title) return degreeProgram;
            }
           return null;
        }

        //add, remove, find by title, find by duration (list return)
    }
}
