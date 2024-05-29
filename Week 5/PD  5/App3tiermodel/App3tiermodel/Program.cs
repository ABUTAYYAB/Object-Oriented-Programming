using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App3tiermodel.BL;
using App3tiermodel.DL;
using App3tiermodel.UI;


namespace App3tiermodel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuUI.ClearScreen();
            while (true) 
            {
                string MainMenuOption = MenuUI.MainMenu(); //it will print the main menu on the screen
                if(MainMenuOption =="1")
                {
                    string Role = UserDL.signIN(MenuUI.EnterID(), MenuUI.EnterPassword());    //calling the signIn function which will return The Role of the User
                    if(Role == "Admin") 
                    {
                        string AdminOption = MenuUI.AdminMenu();
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
                        MenuUI.Successfull();
                        continue;
                    }
                }
                else if(MainMenuOption =="2") 
                {
                    bool IsSignUpSuccessfull = UserDL.SignUP(UserUI.MakeUser());
                    if(IsSignUpSuccessfull) 
                    {
                        MenuUI.Successfull();
                    }
                }
            }
            
        }
    }
}
