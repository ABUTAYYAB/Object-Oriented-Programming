using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Student
    {
        public Student() { }    
        public Student(string Name,int Age,float FSCMarks,float MetricMarks)
        {
            this.Name = Name;
            this.Age = Age;
            this.MetricMarks = MetricMarks;
            this.FSCMarks = FSCMarks;
        }
        public string Name;
        public int Age;
        public float FSCMarks,MetricMarks,Ecat;

        public List<DegreeProgram> Prefrences = new List<DegreeProgram>();
        public DegreeProgram EnrolledProgram;
        public List<Subject> RegisterdSubject = new List<Subject>();


        public void AssignStudentSubject(Subject subject)
        {
            RegisterdSubject.Add(subject);
        }

    }
}
