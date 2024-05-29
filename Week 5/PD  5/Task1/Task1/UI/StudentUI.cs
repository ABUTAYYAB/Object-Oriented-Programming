using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    internal class StudentUI
    {
        public static Student GetStudent()
        {
            Console.Write("Enter The Name of Student: ");
            string name = Console.ReadLine();
            Console.Write("Enter The Age of Student: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter FSC Marks: ");
            int fsc = int.Parse(Console.ReadLine());
            Console.Write("Enter Ecat Marks: ");
            int ecat = int.Parse(Console.ReadLine());
            Student student = new Student(name,age,fsc,ecat);
            return student;

        }
        public static DegreeProgram GetPreference() 
        {
            List<DegreeProgram> list = new List<DegreeProgram>();
            int loop;
            Console.Write("Enter How much You Want to Add Prefrence: ");
            loop = int.Parse(Console.ReadLine());
            for(int i = 0;i < loop; i++)
            {
                Console.Write("Enter The Title of the Degree: ");
                string title = Console.ReadLine();
                list[i].Title = title;


            }
            return list;
        }
        
    }
}
