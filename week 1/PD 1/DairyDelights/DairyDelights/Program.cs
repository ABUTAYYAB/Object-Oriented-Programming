using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelights
{
    internal class program
    {
        static void Main(string[] args)
        {
            string[] username = new string[100];
            string[] password = new string[100];
            string[] role = new string[100];
            string[] complains_FromEmployees = new string[100];
            string[] products = new string[100];
            string[] products_Description = new string[100];
            string[] Customer_Review_AboutProducts = new string[100];

            int[] products_Price = new int[100];
            int[] products_Quantity = new int[100];
            int productcount = 0;
            int usercount = 0;
            int discount = 0;
            

            float[] cart_Price = new float[100];
            bool checkArray;

            checkArray = AccessDetailsOfUser(username, password, role, complains_FromEmployees, ref usercount);
            checkArray = AccessDetailsOfProducts(products, products_Price, products_Quantity, products_Description, Customer_Review_AboutProducts, ref productcount);

            while (true)
            {
                Console.Clear();   // for clearing the screen.
                program.PrintHeader();  // for printing Header.
                program.PrintWelcome(); // for printing welcome.
                string loginValue;

                loginValue = program.LoginPage(); // it will tell which option is selected by the user.

                if (loginValue == "1") // if will execute only when 1 is selected by the user.
                {
                    string user, pass, personRole; // variable declaration

                    Console.Clear();
                    program.PrintHeader(); // again, the header will print

                    user = program.InputUsername(); // gather info
                    pass = program.InputPassword();

                    personRole = program.SignIn(user, pass, username, password, role); // pass to function which will return a value which will be admin or employee or customer.

                    if (personRole == "admin") // it will be true only when the role is admin.
                    {
                        while (true) // again infinite loop.
                        {
                            Console.Clear();

                            string adminOption; // variable declaration

                            adminOption = program.AdminMenu();
                            if (adminOption == "1") // it will execute when the user wants to work on option 1
                            {
                                bool check; // variable declaration
                                bool checkEmployee;
                                bool validate;

                                string userAdmin, passAdmin, roleAdmin;
                                Console.Clear();
                                program.PrintHeader(); // again, the header will print

                                userAdmin = program.InputUsername();
                                validate = program.ValidUser(userAdmin); // to check the user is valid.
                                if (validate)
                                {
                                    passAdmin = program.InputPassword();
                                    validate = program.ValidPassword(passAdmin); // then check password validity.
                                    if (validate)
                                    {
                                        roleAdmin = program.InputRole(); // then check role validity.
                                        validate = program.ValidRole(roleAdmin);
                                        if (validate)
                                        {
                                            check = program.SignUp(userAdmin, passAdmin, roleAdmin,username, password, role, ref usercount); // if it is true then the user has been entered in the database.

                                            if (check) // if true then add one to the numbers of users in the database.
                                            {
                                                program.PressAnyKey();
                                            }
                                            else
                                            {
                                                program.PressAnyKey();
                                            }
                                        }
                                        else
                                        {
                                            program.Unsuccessful(); // it means that the input was not right and action cannot be done.
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        program.PressAnyKey(); // again input mistake.
                                        continue;
                                    }
                                }
                                else // again action cannot be done because of invalid input.
                                {
                                    program.PressAnyKey();
                                    continue;
                                }
                            }
                            else if (adminOption == "2")
                            {
                                Console.Clear();
                                PrintHeader(); // again, the header will print
                                bool check;
                                string removeEmployeeUser;

                                removeEmployeeUser = InputUsername();

                                check = RemoveEmployee(removeEmployeeUser, username, password, role, ref usercount);

                                if (check)
                                {
                                    Successful();
                                    continue;
                                }
                                else
                                {
                                    PressAnyKey();
                                }
                                continue;
                            }
                            else if (adminOption == "3")
                            {
                                Console.Clear();
                                PrintHeader(); // again, the header will print
                                bool check;
                                discount = GetPercentageOfDiscount();
                                if (discount >= 100)
                                {
                                    discount = 0;
                                    InvalidInput();
                                }
                                else
                                {
                                    Successful();
                                }
                                continue;
                            }
                            else if (adminOption == "4")
                            {
                                Console.Clear();
                                PrintHeader(); // again, the header will print
                                float remove;
                                remove = RemoveDiscount(ref discount);
                                if (remove > discount)
                                {
                                    PressAnyKey();
                                    continue;
                                }
                                else
                                {
                                    discount = (int)(discount - remove); // Explicitly convert float to int
                                    if (discount < 0)
                                    {
                                        discount = 0;
                                    }
                                    PressAnyKey();
                                }
                                continue;
                            }
                            else if (adminOption == "5")
                            {
                                break;
                            }
                            else
                            {
                                InvalidInput();
                                continue;
                            }
                        }
                    }
                    else if (personRole == "employee")
                    {
                        while(true)
                        {
                            string employeeOption;

                            employeeOption = EmployeeMenu(); // it will print the employee menu and return which option is returned
                            if (employeeOption == "1") // execute only when option 1 is selected
                            {
                                Console.Clear();
                                PrintHeader(); // again, the header will print
                                bool check;
                                check = PrintProducts(products, products_Quantity, products_Price, ref productcount);
                                PressAnyKey();
                                continue;
                            }
                            else if (employeeOption == "2")
                            {
                                Console.Clear();
                                PrintHeader(); // again, the header will print
                                bool check;
                                string name;
                                int quantity;
                                int price;

                                name = InputName();
                                check = Validation(name);
                                if (check)
                                {
                                    quantity = InputProductQuantity();
                                    if (quantity == 9876543)
                                    {
                                        PressAnyKey();
                                        continue;
                                    }
                                    price = InputProductPrice();
                                    if (price == 9876543)
                                    {
                                        PressAnyKey();
                                        continue;
                                    }

                                    if (price != 9876543)
                                    {

                                        check = AddNewProducts(name, quantity, price, products, products_Quantity, products_Price,ref productcount);
                                        if (check)
                                        {
                                            Successful();
                                        }
                                        else
                                        {
                                            PressAnyKey();
                                        }
                                        continue;
                                    }
                                }
                                else
                                {
                                    PressAnyKey();
                                    continue;
                                }
                            }
                            else if (employeeOption == "3")
                            {
                                Console.Clear();
                                PrintHeader(); // again, the header will print
                                bool check;
                                string name;

                                name = InputName();

                                check = RemoveProduct(name, products, products_Quantity, products_Price, ref productcount);
                                if (check)
                                {
                                    Successful();
                                }
                                else
                                {
                                    PressAnyKey();
                                }
                                continue;
                            }
                            else if (employeeOption == "4")
                            {
                                Console.Clear();
                                PrintHeader(); // again, the header will print
                                bool check;
                                string name;
                                int price;

                                name = InputName();
                                price = InputProductPrice();
                                if (price == 9876543)
                                {
                                    PressAnyKey();
                                    continue;
                                }
                                if (price != 9876543)
                                {
                                    check = UpdatePriceOfProduct(name, price, products, products_Price,ref productcount);
                                    if (check)
                                    {
                                        Successful();
                                    }
                                    else
                                    {
                                        PressAnyKey();
                                    }
                                    continue;
                                }
                            }

                            else if (employeeOption == "5")
                            {
                                break;

                            }
                            else
                            {
                                InvalidInput();
                                continue;
                            }
                        }
                    }

                }
                else if (loginValue == "2")
                {
                    while (true)
                    {
                        Console.Clear();
                        PrintHeader();
                        bool check;
                        bool validate;
                        string userAdmin, passAdmin, roleAdmin;

                        userAdmin = InputUsername();
                        validate = ValidUser(userAdmin);

                        if (validate)
                        {
                            passAdmin = InputPassword();
                            validate = ValidPassword(passAdmin);

                            if (validate)
                            {
                                roleAdmin = InputRole();
                                validate = ValidRoleCustomer(roleAdmin);

                                if (validate)
                                {
                                    check = SignUp(userAdmin, passAdmin, roleAdmin, username, password, role, ref usercount);

                                    if (check)
                                    {
                                        usercount++;
                                        PressAnyKey();
                                        break;
                                    }
                                    else
                                    {
                                        PressAnyKey();
                                        break;
                                    }
                                }
                                else
                                {
                                    PressAnyKey();
                                    break;
                                }
                            }
                            else
                            {
                                PressAnyKey();
                                break;
                            }
                        }
                        else
                        {
                            PressAnyKey();
                            break;
                        }
                    }
                }
                else if (loginValue == "3")
                {
                    bool check;
                    check = StoreDetailsOfUser(username, password, role, complains_FromEmployees, usercount);
                    check = StoreDetailsAboutProducts(products, products_Price, products_Quantity, products_Description, Customer_Review_AboutProducts, productcount);

                    PrintThanks();
                    break;
                }
                else
                {
                    InvalidInput();
                    continue;
                }


            }


        }
        static bool UpdatePriceOfProduct(string name, int price, string[] products, int[] productsPrice, ref int productCount)
        {
            bool check = false;
            int productIndex = -1;

            for (int index = 0; index < productCount; index++)
            {
                if (name == products[index])
                {
                    check = true;
                    productIndex = index;
                    break;
                }
            }

            if (check)
            {
                productsPrice[productIndex] = price;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Product not found");
                Console.ResetColor();
            }

            return check;
        }


        static bool RemoveProduct(string name, string[] products, int[] productsQuantity, int[] productsPrice, ref int productCount)
        {
            bool check = false;
            int nameIndex = 0;

            for (int index = 0; index < productCount; index++)
            {
                if (name == products[index])
                {
                    nameIndex = index;
                    check = true;
                    break;
                }
            }

            if (check)
            {
                for (int index = nameIndex; index < productCount - 1; index++)
                {
                    products[index] = products[index + 1];
                    productsQuantity[index] = productsQuantity[index + 1];
                    productsPrice[index] = productsPrice[index + 1];
                }

                productCount--;
            }

            if (!check)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Product Not Found");
                Console.ResetColor();
            }

            return check;
        }

        static int InputProductQuantity()
        {
            int quantity;
            string ans;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the Quantity of the Product: ");
            Console.ResetColor();
            ans = Console.ReadLine();

            if (int.TryParse(ans, out quantity) && quantity != 0)
            {
                quantity = Math.Abs(quantity);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Invalid input. Please enter a valid positive integer.");
                Console.ResetColor();
                quantity = 9876543;
            }

            return quantity;
        }

        static int InputProductPrice()
        {
            int price;
            string ans;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the Price of the Product (whole Number Only): ");
            Console.ResetColor();
            ans = Console.ReadLine();

            if (int.TryParse(ans, out price) && price != 0)
            {
                price = Math.Abs(price);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Invalid input. Please enter a valid positive integer.");
                Console.ResetColor();
                price = 9876543;
            }

            return price;
        }
        static bool AddNewProducts(string name, int quantity, int price, string[] products, int[] products_Quantity, int[] products_Price, ref int productCount)
        {
            bool check = true;

            for (int index = 0; index < productCount; index++)
            {
                if (name == products[index])
                {
                    check = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Product already exists");
                    Console.ResetColor();
                    break;
                }
            }

            if (check)
            {
                products[productCount] = name;
                products_Quantity[productCount] = quantity;
                products_Price[productCount] = price;
                productCount++;
            }

            return check;
        }
        static string InputName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the Product Name: ");
            Console.ResetColor();
            string name = Console.ReadLine();

            return name;
        }
        static bool PrintProducts(string[] products, int[] products_Quantity, int[] products_Price, ref int productCount)
        {
            bool check = true;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Name:");
            for (int index = 0; index < productCount; index++)
            {
                Console.WriteLine($"{index + 1}. {products[index]}");
            }
            Console.WriteLine();

            Console.WriteLine("Quantity: ");
            for (int index = 0; index < productCount; index++)
            {
                Console.WriteLine($"{index + 1}. {products_Quantity[index]} kg.");
            }
            Console.WriteLine();

            Console.WriteLine("Price: ");
            for (int index = 0; index < productCount; index++)
            {
                Console.WriteLine($"{index + 1}. {products_Price[index]} Rs.");
            }

            Console.ResetColor();
            return check;
        }
        static string EmployeeMenu()
        {
            Console.Clear();
            PrintHeader();
            string option;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                           ******************************************************** Employee Menu ********************************************************");
            Console.WriteLine();
            Console.WriteLine("1.View products");
            Console.WriteLine("2.Add products");
            Console.WriteLine("3.Remove products");
            Console.WriteLine("4.Update Price");
            Console.WriteLine("5.Logout");
            Console.Write("Enter Your Option Here: ");

            option = Console.ReadLine();

            Console.ResetColor();
            return option;
        }
        static int RemoveDiscount(ref int discount)
        {
            int discountPercentage;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Right Now Discount offered is: {discount} %");
            Console.WriteLine("Enter how much discount you want to remove:");
            Console.ResetColor();
            string ans = Console.ReadLine();

            if (int.TryParse(ans, out discountPercentage) && discountPercentage > 0)
            {
                if (discountPercentage < 0)
                {
                    discountPercentage = -discountPercentage;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Invalid input. Please enter a valid positive integer.");
                Console.ResetColor();
                discountPercentage = 9876543;
            }

            if (discountPercentage > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Input");
                Console.ResetColor();
                discountPercentage = 200;
            }

            return discountPercentage;
        }

        static int GetPercentageOfDiscount()
        {
            int discountPercentage;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter how much flat discount you want to offer:");
            Console.ResetColor();
            string ans = Console.ReadLine();

            if (int.TryParse(ans, out discountPercentage) && discountPercentage > 0)
            {
                if (discountPercentage < 0)
                {
                    discountPercentage = -discountPercentage;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Invalid input. Please enter a valid positive integer.");
                Console.ResetColor();
                discountPercentage = 9876543;
            }

            return discountPercentage;
        }

        static bool RemoveEmployee(string user, string[] username, string[] password, string[] roleArray, ref int count)
        {
            int userIndex = -1;
            bool check = false;

            for (int index = 0; index < count; index++)
            {
                if (username[index] == user)
                {
                    userIndex = index;
                    check = true;
                    break;
                }
            }

            if (check)
            {
                if (roleArray[userIndex] == "admin")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You cannot remove an admin.");
                    Console.ResetColor();
                    check = false;
                }

                if (check)
                {
                    for (int index = userIndex; index < count - 1; index++)
                    {
                        username[index] = username[index + 1];
                        password[index] = password[index + 1];
                        roleArray[index] = roleArray[index + 1];
                    }

                    count--;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Username not found.");
                Console.ResetColor();
                check = false;
            }

            return check;
        }

        static bool ValidRoleCustomer(string role)
        {
            bool validRole = false;

            if (role == "customer")
            {
                validRole = true;
            }

            if (!validRole)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can only sign up as \"customer\". If you want to sign up as an employee, contact your admin.");
                Console.ResetColor();
            }

            return validRole;
        }

        static void Successful()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task is completed Successfully");
            Console.ResetColor();
            Console.ReadKey();
        }

        static void Unsuccessful()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Task is not completed Successfully");
            Console.ResetColor();
            Console.ReadKey();
        }
        static void PressAnyKey()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press Any Key To Continue :)");
            Console.ResetColor();
            Console.ReadKey();
        }

        static void InvalidInput()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Input!");
            Console.WriteLine("Press Any Key To Continue :)");
            Console.ResetColor();
            Console.ReadKey();
        }
        static bool ValidRole(string role)
        {
            return true;
        }
        static string InputRole()
        {
            string roleAdmin;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter Role (customer/employee): ");
            Console.ResetColor();

            roleAdmin = Console.ReadLine();

            return roleAdmin;
        }
        static void PrintThanks()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Thank You :)");
            Console.ReadKey();
            Console.ResetColor();
        }
        static bool SignUp(string user, string pass, string role, string[] username, string[] password, string[] roleArray, ref int count)
        {
            bool check = false;

            for (int index = 0; index < count; index++)
            {
                if (user == username[index])
                {
                    check = true;
                }
            }

            if (check)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Username already exists");
                Console.ResetColor();
            }

            if (!check)
            {
                if (role == "employee" || role == "customer")
                {
                    check = false;
                }
                else
                {
                    check = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a valid role (employee/customer)");
                    Console.ResetColor();
                }

                if (!check)
                {
                    username[count] = user;
                    password[count] = pass;
                    roleArray[count] = role;
                    count++;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Successfully Signed Up");
                    Console.ResetColor();
                }
            }

            return !check;
        }
        static bool ValidUser(string user)
        {
            bool containsSpace = true;

            for (int index = 0; index < user.Length; index++)
            {
                if (user[index] == ' ')
                {
                    containsSpace = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("User name cannot contain spaces");
                    Console.ResetColor();
                    break; // exit the loop if a space is found
                }
            }

            if (containsSpace)
            {
                containsSpace = Validation(user);
            }

            return containsSpace;
        }

        static bool ValidPassword(string pass)
        {
            bool passAdmin;

            if (pass.Length == 4)
            {
                passAdmin = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password cannot have more or fewer than 4 letters");
                Console.ResetColor();
                passAdmin = false;
            }

            if (passAdmin)
            {
                for (int index = 0; index < pass.Length; index++)
                {
                    if (pass[index] == ' ')
                    {
                        passAdmin = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Password cannot contain spaces");
                        Console.ResetColor();
                        break; // exit the loop if a space is found
                    }
                }
            }

            if (passAdmin)
            {
                passAdmin = Validation(pass);
            }

            return passAdmin;
        }
        static bool Validation(string word)
        {
            bool containLetter = true;

            for (int index = 0; index < word.Length; index++)
            {
                if (word[index] == '|')
                {
                    containLetter = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cannot take input of this \"|\" Character");
                    Console.ResetColor();
                    break; // exit the loop if a | is found
                }
            }

            return containLetter;
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
            Console.WriteLine("3. Set discount");
            Console.WriteLine("4. Remove discount");
            Console.WriteLine("5. Logout");
            Console.Write("Enter Your Option Here: ");
            option = Console.ReadLine();

            Console.ResetColor();

            return option;
        }
        static string SignIn(string user, string pass, string[] username, string[] password, string[] roleArray)
        {
            int index;
            string result = "";
            bool check = true;

            for (index = 0; index < 100; index++)
            {
                if (user == username[index] && pass == password[index])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Valid");
                    Console.WriteLine("Press any key to continue");
                    Console.ResetColor();
                    Console.ReadKey();
                    result = roleArray[index];
                    check = false;
                    break;
                }
            }

            if (check)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid username or password");
                Console.ResetColor();
                result = "invalid";
            }

            return result;
        }
        static string InputUsername()
        {
            string user;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter username: ");
            Console.ResetColor();

            user = Console.ReadLine();

            return user;
        }

        static string InputPassword()
        {
            string pass;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter password: ");
            Console.ResetColor();

            pass = Console.ReadLine();

            return pass;
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
        static void PrintWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                 __      __       .__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                /  \\    /  \\ ____ |  |   ____  ____   _____   ____ ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                \\   \\/\\/   // __ \\|  | _/ ___\\/  _ \\ /     \\_/ __ \\");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                \\        /\\  ___/|  |_\\  \\__(  <_> )  Y Y  \\  ___/");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                  \\__/\\  /  \\___  >____/\\___  >____/|__|_|  /\\___  >");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                       \\/       \\/          \\/            \\/     \\/");
            Console.ResetColor();
            Console.WriteLine();
        }
        static string LoginPage()
        {
            string loginValue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("LOGIN PAGE :");
            Console.WriteLine();
            Console.WriteLine("1. Sign In ");
            Console.WriteLine("2. Sign Up ");
            Console.WriteLine("3. Exit ");
            Console.WriteLine();
            Console.Write("Enter Your Option here: ");
            Console.ResetColor();

            loginValue = Console.ReadLine();
            return loginValue;
        }

        static bool StoreDetailsOfUser(string[] username, string[] password, string[] role, string[] complains_FromEmployees, int usercount)
        {
            bool check = false;

            using (StreamWriter file = new StreamWriter("usercredentials.txt", append: false))
            {
                for (int index = 0; index < usercount; index++)
                {
                    file.WriteLine($"{username[index]}|{password[index]}|{role[index]}|{complains_FromEmployees[index]}");
                }
            }

            check = true;

            return check;
        }


        static bool AccessDetailsOfUser(string[] username, string[] password, string[] role, string[] complains_FromEmployees, ref int usercount)
        {
            bool check = false;

            if (File.Exists("usercredentials.txt"))
            {
                using (StreamReader file = new StreamReader("usercredentials.txt"))
                {
                    usercount = 0;

                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();

                        username[usercount] = SeperatedText(line, 1);
                        password[usercount] = SeperatedText(line, 2);
                        role[usercount] = SeperatedText(line, 3);
                        complains_FromEmployees[usercount] = SeperatedText(line, 4);

                        usercount++;
                        check = true;
                    }
                }
            }

            return check;
        }


        

        static bool AccessDetailsOfProducts(string[] products, int[] products_Price, int[] products_Quantity, string[] products_Description, string[] Customer_Review_AboutProducts, ref int productcount)
        {
            bool check = false;

            if (File.Exists("productdetails.txt"))
            {
                using (StreamReader file = new StreamReader("productdetails.txt"))
                {
                    productcount = 0;

                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();

                        products[productcount] = SeperatedText(line, 1);
                        products_Price[productcount] = ChangeStringToInt(SeperatedText(line, 2));
                        products_Quantity[productcount] = ChangeStringToInt(SeperatedText(line, 3));
                        products_Description[productcount] = SeperatedText(line, 4);
                        Customer_Review_AboutProducts[productcount] = SeperatedText(line, 5);

                        productcount++;
                        check = true;
                    }
                }
            }

            return check;
        }
        static bool StoreDetailsAboutProducts(string[] products, int[] products_Price, int[] products_Quantity, string[] products_Description, string[] Customer_Review_AboutProducts, int productcount)
        {
            bool check = false;

            using (StreamWriter file_product = new StreamWriter("productdetails.txt"))
            {
                for (int index = 0; index < productcount; index++)
                {
                    if (index != productcount - 1)
                    {
                        file_product.WriteLine($"{products[index]}|{products_Price[index]}|{products_Quantity[index]}|{products_Description[index]}|{Customer_Review_AboutProducts[index]}");
                    }
                    else
                    {
                        file_product.Write($"{products[index]}|{products_Price[index]}|{products_Quantity[index]}|{products_Description[index]}|{Customer_Review_AboutProducts[index]}");
                    }

                    check = true;
                }
            }

            return check;
        }
        static string SeperatedText(string line, int num)
        {
            int count = 1;
            string word = "";

            foreach (char ch in line)
            {
                if (ch == '|')
                {
                    count++;
                }
                else if (num == count)
                {
                    word += ch;
                }
            }

            return word;
        }
        static int ChangeStringToInt(string input)
        {
            int result;
            if (int.TryParse(input, out result))
            {
                return result;
            }
            return 0; 
        }
    }
}
