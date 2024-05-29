using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class DegreeProgram
    {
        public DegreeProgram() { }

        public DegreeProgram(string Title,string Duration) 
        {
            this.Title = Title;
            this.Duration = Duration;
        }
        public string Title, Duration;
        static List<Subject> subjects = new List<Subject>();

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
                    hour += subjects[i].CreditHour;
            }
            return hour;
        }
    }
}
