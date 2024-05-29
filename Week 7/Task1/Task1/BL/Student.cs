using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DL;

namespace Task1.BL
{
    internal class Student
    {
        public string Name;
        public int Age;
        public float FscMarks;
        public float EcatMarks;
        public float Merit;

        public List<DegreeProgram> Prefrences = new List<DegreeProgram>();
        public DegreeProgram EnrolledProgram;
        public List<Subject> RegisterdSubject = new List<Subject>();

        public void AssignStudentSubject(Subject subject)
        {
            RegisterdSubject.Add(subject);
        }

        public float GetStudentMerit()
        {
            this.Merit = FscMarks * 0.6f + EcatMarks * 0.4f;
            return Merit;
        }

        public void AssignStudentDegreeProgram(DegreeProgram degreeProgram)
        {
            EnrolledProgram = degreeProgram;
        }
    }
}
