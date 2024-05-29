using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class SubjectDL
    {
        static public List<Subject> subjects = new List<Subject>(){};

        static public void AddSubject(Subject s)
        {
            subjects.Add(s);
        }
        static public void RemoveSubject(Subject s)
        {
            subjects.Remove(s);
        }
    }
}
