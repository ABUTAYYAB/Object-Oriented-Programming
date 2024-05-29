using Problem1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.DL
{
    internal class StudentDL
    {
        public static List<Student> studentlist = new List<Student>();

        public static void generatemeritlist()
        {
            foreach (Student student in studentlist)
            {
                student.calculatemerit();
            }
            studentlist.Sort((x, y) => x.Merit.CompareTo(y.Merit));
            studentlist.Reverse();
        }

        public static void giveseats()
        {
            foreach (Student student in studentlist)
            {

                foreach (DegreeProgram degreeprogram in student.Prefrences)
                {
                    if (degreeprogram.AvailabeSeats > 0)
                    {
                        student.EnrolledProgram = degreeprogram;
                        degreeprogram.AvailabeSeats--;
                        break;
                    }
                }
            }

        }

        public static void generatefee()
        {
            foreach (Student student in studentlist)
            {
                if (student.EnrolledProgram != null)
                {
                    foreach (Subject sub in student.RegisterdSubject)
                    {
                        student.fee += sub.SubjectFee;
                    }
                }
            }
            Console.WriteLine("Fee Has been generated for all the students.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
