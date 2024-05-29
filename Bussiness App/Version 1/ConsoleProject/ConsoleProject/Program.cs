using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject.UI;
using DairydelightsDLL.BL;
using DairydelightsDLL.DL;
using DairydelightsDLL.DL.FileHandling;




namespace ConsoleProject
{
    internal class Program
    {

        static void Main(string[] args)
        {

            MenuUI.ClearScreen();
            UserFH.users = UserFH.AccessDetailsOfUser(UserFH.GetPath());

            while (true)
            {
                string MainMenuOption = MenuUI.MainMenu(); //it will print the main menu on the screen
                if (MainMenuOption == "1")
                {
                    string Role = UserFH.signIN(UserUI.EnterID(), UserUI.EnterPassword());    //calling the signIn function which will return The Role of the User
                    if (Role == "Admin")
                    {
                        string AdminOption = MenuUI.AdminMenu();
                        if(AdminOption == "1") 
                        {
                             bool result = WorkerFH.AddWorkerIntoList(WorkerUI.MakeWorker());
                        }
                    }
                    else if (Role == "Employee")
                    {
                        string EmployeeOption = MenuUI.EmployeeMenu();
                    }
                    else if (Role == "Customer")
                    {
                        string CustomerOption = MenuUI.CustomerMenu();
                    }
                    else
                    {
                        MenuUI.Unsuccessfull();

                    }
                }
                else if (MainMenuOption == "2")
                {
                    bool IsSignUpSuccessfull = UserFH.SignUP(UserUI.MakeUser());
                    if (IsSignUpSuccessfull)
                    {
                        MenuUI.Successfull();
                    }
                }
                else
                {
                    bool result = UserFH.StoreDetailsOfUser(UserFH.GetPath());
                    break;

                }
            }


        }
    }
}
