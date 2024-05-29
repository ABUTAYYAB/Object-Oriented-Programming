using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class DegreeProgram
    {
        static List<Subject> subjects = new List<Subject>();

        public string Title;
        public double Duration;

        public DegreeProgram() { }

        public DegreeProgram(DegreeProgram d) 
        {
            this.Title = d.Title;
            this.Duration = d.Duration;
        }



        public DegreeProgram(string Title, double Duration)
        {
            this.Title = Title;
            this.Duration = Duration;
        }

        public static bool IsSubjectExist(string subjectCode)
        {
            bool result = false;
            for (int i = 0; i < subjects.Count; i++)
            {
                if (subjectCode == subjects[i].Code)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        public static void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }
        public static int CalculateCreditHour()
        {
            int hour = 0;
            for (int i = 0; i < subjects.Count; i++)
            {
                hour += subjects[i].CreditHours;
            }
            return hour;
        }
    }
}
