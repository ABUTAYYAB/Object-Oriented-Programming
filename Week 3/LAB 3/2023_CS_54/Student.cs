using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNo1.BL
{
    internal class Student
    {
        public Student() 
        {
        }
        public Student(Student s)
        {
            name = s.name;
            matric = s.matric;
            fsc = s.fsc;
            ecat = s.ecat;
            agg = s.agg;
        }
        public Student(string name,int matric,int fsc, int ecat,float agg) 
        {
            this.name = name;   
            this.matric = matric;
            this.fsc = fsc;
            this.ecat = ecat;
            this.agg = agg;
        }
        public string name;
        public int matric, fsc, ecat;
        public float agg;
    }
}
