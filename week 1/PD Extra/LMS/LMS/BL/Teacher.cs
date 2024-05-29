using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class Teacher
    {
        public Teacher(string name_, string id_, string password_)
        {
            name = name_;
            id = id_;
            password = password_;

        }
        public string name;
        public string id;
        public string password;
    }
}
