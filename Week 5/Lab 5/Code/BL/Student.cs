using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork.BL
{
    internal class Student
    {
        public string Name;
        public int Age;
        public float EcatMarks;
        public float FscMarks;
        public float Merit;

        public List<DegreeProgram> Prefrences = new List<DegreeProgram>();
        public DegreeProgram EnrolledProgram;
        public List<Subject> RegisterdSubject = new List<Subject>();


        public void AssignStudentSubject(Subject subject)
        {
            RegisterdSubject.Add(subject);
        }

      


    }
}
