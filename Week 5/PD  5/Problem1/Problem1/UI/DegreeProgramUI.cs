using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;
using Problem1.DL;

namespace Problem1.UI
{
    internal class DegreeProgramUI
    {
        public static void GetDegreeFromUser()
        {
            List<Subject> subjects = new List<Subject>();

            DegreeProgram degreeProgram = new DegreeProgram();


            Console.WriteLine("Enter degree title");
            degreeProgram.Title = Console.ReadLine();

            Console.WriteLine("Enter Duration ");
            degreeProgram.Duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of seats in this degree");
            degreeProgram.AvailabeSeats = int.Parse(Console.ReadLine());

            Console.WriteLine("How many subjects you have in this degree");
            int subjectscount = int.Parse(Console.ReadLine());



            for (int i = 0; i < subjectscount; i++)
            {
                subjects.Add(GetSubjectsFromUser());
            }

            degreeProgram.Subjects = subjects;

            DL.DegreeProgramDL.DegreeProgramList.Add(degreeProgram);
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
        public static Subject GetSubjectsFromUser()
        {
            Subject subject = new Subject();
            Console.WriteLine("Enter Subject Code ");
            subject.SubjectCode = Console.ReadLine();
            Console.WriteLine("Enter Subject Credit Hours");
            subject.CreditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fee for the subject ");
            subject.SubjectFee = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Type of the subject");
            subject.SubjectType = Console.ReadLine();
            return subject;
        }

    }
}
