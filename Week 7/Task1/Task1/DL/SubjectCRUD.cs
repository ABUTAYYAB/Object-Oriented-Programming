using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.DL
{
    internal class SubjectCRUD
    {
        public static List<Subject> subjects = new List<Subject>();

        public static void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public static Subject IsSubjectExist(string code)
        {
            foreach (Subject subject in subjects)
            {
                if (subject.Code == code) return subject;
            }
            return null;
        }
    }
}
