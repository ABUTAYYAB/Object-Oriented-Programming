using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
    internal class Student
    {
        public Student( string name,string rollno, double matric,double fsc,double ecat,string hometown,bool ishostelite) 
        {
            this.name = name;
            this.RollNO = rollno;
            this.matric = matric;
            this.ecat = ecat;
            this.hometown = hometown;
            this.ishostelite = ishostelite;
        }

        private string name;
        private string RollNO;
        private double cgpa;
        private double matric;
        private double fsc;
        private double ecat;
        private string hometown;
        private bool ishostelite;
        private bool isTakingScholarship;


        public double CalculateMerit()
        {
            double result;
            result = (ecat*0.6)+(fsc*0.4)/100;
            cgpa = result;
            return result;
        }
        public bool IsTakingScholarship(double Merit) 
        {
            bool result = false;
            if(ishostelite && Merit > 80)
            {
                isTakingScholarship = true;
                result = true;
            }
            isTakingScholarship = false;
            return result;
        }

    }
}
