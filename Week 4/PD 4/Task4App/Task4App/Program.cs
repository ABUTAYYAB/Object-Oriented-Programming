using System;
using System.Collections.Generic;
using System.IO;
using Task4App.BL;

namespace Task4App
{
    internal class Program
    {
        static List<User> UserList = new List<User>();
        static List<Product> ProductList = new List<Product>();

        static void Main(string[] args)
        {
            string path = "usercredentials.txt";
            string pathproduct = "products.txt";
            bool getDetails = AccessDetailsOfUser(path);
            bool getDetailsp = AccessDetailsOfProducts(pathproduct);

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
                        while (true)
                        {
                            Console.WriteLine("You Are An Employee: ");
                            string EmpOpt = EmployeeMenu();
                            if (EmpOpt == "1")
                            {
                                bool check = ViewProducts();
                                if (check)
                                {
                                    Successfull();
                                }
                                else
                                {
                                    Unsuccessfull();
                                }
                                continue;

                            }
                            else if (EmpOpt == "2")
                            {
                                string name = EnterName();
                                double price = EnterPrice();
                                double quant = EnterQuantity();

                                Product p = new Product(name, price, quant);
                                ProductList.Add(p);
                                bool storeData = StoreDetailsOfProducts(pathproduct);

                                Successfull();

                                continue;
                            }
                            else if (EmpOpt == "3")
                            {
                                string name = EnterName();
                                bool check = RemoveProduct(name);
                                if (check)
                                {
                                    bool storeData = StoreDetailsOfProducts(pathproduct);
                                    Successfull();
                                }
                                else
                                {
                                    Unsuccessfull();
                                }
                                continue;


                            }
                            else if (EmpOpt == "3")
                            {
                                string name = EnterName();
                                double price = EnterPrice();
                                bool check = UpdatePrice(name, price);
                                if (check)
                                {
                                    Successfull();
                                    bool storeData = StoreDetailsOfProducts(pathproduct);

                                }
                                else
                                {
                                    Unsuccessfull();
                                }
                                continue;

                            }
                            else if (EmpOpt == "4")
                            {
                                string name = EnterName();
                                double quant = EnterQuantity();
                                bool check = UpdateQuantity(name, quant);
                                if (check)
                                {
                                    Successfull();
                                    bool storeData = StoreDetailsOfProducts(pathproduct);

                                }
                                else
                                {
                                    Unsuccessfull();
                                }
                                continue;

                            }
                            else if (EmpOpt == "5")
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }


                        }


                    }
                    else if (role == "Customer")
                    {
                        while (true)
                        {
                            string CusOpt = CustomerMenu();
                            if (CusOpt == "1")
                            {
                                bool check = ViewProducts();
                                if (check)
                                {
                                    Successfull();
                                }
                                else
                                {
                                    Unsuccessfull();
                                }
                                continue;
                            }
                            else if (CusOpt == "2")
                            {

                                double quant = EnterQuantity();
                                string name = EnterName();

                                bool check = BuyProduct(name,quant);
                                if (check)
                                {
                                    Successfull();
                                }
                                else
                                {
                                    Unsuccessfull();
                                }
                                continue;


                            }
                            else if (CusOpt == "2")
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
                UserList.Add(user);
                result = true;
            }
            else if (role == "a")
            {
                role = "Admin";
                User user = new User(id, password, role);
                UserList.Add(user);
                result = true;
            }
            else if (role == "e")
            {
                role = "Employee";
                User user = new User(id, password, role);
                UserList.Add(user);
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

            for (int i = 0; i < UserList.Count; i++)
            {
                if (id == UserList[i].id && password == UserList[i].password)
                {
                    result = UserList[i].role;
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
                    UserList.Add(user);

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

            for (int i = 0; i < UserList.Count; i++)
            {
                User user = UserList[i];
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



            string option;
            Console.WriteLine("                      ************************************************************ Admin Menu ************************************************************");
            Console.WriteLine();
            Console.WriteLine("1. Add New Employee");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. Update Password");
            Console.WriteLine("4. Logout");
            Console.Write("Enter Your Option Here: ");
            option = Console.ReadLine();


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

            for (int i = 0; i < UserList.Count; i++)
            {
                if (UserList[i].id == id)
                {
                    UserList.RemoveAt(i);
                    check = true;
                    return check;
                }
            }
            return check;
        }
        static bool updatePassword(string id, string newpass)
        {
            bool check = false;

            for (int i = 0; i < UserList.Count; i++)
            {
                if (UserList[i].id == id)
                {
                    UserList[i].password = newpass;
                    check = true;
                    return check;
                }
            }

            return check;
        }
        static string EmployeeMenu()
        {
            Console.Clear();
            string option;
            Console.WriteLine("                           ******************************************************** Employee Menu ********************************************************");
            Console.WriteLine();
            Console.WriteLine("1.View products");
            Console.WriteLine("2.Add products");
            Console.WriteLine("3.Remove products");
            Console.WriteLine("4.Update Price");
            Console.WriteLine("5.Update Quantity");
            Console.WriteLine("6.Logout");
            Console.Write("Enter Your Option Here: ");

            option = Console.ReadLine();

            return option;
        }
        static string EnterName()
        {
            Console.Write("Enter the Name of the product: ");
            string name = Console.ReadLine();
            return name;
        }
        static double EnterPrice()
        {
            Console.Write("Enter the Price of the product: ");
            double price = double.Parse(Console.ReadLine());
            return price;
        }
        static double EnterQuantity()
        {
            Console.Write("Enter the Quantity of the product: ");
            double quantity = double.Parse(Console.ReadLine());
            return quantity;
        }
        static bool RemoveProduct(string name)
        {
            bool Result = false;
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (name == ProductList[i].name)
                {
                    ProductList.RemoveAt(i);
                    Result = true;
                }
            }
            return Result;
        }
        static bool UpdatePrice(string name, double price)
        {
            bool Result = false;
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (name == ProductList[i].name)
                {
                    ProductList[i].UpdatePrice(price);
                    Result = true;
                }
            }
            return Result;
        }
        static bool UpdateQuantity(string name, double quantity)
        {
            bool Result = false;
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (name == ProductList[i].name)
                {
                    ProductList[i].UpdateQuantity(quantity);
                    Result = true;
                }
            }
            return Result;
        }
        static bool ViewProducts()
        {
            bool Result = true;
            for (int i = 0; i < ProductList.Count; i++)
            {
                Console.WriteLine($"Name is " + ProductList[i].ViewName() + "\nPrice is " + ProductList[i].ViewPrice() + "\nQuantity is " + ProductList[i].ViewQuantity());
                Console.WriteLine("\n");
            }

            return Result;
        }
        static bool StoreDetailsOfProducts(string pathproducts)
        {
            bool check = false;
            StreamWriter file = new StreamWriter(pathproducts, append: false);

            for (int i = 0; i < ProductList.Count; i++)
            {
                User user = UserList[i];
                Product p = ProductList[i];
                file.WriteLine($"{p.name}|{p.price}|{p.quantity}|");
            }
            file.Flush();
            file.Close();
            check = true;

            return check;
        }
        static bool AccessDetailsOfProducts(string pathproduct)
        {
            bool check = false;

            if (File.Exists(pathproduct))
            {
                StreamReader file = new StreamReader(pathproduct);

                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    string name = SeperatedText(line, 1);
                    double price = double.Parse(SeperatedText(line, 2));
                    double Quant = double.Parse(SeperatedText(line, 3));
                    Product p = new Product(name, price, Quant);
                    ProductList.Add(p);
                }
                check = true;

                file.Close();
            }

            return check;
        }
        static string CustomerMenu()
        {
            Console.Clear();
            string option;
            Console.WriteLine("                     ************************************************************** Customer Menu **************************************************************");
            Console.WriteLine();
            Console.WriteLine("1.View products");
            Console.WriteLine("2.Buy Product");
            Console.WriteLine("3. Logout");
            Console.Write("Enter Your Option Here:");
            option = Console.ReadLine();
            return option;
        }
        static bool BuyProduct(string name, double quant)
        {

            bool Result = false;
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (name == ProductList[i].name)
                {
                    ProductList[i].BuyItem(quant);
                    Result = true;
                }
            }
            return Result;

        }


    }
    
}
