using Labwork.BL;
using Labwork.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Labwork.UI
{
    internal class StudentUI
    {
        public static Student GetStudentFromUser()
        {
            Student student = new Student();
            Console.WriteLine("Enter student name ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter ECAT Marks");
            student.EcatMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter FSC MArks ");
            student.FscMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Age  (In case of women you can enter less then 20)");
            student.Age = int.Parse(Console.ReadLine());

            int count = 0;
            Console.WriteLine("Enter number of pref");
            count  = int.Parse((Console.ReadLine()));
            for (int i = 0; i < count;)
            {
                if(GetUserPref()!= null)
                {
                    student.Prefrences.Add(GetUserPref());
                    i++;
                }
            }

            return student;
        }


        public static DegreeProgram GetUserPref()
        {
            Console.WriteLine("Enter your pref");
            string preff = Console.ReadLine();
            DegreeProgram program = DegreeProgramDL.IsDegreeExist(preff);
            if (program != null)
            {
                return program;
            }else
            {
                return null;
            }
        }


        public static void DisplayStudent(Student student)
        {
            Console.WriteLine(student.Name+" "+student.EcatMarks+" "+student.FscMarks+"  "+student.Age);
        }

        public static void DisplayAllStudents(List<Student> students)
        {
            foreach(Student student in students)
            {
                DisplayStudent(student);
            }
        }

    }
}
