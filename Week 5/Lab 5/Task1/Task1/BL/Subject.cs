using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Subject
    {
        public Subject() { }

        public Subject(string Code,string Subjecttype,int creditHour,int SubjectFee)
        {
            this.Code = Code;
            this.SubjectType = Subjecttype;
            this.CreditHour = creditHour;
            this.SubjectFee = SubjectFee;

        }
        public string Code,SubjectType;
        public int CreditHour, SubjectFee;

    }
}
