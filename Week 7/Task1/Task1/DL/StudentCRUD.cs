﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.DL
{
    internal static class StudentCRUD
    {
        public static List<Student> students = new List<Student>();

        public static List<Student> GetStudentsList()
        {
            return students;
        }
        public static Student AddStudent(Student student)
        {
            students.Add(student);
            return student;
        }

        public static void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public static Student RemoveStudentByName(string name)
        {
            foreach (Student student in students)
            {
                if (student.Name == name)
                {
                    students.ToList().Remove(student);
                }
            }
            return null;
        }

        public static Student FindStudentByName(string name)
        {
            foreach (Student student in students)
            {
                if (student.Name == name)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
