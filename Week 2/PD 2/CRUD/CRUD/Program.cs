using System;
using System.Collections.Generic;
using System.IO;

namespace CRUD
{
    internal class Program
    {
        static List<Admin> admin = new List<Admin>();
        static List<Employee> emp = new List<Employee>();
        static List<Customer> cus = new List<Customer>();

        static void Main(string[] args)
        {
            bool checkFileData = AccessDetailsOfUser();

            while (true)
            {
                PrintHeader();
                string option = "";
                option = print_Menu();
                if (option == "1")
                {
                    bool check;
                    check = signUP();
                    if (check)
                    {
                        Successfull();
                        bool storeData = StoreDetailsOfUser();
                    }
                    else
                    {
                        Unsuccessfull();
                    }
                }
                else if (option == "2")
                {
                    string role;
                    role = signIN();
                    if (role == "a")
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
                                    bool storeData = StoreDetailsOfUser();
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
                                    bool storeData = StoreDetailsOfUser();
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
                                    bool storeData = StoreDetailsOfUser();
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
                    else if (role == "e")
                    {
                        Console.Clear();
                        Console.WriteLine("Nothing Here");
                    }
                    else if (role == "c")
                    {
                        Console.Clear();
                        Console.WriteLine("Nothing Here");
                    }
                    else
                    {
                        Unsuccessfull();
                    }
                }
                else if (option == "3")
                {
                    bool storeData = StoreDetailsOfUser();
                    break;
                }
            }
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
        static bool signUP()
        {
            string name;
            string id;
            string password;
            string role;
            bool result;

            result = false;


            Console.Clear();
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter ID : ");
            id = Console.ReadLine();
            Console.Write("Enter Password : ");
            password = Console.ReadLine();
            Console.Write("Enter Role (a for Admin and e for Employee c for Customer ): ");
            role = Console.ReadLine();

            if (role == "c")
            {
                Customer c = new Customer(name, id, password);
                cus.Add(c);
                result = true;
            }
            else if (role == "a")
            {
                Admin a = new Admin(name, id, password);
                admin.Add(a);
                result = true;
            }
            else if (role == "e")
            {
                Employee e = new Employee(name, id, password);
                emp.Add(e);
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

            for (int i = 0; i < admin.Count; i++)
            {
                if (id == admin[i].id && password == admin[i].password)
                {
                    result = "a";
                    return result;

                }
            }
            for (int i = 0; i < emp.Count; i++)
            {
                if (id == emp[i].id && password == emp[i].password)
                {
                    result = "e";
                    return result;
                }
            }
            for (int i = 0; i < cus.Count; i++)
            {
                if (id == cus[i].id && password == cus[i].password)
                {
                    result = "c";
                    return result;
                }
            }
            return result;
        }
        static bool AccessDetailsOfUser()
        {
            bool check = false;

            if (File.Exists("usercredentials.txt"))
            {
                StreamReader file = new StreamReader("usercredentials.txt");

                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    string name = SeperatedText(line, 1);
                    string id = SeperatedText(line, 2);
                    string password = SeperatedText(line, 3);
                    string role = SeperatedText(line, 4);

                    if (role == "Admin")
                    {
                        admin.Add(new Admin(name, id, password));
                    }
                    else if (role == "Employee")
                    {
                        emp.Add(new Employee(name, id, password));
                    }
                    else if (role == "Customer")
                    {
                        cus.Add(new Customer(name, id, password));
                    }

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
        static bool StoreDetailsOfUser()
        {
            bool check = false;
            StreamWriter file = new StreamWriter("usercredentials.txt", append: false);

            for (int i = 0; i < admin.Count; i++)
            {
                Admin a = admin[i];
                file.WriteLine($"{a.name}|{a.id}|{a.password}|Admin|");
            }

            for (int i = 0; i < emp.Count; i++)
            {
                Employee e = emp[i];
                file.WriteLine($"{e.name}|{e.id}|{e.password}|Employee|");
            }

            for (int i = 0; i < cus.Count; i++)
            {
                Customer c = cus[i];
                file.WriteLine($"{c.name}|{c.id}|{c.password}|Customer|");
            }

            file.Flush();
            file.Close();
            check = true;

            return check;
        }
        static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                ______   _______ _________ _______             ______   _______  _       _________ _______          _________ _______ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                               (  __  \\ (  ___  )\\__   __/(  ____ )|\\     /|  (  __  \\ (  ____ \\( \\      \\__   __/(  ____ \\|\\     /|\\__   __/(  ____ \\");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                               | (  \\  )| (   ) |   ) (   | (    )|( \\   / )  | (  \\  )| (    \\/| (         ) (   | (    \\/| )   ( |   ) (   | (    \\/");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                               | |   ) || (___) |   | |   | (____)| \\ (_) /   | |   ) || (__    | |         | |   | |      | (___) |   | |   | (_____ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                               | |   | ||  ___  |   | |   |     __)  \\   /    | |   | ||  __)   | |         | |   | | ____ |  ___  |   | |   (_____  )");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                               | |   ) || (   ) |   | |   | (\\ (      ) (     | |   ) || (      | |         | |   | | \\_  )| (   ) |   | |         ) |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                               | (__/  )| )   ( |___) (___| ) \\ \\__   | |     | (__/  )| (____/\\| (____/\\___) (___| (___) || )   ( |   | |   /\\____) |");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                               (______/ |/     \\|\\_______/|/   \\__/   \\_/     (______/ (_______/(_______/\\_______/(_______)|/     \\|   )_(   \\_______)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                                                                   THE DAIRY SHOP");
            Console.ResetColor();
            Console.WriteLine();
        }
        static string AdminMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            PrintHeader();

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
        static bool removeUser(string id)
        {
            bool check = false;

            for (int i = 0; i < admin.Count; i++)
            {
                if (admin[i].id == id)
                {
                    admin.RemoveAt(i);
                    check = true;
                    return check;
                }
            }

            for (int i = 0; i < emp.Count; i++)
            {
                if (emp[i].id == id)
                {
                    emp.RemoveAt(i);
                    check = true;
                    return check;
                }
            }
            for (int i = 0; i < cus.Count; i++)
            {
                if (cus[i].id == id)
                {
                    cus.RemoveAt(i);
                    check = true;
                    return check;
                }
            }

            return check;
        }
        static bool updatePassword(string id, string newpass)
        {
            bool check = false;

            for (int i = 0; i < admin.Count; i++)
            {
                if (admin[i].id == id)
                {
                    admin[i].password = newpass;
                    check = true;
                    return check;
                }
            }
            for (int i = 0; i < emp.Count; i++)
            {
                if (emp[i].id == id)
                {
                    emp[i].password = newpass;
                    check = true;
                    return check;

                }
            }
            for (int i = 0; i < cus.Count; i++)
            {
                if (cus[i].id == id)
                {
                    cus[i].password = newpass;
                    check = true;
                    return check;
                }
            }
            return check;
        }
    }
}
