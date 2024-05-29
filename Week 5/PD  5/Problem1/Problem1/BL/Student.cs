using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    internal class Student
    {

        public List<DegreeProgram> Prefrences = new List<DegreeProgram>();
        public DegreeProgram EnrolledProgram;
        public List<Subject> RegisterdSubject = new List<Subject>();


        public string Name;
        public int Age;
        public float FscMarks;
        public float EcatMarks;
        public float Merit;
        public int fee;


        public void AssignStudentSubject(Subject subject)
        {
            RegisterdSubject.Add(subject);
        }
        public void calculatemerit()
        {
            Merit = ((FscMarks / 1100) * 50) + ((EcatMarks / 400) * 50);
        }

        public int Credithrs()
        {
            int hour = 0;
            for (int i = 0; i < EnrolledProgram.Subjects.Count; i++)
            {
                hour += EnrolledProgram.Subjects[i].CreditHours;
            }
            return hour;
        }
        public int calculatefee()
        {
            int fee = 0;
            for (int i = 0; i < EnrolledProgram.Subjects.Count; i++)
            {
                fee += EnrolledProgram.Subjects[i].SubjectFee;
            }
            return fee;
        }
    }
}
