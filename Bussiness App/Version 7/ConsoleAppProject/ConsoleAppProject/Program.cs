using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using DairyDelightsLibrary.Validation;
using System;


namespace ConsoleAppProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUser user = ObjectHandler.GetUserInstance();

            while (true)
            {
                string option = UI.Menu.GetInformationMenus.MainMenu();
                if (option == "1")
                {
                    User OldUser = UI.Menu.GetInformationMenus.SignIN();
                    string Role = user.SignIN(OldUser.GetUserName(), OldUser.GetPassword());
                    if (Role == "Admin")
                    {
                        while (true)
                        {
                            string AdminOption = UI.Menu.AdminMenuUI.AdminMenu();
                            if (AdminOption == "1")
                            {
                                User NewEmployee = UI.Menu.AdminMenuUI.AddUser();
                                if(NewEmployee != null)
                                {
                                    bool check = user.SignUP(NewEmployee);
                                    if (check)
                                    {
                                        UI.Menu.GetInformationMenus.Successfull();
                                        continue;
                                    }
                                }
                                else
                                {
                                    UI.Menu.GetInformationMenus.Unsuccessfull();
                                    continue;
                                }

                            }
                            else if (AdminOption == "2")
                            {
                                UI.Menu.AdminMenuUI.DisplayAllUsersOnScreen(user.GetUsersList());

                                string UserName = UI.Menu.GetInformationMenus.EnterUserName();
                                if(user.CheckIfUserNameAlreadyExist(UserName))
                                {
                                    bool check = user.RemoveUser(UserName);
                                    if (check)
                                    {
                                        UI.Menu.GetInformationMenus.Successfull();
                                        continue;
                                    }
                                }
                                else
                                {
                                    UI.Menu.GetInformationMenus.Unsuccessfull();
                                    continue;
                                }

                            }
                            else if (AdminOption == "3")
                            {
                                UI.Menu.AdminMenuUI.DisplayAllUsersOnScreen(user.GetUsersList());
                                string UserName = UI.Menu.GetInformationMenus.EnterUserName();
                                string NewPassword = UI.Menu.GetInformationMenus.EnterNewPassword();
                                if (user.CheckIfUserNameAlreadyExist(UserName))
                                {
                                    bool check = user.ChangePasswordByUserName(UserName, NewPassword);
                                    if (check)
                                    {
                                        UI.Menu.GetInformationMenus.Successfull();
                                        continue;
                                    }
                                }
                                else
                                {
                                    UI.Menu.GetInformationMenus.Unsuccessfull();
                                    continue;
                                }


                            }
                            else if (AdminOption == "4")
                            {
                                string NewPassword = UI.Menu.GetInformationMenus.EnterNewPassword();
                                if(UserValidation.IsStringValid(NewPassword))
                                {
                                    bool check = user.ChangePassword(NewPassword);
                                    if (check)
                                    {
                                        UI.Menu.GetInformationMenus.Successfull();
                                        continue;
                                    }
                                }
                                else
                                {
                                    UI.Menu.GetInformationMenus.Unsuccessfull();
                                    continue;
                                }

                            }
                            else if (AdminOption == "5")
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (Role == "Worker")
                    {
                        while (true)
                        {
                            string optionworker = UI.Menu.WorkerMenuUI.WorkerMenu();
                            if(optionworker == "1")
                            {
                                string NewPassword = UI.Menu.GetInformationMenus.EnterNewPassword();
                                if (UserValidation.IsStringValid(NewPassword))
                                {
                                    bool check = user.ChangePassword(NewPassword);
                                    if (check)
                                    {
                                        UI.Menu.GetInformationMenus.Successfull();
                                        continue;
                                    }
                                }
                                else
                                {
                                    UI.Menu.GetInformationMenus.Unsuccessfull();
                                    continue;
                                }

                            }
                            else if(optionworker == "2")
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }


                        }

                    }
                    else if (Role == "Delivery Boy")
                    {
                        while (true)
                        {
                            string optionWorker = UI.Menu.DeliveryBoyMenuUI.DeliveryBoyMenu();
                            if (optionWorker == "1")
                            {
                                string NewPassword = UI.Menu.GetInformationMenus.EnterNewPassword();
                                if (UserValidation.IsStringValid(NewPassword))
                                {
                                    bool check = user.ChangePassword(NewPassword);
                                    if (check)
                                    {
                                        UI.Menu.GetInformationMenus.Successfull();
                                        continue;
                                    }
                                }
                                else
                                {
                                    UI.Menu.GetInformationMenus.Unsuccessfull();
                                    continue;
                                }

                            }
                            else if (optionWorker == "2")
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }

                        }
                    }
                    else if (Role == "Customer")
                    {
                        while (true)
                        {
                            string optionCustomer = UI.Menu.CustomerMenuUI.CustomerMenu();
                            if (optionCustomer == "1")
                            {
                                string NewPassword = UI.Menu.GetInformationMenus.EnterNewPassword();
                                if (UserValidation.IsStringValid(NewPassword))
                                {
                                    bool check = user.ChangePassword(NewPassword);
                                    if (check)
                                    {
                                        UI.Menu.GetInformationMenus.Successfull();
                                        continue;
                                    }
                                }
                                else
                                {
                                    UI.Menu.GetInformationMenus.Unsuccessfull();
                                    continue;
                                }

                            }
                            else if (optionCustomer == "2")
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }

                        }
                    }
                    else
                    {
                        UI.Menu.GetInformationMenus.Unsuccessfull();
                        continue;
                    }
                }
                else if (option == "2")
                {
                    User NewUser = UI.Menu.GetInformationMenus.SignUp();
                    if (NewUser != null)
                    {
                        bool check = user.SignUP(NewUser);
                        if (check)
                        {
                            UI.Menu.GetInformationMenus.Successfull();
                        }
                    }
                    else
                    {
                        UI.Menu.GetInformationMenus.Unsuccessfull();
                        continue;
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
    }
}
