using System;
using System.Collections.Generic;
using System.IO;
using Task5.BL;

namespace Task5
{
    internal class Program
    {
        static List<User> list = new List<User>();

        static void Main(string[] args)
        {
            string path = "usercredentials.txt";
            bool getDetails = AccessDetailsOfUser(path);
            while (true)
            {
                string option = "";
                option = print_Menu();
                if (option == "1")
                {
                    string role = signIN();
                    if (role == "Admin")
                    {
                        while (true)
                        {
                            string adminOption = AdminMenu();
                            if (adminOption == "1")
                            {
                                bool check = signUP();
                                if (check)
                                {
                                    Successfull();
                                    bool storeData = StoreDetailsOfUser(path);
                                }
                                else
                                {
                                    Unsuccessfull();
                                }

                            }
                            else if (adminOption == "2")
                            {
                                string id;
                                Console.Write("Enter The ID of The User");
                                id = Console.ReadLine();
                                bool check = removeUser(id);
                                if (check)
                                {
                                    Successfull();
                                    bool storeData = StoreDetailsOfUser(path);
                                }
                                else
                                {
                                    Unsuccessfull();
                                }
                            }
                            else if (adminOption == "3")
                            {
                                string id;
                                string newpass;
                                Console.Write("Enter The ID of The User");
                                id = Console.ReadLine();
                                Console.Write("Enter The New Password of The User");
                                newpass = Console.ReadLine();

                                bool check = updatePassword(id, newpass);
                                if (check)
                                {
                                    Successfull();
                                    bool storeData = StoreDetailsOfUser(path);
                                }
                                else
                                {
                                    Unsuccessfull();
                                }


                            }
                            else if (adminOption == "4")
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }

                    }
                    else if (role == "Employee")
                    {
                        Console.WriteLine("You Are An Employee: ");
                        Console.ReadLine();
                    }
                    else if (role == "Customer")
                    {
                        Console.WriteLine("You Are Customer: ");
                        Console.ReadLine();
                    }

                }
                else if (option == "2")
                {
                    bool Check = signUP();
                    if (Check)
                    {
                        Console.WriteLine("Signed UP Successfully: ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Signed UP Unsuccessfull: ");
                        Console.ReadLine();
                    }
                    Check = StoreDetailsOfUser(path);

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
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2.sign Up");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Your Option : ");
            option = Console.ReadLine();

            return option;
        }
        static bool signUP()
        {
            string id;
            string password;
            string role;
            bool result;

            result = false;


            Console.Clear();
            Console.Write("Enter ID : ");
            id = Console.ReadLine();
            Console.Write("Enter Password : ");
            password = Console.ReadLine();
            Console.Write("Enter Role (a for Admin and e for Employee c for Customer ): ");
            role = Console.ReadLine();

            if (role == "c")
            {
                role = "Customer";
                User user = new User(id, password, role);
                list.Add(user);
                result = true;
            }
            else if (role == "a")
            {
                role = "Admin";
                User user = new User(id, password, role);
                list.Add(user);
                result = true;
            }
            else if (role == "e")
            {
                role = "Employee";
                User user = new User(id, password, role);
                list.Add(user);
                result = true;
            }

            return result;

        }
        static string signIN()
        {
            Console.Clear();
            string id;
            string password;
            string result = "sorry";
            Console.Write("Enter ID : ");
            id = Console.ReadLine();
            Console.Write("Enter Password : ");
            password = Console.ReadLine();

            for (int i = 0; i < list.Count; i++)
            {
                if (id == list[i].id && password == list[i].password)
                {
                    result = list[i].role;
                    return result;
                }
            }

            return result;
        }
        static bool AccessDetailsOfUser(string path)
        {
            bool check = false;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);

                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    string id = SeperatedText(line, 1);
                    string password = SeperatedText(line, 2);
                    string role = SeperatedText(line, 3);

                    User user = new User(id, password, role);
                    list.Add(user);

                }
                check = true;

                file.Close();


            }

            return check;
        }
        static string SeperatedText(string line, int num)
        {
            int count = 1;
            string word = "";

            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];

                if (ch == '|')
                {
                    count++;
                }
                else if (count == num)
                {
                    word += ch;
                }
            }

            return word;

        }
        static bool StoreDetailsOfUser(string path)
        {
            bool check = false;
            StreamWriter file = new StreamWriter(path, append: false);

            for (int i = 0; i < list.Count; i++)
            {
                User user = list[i];
                file.WriteLine($"{user.id}|{user.password}|{user.role}|");
            }
            file.Flush();
            file.Close();
            check = true;

            return check;
        }
        static string AdminMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;


            string option;
            Console.WriteLine("                      ************************************************************ Admin Menu ************************************************************");
            Console.WriteLine();
            Console.WriteLine("1. Add New Employee");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. Update Password");
            Console.WriteLine("4. Logout");
            Console.Write("Enter Your Option Here: ");
            option = Console.ReadLine();

            Console.ResetColor();

            return option;
        }
        static void Successfull()
        {
            Console.WriteLine("Operation Successfull :)");
            Console.ReadKey();
        }
        static void Unsuccessfull()
        {
            Console.WriteLine("Operation Unsuccessfull :)");
            Console.ReadKey();
        }
        static bool removeUser(string id)
        {
            bool check = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    list.RemoveAt(i);
                    check = true;
                    return check;
                }
            }
            return check;
        }
        static bool updatePassword(string id, string newpass)
        {
            bool check = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    list[i].password = newpass;
                    check = true;
                    return check;
                }
            }
            
            return check;
        }
    }
}
