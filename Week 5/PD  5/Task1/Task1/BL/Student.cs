using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Student
    {
        public Student() { }
        public Student(string Name,int Age,int FSCMarks,int EcatMarks) 
        {
            this.Name = Name;
            this.Age = Age;
            this.FSCMarks = FSCMarks;
            this.EcatMarks = EcatMarks;
        }

        public List<DegreeProgram> Prefrences = new List<DegreeProgram>();
        public DegreeProgram EnrolledProgram;
        public List<Subject> RegisterdSubject = new List<Subject>();

        public string Name;
        public int Age;
        public int FSCMarks,EcatMarks;
        public float Merit;


        public void AddPreference(DegreeProgram d)
        {
            Prefrences.Add(d);
        }

        public void AddSubject(Subject s)
        {
            RegisterdSubject.Add(s);
        }

        public void Enroll(DegreeProgram d)
        {
            this.EnrolledProgram = new DegreeProgram(d);
        }


    }
}
