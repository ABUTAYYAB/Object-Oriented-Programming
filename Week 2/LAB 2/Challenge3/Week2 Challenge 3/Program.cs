using System;
using System.Collections.Generic;
using System.IO;
using Week2_Challenge_3.BL;

namespace Week2_Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string path = "D:\\Semester 2 Lectures\\OOP\\OOP Lab\\Week 2\\Week2 Challenge 3\\data.txt" ;
            List<User> users = new List<User>();
            while(true)
            { 
                switch(Menu()) 
                {
                    case 1:
                        SignIn(users,ref count,path);
                        break;
                    case 2:
                        SignUp(users,ref count,path);
                        break;
                }
            }
        }
        static int Menu()
        {
            int num;
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static void SignUp(List<User> users,ref int count,string path)
        {
            User user = new User();
            Console.WriteLine("Enter your name: ");
            user.UserName = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            user.Password = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Role: ");
            user.Role = Console.ReadLine();
            users.Add(user);
            if(File.Exists(path))
            {
                Console.ReadLine();
            }
            count++;
        }
        static void SignIn(List<User> users,ref int count,string path)
        {
            string name;
            int Id;
            StreamReader fileReader = new StreamReader(path);
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            Id = int.Parse(Console.ReadLine());
            for(int i = 0; i <count; i++)
            {
                if(name == users[i].UserName && Id == users[i].Password)
                {
                    Console.WriteLine(users[i]);
                    fileReader.Close();
                    break;
                }
            }
        }

    }
}
