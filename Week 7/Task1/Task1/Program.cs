using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;
using Task1.UI;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int option = MenuUI.MainMenu();
                if (option == 1)
                {
                    Student student = StudentUI.GetStudentFromUser();
                    StudentCRUD.AddStudent(student);

                }
                else if (option == 2)
                {
                    DegreeProgram degree = DegreeProgramUI.GetDegreeFromUser();
                    DegreeProgramCRUD.AddDegree(degree);
                }
                else if (option == 3)
                {
                    StudentUI.DisplayAllStudentsMerit(StudentCRUD.students);
                }
                else if (option == 4)
                {
                    StudentUI.DisplayAllStudents(StudentCRUD.GetStudentsList());
                }
                else if (option == 5)
                {
                    StudentUI.GetStudentOfSpecificProgram(StudentCRUD.students);
                }
                else if (option == 6)
                {
                    StudentUI.RegisterSubjectToStudent();
                }
                else if (option == 7)
                {
                    StudentUI.CalculateFeesForAllStudents();
                }
                else if (option == 8)
                {
                    Environment.Exit(0);
                    break;
                }

            }
        }
    }
}
