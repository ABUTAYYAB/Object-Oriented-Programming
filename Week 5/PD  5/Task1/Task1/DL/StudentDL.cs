using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class StudentDL
    {
        static public List<Student> students = new List<Student>();

        static public void AddStudent(Student s) 
        {
            students.Add(s);
        }
        static public void RemoveStudent(Student s)
        {
            students.Remove(s);
        }

    }
}
