using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Subject
    {
        public Subject() { }
        public Subject(string Code, string Subjecttype, int creditHours, int SubjectFee)
        {
            this.Code = Code;
            this.SubjectType = Subjecttype;
            this.CreditHours = creditHours;
            this.SubjectFee = SubjectFee;

        }

        public string Code, SubjectType;
        public int CreditHours,SubjectFee;


    }
}
