using System;
using System.Collections.Generic;
using week_2_Challenge_1.BL;

namespace week_2_Challenge_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Student_data> data = new List<Student_data>();
            int count = 0;

            while (true)
            {
                switch (menu())
                {
                    case 1:
                        // Add a new student and store it in the data array
                        data.Add(AddStudent());
                        count++;
                        break;
                    case 2:
                        ShowStudent(data, count);
                        break;
                    case 3:
                        CalculateAggregate(data, count);
                        break;
                    case 4:
                        TopStudent(data, count);
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }
            }
        }

        private static int menu()
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show Student");
            Console.WriteLine("3. Calculate Aggregate");
            Console.WriteLine("4. Top Three Students");
            Console.WriteLine("Enter Your Choice: ");
            return int.Parse(Console.ReadLine());
        }

        private static Student_data AddStudent()
        {
            Student_data s = new Student_data();
            Console.WriteLine("Enter the name of the Student: ");
            s.name = Console.ReadLine();
            Console.WriteLine("Enter matric Marks: ");
            s.matricMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter fsc Marks: ");
            s.fscMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ecat Marks: ");
            s.ecatMarks = float.Parse(Console.ReadLine());
            return s;
        }
        private static void ShowStudent(List<Student_data> s, int count)
        {
            Console.WriteLine("The data of students is given");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(s[i].name + "\t" + s[i].matricMarks + "\t" + s[i].fscMarks + "\t" + s[i].ecatMarks);
            }
        }

        private static void CalculateAggregate(List<Student_data> s, int count)
        {
            for (int j = 0; j < count; j++)
            {
                float v2 = s[j].ecatMarks / 400f * 50f + s[j].fscMarks / 1100f * 30f + s[j].matricMarks / 1100f * 20f;
                s[j].aggregate = v2;
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(s[i].name + "\t" + s[i].matricMarks + "\t" + s[i].fscMarks + "\t" + s[i].ecatMarks + "\t" + s[i].aggregate);
            }
        }
        private static void TopStudent(List<Student_data> s, int count)
        {
            int val=0;
            float topStudent=0;
            float topStudent1=0;
            float topStudent2=0;
            Console.WriteLine("The top three students are: ");
            for(int i = 0;i < count;i++)
            {
                if (s[i].aggregate >= topStudent)
                {
                    topStudent = s[i].aggregate;
                    val = i;
                }
            }
            Console.WriteLine(s[val].name + "\t" + s[val].aggregate);
            for (int i = 0; i < count ; i++)
            {
                if (s[i].aggregate >= topStudent1 && (topStudent != s[i].aggregate))
                {
                    topStudent1 = s[i].aggregate;
                    val = i;
                }
            }
            Console.WriteLine(s[val].name + "\t" + s[val].aggregate);
            for (int i = 0; i < count ; i++)
            {
                if (s[i].aggregate >= topStudent2 && (topStudent != s[i].aggregate&& topStudent != s[i].aggregate))
                {
                    topStudent2 = s[i].aggregate;
                    val = i;
                }
            }
            Console.WriteLine(s[val].name + "\t" + s[val].aggregate);
        }
    }
}
