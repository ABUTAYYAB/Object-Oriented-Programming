using ChallengeNo1.BL;
using System;
using System.Collections.Generic;

namespace ChallengeNo1
{
    internal class Program
    {
        static List<Student> student = new List<Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string option = Mainmenu();
                if (option == "1")
                {
                    addstudent();

                }
                else if (option == "2")
                {
                    showStudents();
                    Console.ReadLine();
                }
                else if (option == "3")
                {
                    showAgg();
                    Console.ReadLine();


                }
                else if (option == "4")
                {
                    sort();
                    showTop3();
                    Console.ReadLine();


                }
                else
                {
                    continue;
                }


            }
        }
        static String Mainmenu()
        {
            string option;
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show Student");
            Console.WriteLine("3. Calculate Aggerate");
            Console.WriteLine("4.Top Students");
            option = Console.ReadLine();
            return option;
        }
        static void addstudent()
        {
            string name;
            int matric, fsc, ecat;
            float agg;
            Console.Write("Enter The Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Metric Marks: ");
            matric = int.Parse(Console.ReadLine());
            Console.Write("Enter Fsc Marks: ");
            fsc = int.Parse(Console.ReadLine());
            Console.Write("Enter Ecat Marks: ");
            ecat = int.Parse(Console.ReadLine());
            agg = calculateAgg(matric, fsc, ecat);
            Student s = new Student(name, matric, fsc, ecat, agg);
            student.Add(s);
        }
        static float calculateAgg(int matric, int fsc, int ecat)
        {
            float Result;
            Result = ((matric * 10) / 1100) + ((fsc * 40) / 1100) + ((ecat * 50) / 400);
            return Result;

        }
        static void showStudents()
        {
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine("\nStudent Name is {0}", student[i].name);
                Console.WriteLine("Student Matric Marks is {0}", student[i].matric);
                Console.WriteLine("Student FSC Marks is {0}", student[i].fsc);
                Console.WriteLine("Student Ecat Marks is {0}", student[i].ecat);
            }
        }
        static void showAgg()
        {
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine("\nStudent Name is {0}", student[i].name);
                Console.WriteLine("Student Aggregate is {0}", student[i].agg);
            }
        }
        static void sort()
        {
            Student temp = new Student();
            for (int i = 0; i < student.Count - 1; i++)
            {
                for (int j = 0; j < student.Count - 1; j++)
                {
                    if (student[j].agg < student[j + 1].agg)
                    {
                        temp = student[j];
                        student[j] = student[j + 1];
                        student[j + 1] = temp;
                    }

                }
            }
        }
        static void showTop3()
        {
            if (student.Count >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("\nStudent Name is {0}", student[i].name);
                    Console.WriteLine("Student Aggregate is {0}", student[i].agg);
                }

            }
            else
            {
                for (int i = 0; i < student.Count; i++)
                {
                    Console.WriteLine("\nStudent Name is {0}", student[i].name);
                    Console.WriteLine("Student Aggregate is {0}", student[i].agg);
                }

            }

        }

    }
}
