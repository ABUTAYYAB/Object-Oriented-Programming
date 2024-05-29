using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    internal class AbsoluteGradedCourse
    {
        private string CourseName, Grade;
        private Double Marks;

        public AbsoluteGradedCourse(string courseName, string grade, double marks)
        {
            this.CourseName = courseName;
            this.Grade = grade;
            this.Marks = marks;
        }
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
        public void SetMarks(double marks)
        {
            this.Marks = marks;
        }
        public double GetMarks()
        {
            return this.Marks;
        }
        public bool IsPassed()
        {
            bool result = true;
            if(this.Grade == "f" || this.Grade == "F")
            {
                result = false;
            }
            return result;
        }
    }
}
