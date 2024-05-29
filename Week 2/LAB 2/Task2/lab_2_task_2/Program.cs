using lab_2_task_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data_Type s1 = new Data_Type("John Wick",1100,400,1100,1100);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.maticMarks);
            Console.WriteLine(s1.marks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.ReadKey();

        }
    }
}
