using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_task_2.BL
{
    internal class Data_Type
    {
        /*public Data_Type() 
        {
            name = "Jill";
        }*/
        /*public Data_Type() 
        {
            Conole.WriteLine("Default Constructor Called");
        }*/

        public string name;
        public float marks;
        public float ecatMarks;
        public int maticMarks;
        public double fscMarks;

       /* public Data_Type(string n) 
        {
                   /* name= "Ali";
                    marks = 10;
                    ecatMarks=102.3F;
                    maticMarks=1094;
                    fscMarks=1023.5F;*/
        /*    Console.WriteLine(name);
            Console.WriteLine(marks);
            Console.WriteLine(ecatMarks);
            Console.WriteLine(maticMarks);
            Console.WriteLine(fscMarks);
        name = n;

        } */
        public Data_Type(string Name,float Marks, float EcatMarks,int MatinMarks,double FscMarks) 
        {
            name = Name;
            marks = Marks;
            ecatMarks = EcatMarks;
            maticMarks = MatinMarks;
            fscMarks = FscMarks;
        }
    }
}
