using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace week_2_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student_Data student_data = new Student_Data();
            /*Student_Data[] Students_data= new Student_Data[5];
            for (int i=0; i<5; i++) 
            {
                Students_data[i] = TakeInput();
            }*/
            /*Display_data(Students_data);*/
            Console.WriteLine(student_data.name);
            Console.WriteLine(student_data.fscMarks);
            Console.WriteLine(student_data.matricMarks);
            Console.WriteLine(student_data.ecatMarks);
            Console.ReadKey();

        }
        static Student_Data TakeInput()
        {
            Student_Data s = new Student_Data();
            Console.Write("Enter Student name: ");
            s.name =Console.ReadLine();
            Console.Write("Enter matric Marks: ");
            s.matricMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter fsc marks: ");
            s.fscMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter ecat marks: ");
            s.ecatMarks = float.Parse(Console.ReadLine());
            return s;
        }
        static void Display_data(Student_Data[] data)
        {
            Console.WriteLine("Name\tMatricMarks\t FscMarks\t ecatMarks");
            for(int i=0; i<5;i++)
            {
                Console.WriteLine(data[i].name + "\t" + data[i].matricMarks + "\t\t "+ data[i].fscMarks + "\t\t "+data[i].ecatMarks);
            }
        }
    }
}
