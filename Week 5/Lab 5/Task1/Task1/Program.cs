﻿using System;
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
                    StudentDL.AddStudent(student);

                }
                else if (option == 2)
                {
                    DegreeProgram degree = DegreeProgramUI.GetDegreeFromUser();
                    DegreeProgramDL.AddDegree(degree);
                }
                else if (option == 3)
                {
                    StudentUI.DisplayAllStudents(StudentDL.GetStudentsList());
                }

            }
        }
    }
}
