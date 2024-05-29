using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;
using Task1.UI;

namespace Task1.UI
{
    internal static class StudentUI
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
            Console.WriteLine("Enter Age");
            student.Age = int.Parse(Console.ReadLine());

            int count = 0;
            Console.WriteLine("Enter number of pref");
            count = int.Parse((Console.ReadLine()));
            for (int i = 0; i < count;)
            {
                if (GetUserPref() != null)
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
            DegreeProgram program = DegreeProgramCRUD.IsDegreeExist(preff);
            if (program != null)
            {
                return program;
            }
            else
            {
                return null;
            }
        }


        public static void DisplayStudent(Student student)
        {
            Console.WriteLine(student.Name + " " + student.EcatMarks + " " + student.FscMarks + "  " + student.Age);
        }

        public static void DisplayAllStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                DisplayStudent(student);
            }
        }

        public static void DisplayAllStudentsMerit(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name + " " + student.GetStudentMerit());
            }
        }

        public static void GetStudentOfSpecificProgram(List<Student> students)
        {
            Console.WriteLine("Enter the Degree Name Whose Students you want to see:");
            string degree = Console.ReadLine();

            foreach (var student in students)
            {
                if (student.EnrolledProgram.Title == degree)
                {
                    DisplayStudent(student);
                }
            }
        }

        public static void RegisterSubjectToStudent()
        {
            Console.WriteLine("Enter the Student Name");
            string name = Console.ReadLine();
            Student student = StudentCRUD.FindStudentByName(name);
            if (student != null)
            {
                Console.WriteLine("Enter the Subject Name");
                string subject = Console.ReadLine();
                Subject sub = SubjectCRUD.IsSubjectExist(subject);
                if (sub != null)
                {
                    student.AssignStudentSubject(sub);
                }
                else
                {
                    Console.WriteLine("Subject Not Found");
                }
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }

        public static void CalculateFeesForAllStudents()
        {
            foreach (var student in StudentCRUD.students)
            {
                Console.WriteLine(student.Name + " " + student.EnrolledProgram.Fee);
            }
        }
    }
}
