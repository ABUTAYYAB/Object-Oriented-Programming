using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    internal class Student
    { 
        public Student() 
        {
            //Console.WriteLine("Default Constructor Called");
            sname = "Tayyab";
            matric = 123;
            fsc = 123;
            ecat = 400;
            aggregate = 100;

        }
        public Student(string name, float matricm, float fscm, float ecatm,float agg)
        {
            sname = name;
            matric = matricm;
            fsc = fscm;
            ecat = ecatm;
            aggregate = agg;

        }
        public string sname;
        public float matric;
        public float fsc;
        public float ecat;
        public float aggregate;

    }
}
