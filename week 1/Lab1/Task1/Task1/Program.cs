using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s =  new Student();
            //s = getData();
            //Print_Data(s);

            //Student [] s = new Student[5];
            //s[0] = new Student();
            //s[1] = new Student();
            //s[2] = new Student();
            //s[3] = new Student();
            //s[4] = new Student();
            //Console.WriteLine("Welcome ");

            Console.ReadKey();

        }


        //static Student getData()
        //{
        //    string sname;
        //    float matric;
        //    float fsc;
        //    float ecat;
        //    float aggregate;

        //Console.Write("Enter Name: ");
        //    sname = Console.ReadLine();
        //    Console.Write("Enter Matric Marks: ");
        //    matric = float.Parse(Console.ReadLine());
        //Console.Write("Enter FSC Marks: ");
        //    fsc = float.Parse(Console.ReadLine());
        //Console.Write("Enter Ecat Marks: ");
        //    ecat = float.Parse(Console.ReadLine());
        //Console.Write("Enter Aggerate: ");
        //    aggregate = float.Parse(Console.ReadLine());
        //Student s = new Student(sname, matric, fsc,ecat,aggregate);

        //    return s;
        //}

    //static Student getData()
    //{

    //    Student s = new Student();
    //    Console.Write("Enter Name: ");
    //    s.sname = Console.ReadLine();
    //    Console.Write("Enter Matric Marks: ");
    //    s.matric = float.Parse(Console.ReadLine());
    //    Console.Write("Enter FSC Marks: ");
    //    s.fsc = float.Parse(Console.ReadLine());
    //    Console.Write("Enter Ecat Marks: ");
    //    s.ecat = float.Parse(Console.ReadLine());
    //    Console.Write("Enter Aggerate: ");
    //    s.aggregate = float.Parse(Console.ReadLine());
    //    return s;
    //}
    //static void Print_Data(Student [] s)
    //{
    //    for(int i = 0;i < 5; i++)
    //    {
    //        Console.WriteLine("Name is: {0}", s[i].sname);
    //        Console.WriteLine("Matric Marks are: {0}", s[i].matric);
    //        Console.WriteLine("Fsc Marks are: {0}", s[i].fsc);
    //        Console.WriteLine("Ecat Marks are: {0}", s[i].ecat);
    //        Console.WriteLine("Aggregate is : {0}", s[i].aggregate);


    //    }
    //}
    //static void Print_Data(Student s)
    //{

    //        Console.WriteLine("Name is: {0}", s.sname);
    //        Console.WriteLine("Matric Marks are: {0}", s.matric);
    //        Console.WriteLine("Fsc Marks are: {0}", s.fsc);
    //        Console.WriteLine("Ecat Marks are: {0}", s.ecat);
    //        Console.WriteLine("Aggregate is : {0}", s.aggregate);
    //}
}
}
