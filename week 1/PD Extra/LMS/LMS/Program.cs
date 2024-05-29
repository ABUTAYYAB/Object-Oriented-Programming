using System;
using System.Collections.Generic;

namespace LMS
{
    internal class Program
    {
        static List<Student> student = new List<Student>();
        static List<Teacher> teacher = new List<Teacher>();
        static List<Course> course = new List<Course>();
        static List<Course> course_Student = new List<Course>();


        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                string option;
                option = print_Menu();
                if (option == "1")
                {
                    signUP();
                }
                else if (option == "2")
                {


                    string role;
                    role = signIN();

                    if (role == "s")
                    {
                        student1();
                    }
                    if (role == "t")
                    {
                        teacher1();
                    }
                    if (role == "sorry")
                    {
                        Console.WriteLine("Invalid");
                        Console.ReadKey();
                    }



                }
                else if (option == "3")
                {
                    break;

                }
                else
                {
                    continue;
                }
            }
        }
        static string print_Menu()
        {
            string option = "5";
            Console.WriteLine("Welcome");
            Console.WriteLine("1. Sign UP");
            Console.WriteLine("2.sign IN");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Your Option : ");
            option = Console.ReadLine();

            return option;
        }
        static string signIN()
        {
            Console.Clear();
            string id;
            string password;
            string role;
            string result = "sorry";
            Console.Write("Enter ID : ");
            id = Console.ReadLine();
            Console.Write("Enter Password : ");
            password = Console.ReadLine();
            Console.Write("Enter Role (s for student and t for teacher): ");
            role = Console.ReadLine();

            if (role == "s")
            {
                for (int i = 0; i < student.Count; i++)
                {
                    if (id == student[i].id && password == student[i].password)
                    {
                        result = "s";

                    }
                }

            }
            if (role == "t")
            {
                for (int i = 0; i < teacher.Count; i++)
                {
                    if (id == teacher[i].id && password == teacher[i].password)
                    {
                        result = "t";

                    }
                }

            }

            return result;





        }
        static void teacher1()
        {
            while (true)
            {
                int option;
                option = Teacher_Menu();
                if (option == 1)
                {
                    see_Avail();

                }
                if (option == 2)
                {
                    addnew();

                }
                if (option == 3)
                {
                    break;

                }

            }


        }

        static void student1()
        {
            while (true)
            {
                int option = Student_Menu();
                if (option == 1)
                {
                    enroll();

                }
                if (option == 2)
                {
                    see_Course();

                }
                if (option == 3)
                {
                    break;

                }

            }


        }

        static void addnew()
        {
            for (int i = 0; i < course.Count; i++)
            {
                Console.WriteLine("Course name : {0}", course[i].name);
                Console.WriteLine("Course id : {0}", course[i].id);
            }
            Console.Write("Enter Course name  : ");
            string name = Console.ReadLine();
            Console.Write("Enter Course id  : ");
            string id = Console.ReadLine();

            Course c = new Course(name, id);
            course.Add(c);

        }
        static void see_Avail()
        {
            for (int i = 0; i < course.Count; i++)
            {
                Console.WriteLine("Course name : {0}", course[i].name);
                Console.WriteLine("Course id : {0}", course[i].id);
            }

        }
        static int Teacher_Menu()
        {
            int option;
            Console.WriteLine("Welcome");
            Console.WriteLine("1. View Courses");
            Console.WriteLine("2. add  courses");
            Console.WriteLine("3. logout");
            option = int.Parse(Console.ReadLine());
            return option;

        }
        static void see_Course()
        {
            for (int i = 0; i < course_Student.Count; i++)
            {
                Console.WriteLine("Course name : {0}", course_Student[i].name);
                Console.WriteLine("Course id : {0}", course_Student[i].id);
            }

        }
        static void enroll()
        {
            for (int i = 0; i < course.Count; i++)
            {
                Console.WriteLine("Course name : {0}", course[i].name);
                Console.WriteLine("Course id : {0}", course[i].id);
            }
            Console.Write("Enter Course name  : ");
            string name = Console.ReadLine();
            Console.Write("Enter Course id  : ");
            string id = Console.ReadLine();

            Course c = new Course(name, id);
            course_Student.Add(c);

        }
        static int Student_Menu()
        {
            int option = 1;
            Console.WriteLine("Welcome");
            Console.WriteLine("1. Enroll in course");
            Console.WriteLine("2. view courses");
            Console.WriteLine("3. logout");
            Console.ReadKey();
            return option;
        }
        static void signUP()
        {
            string name;
            string id;
            string password;
            string role;
            Console.Clear();
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter ID : ");
            id = Console.ReadLine();
            Console.Write("Enter Password : ");
            password = Console.ReadLine();
            Console.Write("Enter Role (s for student and t for teacher): ");
            role = Console.ReadLine();

            if (role == "s")
            {
                Student s = new Student(name, id, password);
                student.Add(s);
            }
            if (role == "t")
            {
                Teacher t = new Teacher(name, id, password);
                teacher.Add(t);
            }
            else
            {
                Console.Write("Did Not sign in siccessfully :) ");
            }
        }
    }
}
