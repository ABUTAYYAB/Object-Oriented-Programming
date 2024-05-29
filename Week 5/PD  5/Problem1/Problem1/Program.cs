using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int option = UI.UtilityUI.mainmenu();

            if (option == 1)
            {
                UI.StudentUI.AddStudent();
            }
            else if (option == 2)
            {
                UI.DegreeProgramUI.GetDegreeFromUser();
            }
            else if (option == 3)
            {
                UI.StudentUI.GenerateMerit();
            }
            else if (option == 4)
            {
                UI.StudentUI.RegisteredStudents();
            }
            else if (option == 5)
            {
                UI.StudentUI.RegisteredStudentsspecific();
            }
            else if (option == 6)
            {
                UI.StudentUI.showsubjects();
            }
            else if (option == 7)
            {
                DL.StudentDL.generatefee();
            }
        }
    }
}
