using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    internal class Subject
    {
        public Subject() { }

        public Subject(string code, int credithours, string type, int subjectfee)
        {
            SubjectCode = code;
            CreditHours = credithours;
            SubjectType = type;
            SubjectFee = subjectfee;
        }

        public string SubjectCode;
        public int CreditHours;
        public string SubjectType;
        public int SubjectFee;

    }
}
