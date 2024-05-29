using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    internal class GradedCourse
    {
        private string CourseName,Grade;
        
        public void SetCourseName(string courseName)
        {
            this.CourseName = courseName;
        }
        public string GetCourseName()
        {
            return this.CourseName;
        }
        public void SetGrade(string grade)
        {
            this.Grade = grade;
        }
        public string GetGrade()
        {
            return this.Grade;
        }

    }
}
