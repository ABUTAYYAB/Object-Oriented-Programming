// Task1

// main
// using System;
// using Task1.BL;

// namespace Task1
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Calculator c = new Calculator();
//             float result;
//             while (true)
//             {
//                 Console.Clear();
//                 int opt = Menu();
//                 if (opt == 1)
//                 {
//                     Input(c);
//                     result = c.Add();
//                 }
//                 else if (opt == 2)
//                 {
//                     Input(c);
//                     result = c.Subtract();
//                 }
//                 else if (opt == 3)
//                 {
//                     Input(c);
//                     result = c.Multiply();
//                 }
//                 else if (opt == 4)
//                 {
//                     Input(c);
//                     if(c.num2 == 0)
//                     {
//                         Console.WriteLine("Cannot Divide by Zero:");
//                         Console.ReadLine();
//                         continue;
//                     }
//                     result = c.Divide();
//                 }
//                 else if (opt == 5)
//                 {
//                     Input(c);
//                     result = c.Mod();
//                 }
//                 else if (opt == 6)
//                 {
//                     break;
//                 }
//                 else
//                 {
//                     continue;
//                 }

//                 Console.WriteLine("Result is : "+ result);
//                 Console.ReadLine();
//             }
//         }
//         static int Menu()
//         {
//             int opt = 0;

//             Console.WriteLine("1. Add");
//             Console.WriteLine("2. Subtract");
//             Console.WriteLine("3. Multiply");
//             Console.WriteLine("4. Divide");
//             Console.WriteLine("5. Modulo");
//             Console.WriteLine("6. Exit");
//             Console.WriteLine("Enter the Option: ");
//             opt = int.Parse(Console.ReadLine());

//             return opt;
//         }
//         static void Input(Calculator c)
//         {
//             Console.WriteLine("Enter First Number ");
//             c.num1 = float.Parse(Console.ReadLine());

//             Console.WriteLine("Enter Second Number ");
//             c.num2 = float.Parse(Console.ReadLine());
//         }
//     }
// }

// class  Calculator
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task1.BL
// {
//     internal class Calculator
//     {
//         public Calculator()
//         {
//             this.num1 = 10;
//             this.num2 = 10;
//         }
//         public Calculator (float num1,float num2)
//         {
//             this.num1 = num1;
//             this.num2 = num2;
//         }
//         public float num1, num2,result;
//         public float Add()
//         {
//             result = num1 + num2;
//             return result;
//         }
//         public float Subtract()
//         {
//             result = num1 - num2;
//             return result;
//         }
//         public float Multiply()
//         {
//             result = num1 * num2;
//             return result;
//         }
//         public float Divide()
//         {
//             result = num1 / num2;
//             return result;
//         }
//         public float Mod()
//         {
//             result = num1 % num2;
//             return result;
//         }

//     }
// }

// Task2
// Mian
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Task2.BL;

// namespace Task2
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Calculator c = new Calculator();
//             double result;
//             while (true)
//             {
//                 Console.Clear();
//                 int opt = Menu();
//                 if (opt == 1)
//                 {
//                     Input(c);
//                     result = c.Add();
//                 }
//                 else if (opt == 2)
//                 {
//                     Input(c);
//                     result = c.Subtract();
//                 }
//                 else if (opt == 3)
//                 {
//                     Input(c);
//                     result = c.Multiply();
//                 }
//                 else if (opt == 4)
//                 {
//                     Input(c);
//                     if (c.num2 == 0)
//                     {
//                         Console.WriteLine("Cannot Divide by Zero:");
//                         Console.ReadLine();
//                         continue;
//                     }
//                     result = c.Divide();
//                 }
//                 else if (opt == 5)
//                 {
//                     Input(c);
//                     result = c.Mod();
//                 }
//                 else if (opt == 6)
//                 {
//                     NewInput(c);
//                     result = c.Sqrt();
//                 }
//                 else if (opt == 7)
//                 {
//                     Input(c);
//                     result = c.Power();
//                 }
//                 else if (opt == 8)
//                 {
//                     NewInput(c);
//                     result = c.Log();
//                 }
//                 else if (opt == 9)
//                 {
//                     NewInput(c);
//                     result = c.Sin();
//                 }
//                 else if (opt == 10)
//                 {
//                     NewInput(c);
//                     result = c.Cos();
//                 }
//                 else if (opt == 11)
//                 {
//                     NewInput(c);
//                     result = c.Tan();
//                 }
//                 else if (opt == 12)
//                 {
//                     break;
//                 }
//                 else
//                 {
//                     continue;
//                 }

//                 Console.WriteLine("Result is : " + result);
//                 Console.ReadLine();
//             }

//         }
//         static int Menu()
//         {
//             int opt;
//             Console.WriteLine("1. Add");
//             Console.WriteLine("2. Subtract");
//             Console.WriteLine("3. Multiply");
//             Console.WriteLine("4. Divide");
//             Console.WriteLine("5. Modulo");
//             Console.WriteLine("6. Sqrt");
//             Console.WriteLine("7. Exponention");
//             Console.WriteLine("8. Log");
//             Console.WriteLine("9. Sin");
//             Console.WriteLine("10. Cos");
//             Console.WriteLine("11. Tan");
//             Console.WriteLine("12. Exit");
//             Console.WriteLine("Enter the Option: ");
//             opt = int.Parse(Console.ReadLine());

//             return opt;
//         }
//         static void Input(Calculator c)
//         {
//             Console.WriteLine("Enter First Number ");

//             c.num1 = double.Parse(Console.ReadLine());
//             Console.WriteLine("Enter Second Number ");
//             c.num2 = double.Parse(Console.ReadLine());
//         }
//         static void NewInput(Calculator c)
//         {
//             Console.WriteLine("Enter Number ");
//             c.num1 = double.Parse(Console.ReadLine());
//         }
//     }
// }

// class 1 Calculator
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task2.BL
// {
//     internal class Calculator
//     {
//         public Calculator()
//         {
//             this.num1 = 10;
//             this.num2 = 10;
//         }
//         public Calculator(double num1, double num2)
//         {
//             this.num1 = num1;
//             this.num2 = num2;
//         }
//         public double num1, num2, result;
//         public double Add()
//         {
//             result = num1 + num2;
//             return result;
//         }
//         public double Subtract()
//         {
//             result = num1 - num2;
//             return result;
//         }
//         public double Multiply()
//         {
//             result = num1 * num2;
//             return result;
//         }
//         public double Divide()
//         {
//             result = num1 / num2;
//             return result;
//         }
//         public double Mod()
//         {
//             result = num1 % num2;
//             return result;
//         }
//         public double Sqrt()
//         {
//             result = Math.Sqrt(num1);
//             return result;
//         }
//         public double Power()
//         {
//             result = Math.Pow(num1, num2);
//             return result;
//         }
//         public double Log()
//         {
//             result = Math.Log(num1);
//             return result;
//         }
//         public double Sin()
//         {
//             result = Math.Sin(num1);
//             return result;
//         }
//         public double Cos()
//         {
//             result = Math.Cos(num1);
//             return result;
//         }
//         public double Tan()
//         {
//             result = Math.Tan(num1);
//             return result; ;
//         }
//     }
// }

// Task3
// Main
// Class 1  Shiritori
// 

// Task4
// Main
// using Microsoft.SqlServer.Server;
// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Task4.BL;

// namespace Task4
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Book> list = new List<Book>();
//             while (true) 
//             {
//                 int option = Menu();
//                 if(option == 1)
//                 {
//                     Book b = new Book();
//                     b.GetTitle();
//                     b.GetAuthor();
//                     b.GetPublictionYear();
//                     b.Price();
//                     b.Quantity();
//                     list.Add(b);
//                 }
//                 else if(option == 2) 
//                 {
//                     displayStock(list);
//                 }
//                 else if (option == 3)
//                 {
//                     Console.Write("Enter The Title of the Book: ");
//                     string title = Console.ReadLine();
//                     string author = getAuthor(title, list);
//                     Console.Write("Author is  {0}: ",author);
//                     Console.ReadLine();
//                 }
//                 else if (option == 4)
//                 {
//                     Console.Write("Enter The Title of the Book: ");
//                     string title = Console.ReadLine();
//                     string result = AddStock(title, list);
//                     Console.WriteLine(result);
//                     Console.ReadLine();
//                 }
//                 else if (option == 5)
//                 {
//                     Console.Write("Enter The Title of the Book: ");
//                     string title = Console.ReadLine();
//                     string result = Sell(title, list);
//                     Console.WriteLine(result);
//                     Console.ReadLine();
//                 }
//                 else if (option == 6)
//                 {
//                     Console.WriteLine("Total No of Books Avialable is : {0}",list.Count);
//                     Console.ReadLine();
//                 }
//                 else if (option == 7)
//                 {
//                     break;
//                 }
//                 else
//                 {
//                     continue;
//                 }
//             }

//         }
//         static int Menu()
//         {
//             int option;
//             Console.WriteLine("1. Add Book");
//             Console.WriteLine("2. View All Books");
//             Console.WriteLine("3. Author Details");
//             Console.WriteLine("4. Sold Copies");
//             Console.WriteLine("5. Restock");
//             Console.WriteLine("6. See the count of books");
//             Console.WriteLine("7. Exit");
//             option = int.Parse(Console.ReadLine());

//             return option;
//         }
//         static void displayStock( List <Book> list)
//         {
//             for(int i = 0;i < list.Count; i++)
//             {
//                 Console.WriteLine("\nBook Title is: {0}", list[i].title);
//                 Console.WriteLine("Book Author is: {0}", list[i].author);
//                 Console.WriteLine("Book PublictionYear is: {0}", list[i].publictionYear);
//                 Console.WriteLine("Book price is: {0}", list[i].price);
//             }

//             Console.WriteLine("Press Enter To Continue:");
//             Console.ReadLine();
//         }
//         static string getAuthor(string title, List<Book> list)
//         {
//             for(int i = 0; i < list.Count; i++)
//             {
//                 if(title == list[i].title)
//                 {
//                     return list[i].author;
//                 }
//             }
//             return "notfound";
//         }
//         static string Sell(string title, List<Book> list)
//         {
//             for (int i = 0; i < list.Count; i++)
//             {
//                 if (title == list[i].title)
//                 {
//                     list[i].SoldStock();
//                     return "Task Done";
//                 }
//             }
//             return "notfound";
//         }

//         static string AddStock(string title, List<Book> list)
//         {
//             for (int i = 0; i < list.Count; i++)
//             {
//                 if (title == list[i].title)
//                 {
//                     list[i].AddStock();
//                     return "Task Done";
//                 }
//             }
//             return "notfound";
//         }

//     }
// }

// class 1 Book
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task4.BL
// {
//     internal class Book
//     {
//         public Book()
//         {


//         }


//         public int quantityInStock, stock, sell;
//         public string title, author, publictionYear;
//         public float price;
//         public void GetTitle()
//         {
//             Console.WriteLine("Enter the title of this book: ");
//             title = Console.ReadLine();

//         }
//         public void Price()
//         {

//             Console.WriteLine("Enter the price of the book: ");
//             price = float.Parse(Console.ReadLine());
//         }
//         public void GetAuthor()
//         {
//             Console.WriteLine("Enter the author of this book: ");
//             author = Console.ReadLine();
//         }
//         public void GetPublictionYear()
//         {
//             Console.WriteLine("Enter the Publication year of this book: ");
//             publictionYear = Console.ReadLine();
//         }
//         public void Quantity()
//         {

//             Console.WriteLine("Enter the Stock: ");
//             quantityInStock = int.Parse(Console.ReadLine());
//         }
//         public void AddStock()
//         {
//             Console.WriteLine("Enter the quantity you want to add: ");
//             stock = int.Parse(Console.ReadLine());
//             quantityInStock += stock;
//         }
//         public void SoldStock()
//         {

//             Console.WriteLine("Enter the quantity you want to Sell: ");
//             sell = int.Parse(Console.ReadLine());
//             quantityInStock -= sell;
//         }

//     }
// }


// Task5
// main
// using System;
// using System.Collections.Generic;
// using System.IO;
// using Task5.BL;

// namespace Task5
// {
//     internal class Program
//     {
//         static List<User> list = new List<User>();

//         static void Main(string[] args)
//         {
//             string path = "usercredentials.txt";
//             bool getDetails = AccessDetailsOfUser(path);
//             while (true)
//             {
//                 string option = "";
//                 option = print_Menu();
//                 if (option == "1")
//                 {
//                     string role = signIN();
//                     if (role == "Admin")
//                     {
//                         while (true)
//                         {
//                             string adminOption = AdminMenu();
//                             if (adminOption == "1")
//                             {
//                                 bool check = signUP();
//                                 if (check)
//                                 {
//                                     Successfull();
//                                     bool storeData = StoreDetailsOfUser(path);
//                                 }
//                                 else
//                                 {
//                                     Unsuccessfull();
//                                 }

//                             }
//                             else if (adminOption == "2")
//                             {
//                                 string id;
//                                 Console.Write("Enter The ID of The User");
//                                 id = Console.ReadLine();
//                                 bool check = removeUser(id);
//                                 if (check)
//                                 {
//                                     Successfull();
//                                     bool storeData = StoreDetailsOfUser(path);
//                                 }
//                                 else
//                                 {
//                                     Unsuccessfull();
//                                 }
//                             }
//                             else if (adminOption == "3")
//                             {
//                                 string id;
//                                 string newpass;
//                                 Console.Write("Enter The ID of The User");
//                                 id = Console.ReadLine();
//                                 Console.Write("Enter The New Password of The User");
//                                 newpass = Console.ReadLine();

//                                 bool check = updatePassword(id, newpass);
//                                 if (check)
//                                 {
//                                     Successfull();
//                                     bool storeData = StoreDetailsOfUser(path);
//                                 }
//                                 else
//                                 {
//                                     Unsuccessfull();
//                                 }


//                             }
//                             else if (adminOption == "4")
//                             {
//                                 break;
//                             }
//                             else
//                             {
//                                 continue;
//                             }
//                         }

//                     }
//                     else if (role == "Employee")
//                     {
//                         Console.WriteLine("You Are An Employee: ");
//                         Console.ReadLine();
//                     }
//                     else if (role == "Customer")
//                     {
//                         Console.WriteLine("You Are Customer: ");
//                         Console.ReadLine();
//                     }

//                 }
//                 else if (option == "2")
//                 {
//                     bool Check = signUP();
//                     if (Check)
//                     {
//                         Console.WriteLine("Signed UP Successfully: ");
//                         Console.ReadLine();
//                     }
//                     else
//                     {
//                         Console.WriteLine("Signed UP Unsuccessfull: ");
//                         Console.ReadLine();
//                     }
//                     Check = StoreDetailsOfUser(path);

//                 }
//                 else if (option == "3")
//                 {
//                     break;
//                 }
//                 else
//                 {
//                     continue;
//                 }
//             }


//         }
//         static string print_Menu()
//         {
//             string option = "5";
//             Console.WriteLine("Welcome");
//             Console.WriteLine("1. Sign In");
//             Console.WriteLine("2.sign Up");
//             Console.WriteLine("3. Exit");
//             Console.Write("Enter Your Option : ");
//             option = Console.ReadLine();

//             return option;
//         }
//         static bool signUP()
//         {
//             string id;
//             string password;
//             string role;
//             bool result;

//             result = false;


//             Console.Clear();
//             Console.Write("Enter ID : ");
//             id = Console.ReadLine();
//             Console.Write("Enter Password : ");
//             password = Console.ReadLine();
//             Console.Write("Enter Role (a for Admin and e for Employee c for Customer ): ");
//             role = Console.ReadLine();

//             if (role == "c")
//             {
//                 role = "Customer";
//                 User user = new User(id, password, role);
//                 list.Add(user);
//                 result = true;
//             }
//             else if (role == "a")
//             {
//                 role = "Admin";
//                 User user = new User(id, password, role);
//                 list.Add(user);
//                 result = true;
//             }
//             else if (role == "e")
//             {
//                 role = "Employee";
//                 User user = new User(id, password, role);
//                 list.Add(user);
//                 result = true;
//             }

//             return result;

//         }
//         static string signIN()
//         {
//             Console.Clear();
//             string id;
//             string password;
//             string result = "sorry";
//             Console.Write("Enter ID : ");
//             id = Console.ReadLine();
//             Console.Write("Enter Password : ");
//             password = Console.ReadLine();

//             for (int i = 0; i < list.Count; i++)
//             {
//                 if (id == list[i].id && password == list[i].password)
//                 {
//                     result = list[i].role;
//                     return result;
//                 }
//             }

//             return result;
//         }
//         static bool AccessDetailsOfUser(string path)
//         {
//             bool check = false;

//             if (File.Exists(path))
//             {
//                 StreamReader file = new StreamReader(path);

//                 while (!file.EndOfStream)
//                 {
//                     string line = file.ReadLine();

//                     string id = SeperatedText(line, 1);
//                     string password = SeperatedText(line, 2);
//                     string role = SeperatedText(line, 3);

//                     User user = new User(id, password, role);
//                     list.Add(user);

//                 }
//                 check = true;

//                 file.Close();


//             }

//             return check;
//         }
//         static string SeperatedText(string line, int num)
//         {
//             int count = 1;
//             string word = "";

//             for (int i = 0; i < line.Length; i++)
//             {
//                 char ch = line[i];

//                 if (ch == '|')
//                 {
//                     count++;
//                 }
//                 else if (count == num)
//                 {
//                     word += ch;
//                 }
//             }

//             return word;

//         }
//         static bool StoreDetailsOfUser(string path)
//         {
//             bool check = false;
//             StreamWriter file = new StreamWriter(path, append: false);

//             for (int i = 0; i < list.Count; i++)
//             {
//                 User user = list[i];
//                 file.WriteLine($"{user.id}|{user.password}|{user.role}|");
//             }
//             file.Flush();
//             file.Close();
//             check = true;

//             return check;
//         }
//         static string AdminMenu()
//         {
//             Console.Clear();
//             Console.BackgroundColor = ConsoleColor.DarkBlue;
//             Console.ForegroundColor = ConsoleColor.Yellow;


//             string option;
//             Console.WriteLine("                      ************************************************************ Admin Menu ************************************************************");
//             Console.WriteLine();
//             Console.WriteLine("1. Add New Employee");
//             Console.WriteLine("2. Remove Employee");
//             Console.WriteLine("3. Update Password");
//             Console.WriteLine("4. Logout");
//             Console.Write("Enter Your Option Here: ");
//             option = Console.ReadLine();

//             Console.ResetColor();

//             return option;
//         }
//         static void Successfull()
//         {
//             Console.WriteLine("Operation Successfull :)");
//             Console.ReadKey();
//         }
//         static void Unsuccessfull()
//         {
//             Console.WriteLine("Operation Unsuccessfull :)");
//             Console.ReadKey();
//         }
//         static bool removeUser(string id)
//         {
//             bool check = false;

//             for (int i = 0; i < list.Count; i++)
//             {
//                 if (list[i].id == id)
//                 {
//                     list.RemoveAt(i);
//                     check = true;
//                     return check;
//                 }
//             }
//             return check;
//         }
//         static bool updatePassword(string id, string newpass)
//         {
//             bool check = false;

//             for (int i = 0; i < list.Count; i++)
//             {
//                 if (list[i].id == id)
//                 {
//                     list[i].password = newpass;
//                     check = true;
//                     return check;
//                 }
//             }
            
//             return check;
//         }
//     }
// }
//  class 1 User
//  using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task5.BL
// {
//     internal class User
//     {
//         public User(string id, string password, string role)
//         {
//             this.id = id;
//             this.password = password;
//             this.role = role;

//         }
//         public string id;
//         public string password;
//         public string role;
//     }
// }


// Task6
// main
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading;
// using System.Threading.Tasks;
// using EZInput;
// using Task6.BL;

// namespace Task6
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Player player = new Player(1,22);
//             Enemy enemy = new Enemy();
//             Console.Clear();
//             char[,] maze = GenerateMaze();
//             PrintMaze(maze);
//             player.PrintPlayer();
//             enemy.PrintEnemy();


//             while (true)
//             {
//                 enemy.MoveEnemy();

//                 if (Keyboard.IsKeyPressed(Key.RightArrow))
//                 {
//                     player.MovePlayerRight(maze);
//                 }
//                 else if (Keyboard.IsKeyPressed(Key.LeftArrow))
//                 {
//                     player.MovePlayerLeft(maze);
//                 }
//                 else if (Keyboard.IsKeyPressed(Key.UpArrow))
//                 {
//                     player.MovePlayerUp(maze);
//                 }
//                 else if (Keyboard.IsKeyPressed(Key.DownArrow))
//                 {
//                     player.MovePlayerDown(maze);
//                 }
//                 Thread.Sleep(20);

//             }


//         }
//         static char[,] GenerateMaze()
//         {
//             char[,] maze = {
//             {'*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*','*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
//             {'*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*','*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*'},

//         };
//             return maze;
//         }

//         static void PrintMaze(char[,] maze)
//         {
//             int rows = maze.GetLength(0);
//             int cols = maze.GetLength(1);
//             for (int i = 0; i < rows; i++)
//             {
//                 for (int j = 0; j < cols; j++)
//                 {
//                     Console.Write(maze[i, j]);
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// class 1 Player
// using System;

// namespace Task6.BL
// {
//     internal class Player
//     {
//         public Player()
//         {
//             px = 5;
//             py = 18;
//         }
//         public Player(int px, int py)
//         {
//             this.px = px;
//             this.py = py;
//         }

//         public int px, py;

//         public void PrintPlayer()
//         {
//             Console.SetCursorPosition(px, py);
//             Console.Write("P");
//         }
//         public void RemovePlayer()
//         {
//             Console.SetCursorPosition(px, py);
//             Console.Write(" ");
//         }
//         public void MovePlayerRight(char[,] maze)
//         {
//             if (maze[px+1, py] == ' ' )
//             {
//                 Console.SetCursorPosition(px, py);
//                 RemovePlayer();
//                 px += 1;
//                 PrintPlayer();
//             }
            
//         }
//         public void MovePlayerLeft(char[,] maze)
//         {
//             if (maze[px-1, py] == ' ' && px > 1)
//             {
//                 Console.SetCursorPosition(px, py);
//                 RemovePlayer();
//                 px -= 1;
//                 PrintPlayer();
//             }
//             else
//             {

//             }
//         }
//         public void MovePlayerUp(char[,] maze)
//         {
//             if (maze[px, py -1] == ' ' && py > 1)
//             {
//                 Console.SetCursorPosition(px, py);
//                 RemovePlayer();
//                 py -= 1;
//                 PrintPlayer();
//             }
//             else
//             {

//             }
//         }
//         public void MovePlayerDown(char[,] maze)
//         {
//             if (maze[px, py + 1] == ' ' && py < 22)
//             {
//                 Console.SetCursorPosition(px, py);
//                 RemovePlayer();
//                 py += 1;
//                 PrintPlayer();
//             }
//             else
//             {

//             }
//         }


//     }
// }
 
// class 2 Enemy
// using System;

// namespace Task6.BL
// {
//     internal class Enemy
//     {
//         public int ex, ey;
//         public string direction; 

//         public Enemy()
//         {
//             ex = 1;
//             ey = 1;
//             this.direction = "right"; 
//         }

//         public Enemy(int ex, int ey)
//         {
//             this.ex = ex;
//             this.ey = ey;
//             direction = "right";
//         }

//         public void PrintEnemy()
//         {
//             Console.SetCursorPosition(ex, ey);
//             Console.Write("E");
//         }

//         public void RemoveEnemy()
//         {
//             Console.SetCursorPosition(ex, ey);
//             Console.Write(" ");
//         }

//         public void MoveEnemy()
//         {
//             direction = ChangeDirection();
//             RemoveEnemy();
//             if (direction == "right")
//             { 
//                 ex++;
//             }
//             else if (direction == "left")
//             { 
//                 ex--; 
//             }
//             PrintEnemy();
//         }

//         public string ChangeDirection()
//         {
//             string result = "right";
//             if (ex >= 54)
//             {
//                 RemoveEnemy();

//                 result = "left";
//                 ex = 5;

//             }
//             else if (ex < 4)
//             {
//                 result = "right";
//             }

//             return result;

//         }
//     }
// }



