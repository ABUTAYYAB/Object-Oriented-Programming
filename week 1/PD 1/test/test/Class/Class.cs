using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Class
{
    internal class Putabaz
    {
        public Putabaz(string name_,int age_,string gender_,int id_)
        {
            name = name_;
            age = age_;
            gender = gender_;
            id = id_;
        }
        public Putabaz(int id_)
        {
            id = id_;
        }
        public Putabaz() 
        {
        }

        public string name;
        public int age;
        public string gender;
        public int id;
    }
}
