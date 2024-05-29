// Task1
// main

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Task1.BL;

// namespace Task1
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Ship> list = new List<Ship>();
//             while (true)
//             {
//                 int option = menu();
//                 if (option == 1)
//                 {
//                     Addship(list);
//                 }
//                 else if (option == 2)
//                 {
//                     Viewshipposition(list);
//                 }
//                 else if (option == 3)
//                 {
//                     serialNo(list);
//                 }
//                 else if (option == 4)
//                 {
//                     changeposition(list);
//                 }
//                 else
//                 {
//                     continue;
//                 }
//             }
//         }

//         static int menu()
//         {
//             Console.Clear();
//             Console.WriteLine("Welcome to Ship Management System");
//             Console.WriteLine("1. Add Ship");
//             Console.WriteLine("2. View Ship Position");
//             Console.WriteLine("3. View Ship serial number");
//             Console.WriteLine("4. Change Ship Position");
//             Console.WriteLine("5. Exit");
//             Console.WriteLine("Enter your choice");
//             int choice = int.Parse(Console.ReadLine());
//             return choice;

//         }
//         static void Addship(List<Ship> list)
//         {
//             Ship ship = new Ship();
//             Console.Write("Enter Ship Number: ");
//             ship.srno = Console.ReadLine();
//             ship.latitude();
//             ship.longitude();
//             list.Add(ship);
//         }
//         static void Viewshipposition(List<Ship> list)
//         {
//             Console.Write("Enter ship's seriel number: ");
//             string str = Console.ReadLine();
//             for (int i = 0; i < list.Count; i++)
//             {
//                 if (list[i].srno == str)
//                 {
//                     list[i].viewshipposition();
//                 }
//             }
//         }
//         static void serialNo(List<Ship> list)
//         {

//             Console.WriteLine("Enter Ship Latitude:");
//             Console.Write("Enter latitude Degree: ");
//             int degreelatitude = int.Parse(Console.ReadLine());
//             Console.Write("Enter latitude Minute: ");
//             float minutelatitude = float.Parse(Console.ReadLine());
//             Console.Write("Enter latitude Direction: ");
//             char directionlatitude = char.Parse(Console.ReadLine());
//             string shiplatitude = $"{degreelatitude}\u00b0{minutelatitude}'{directionlatitude}";

//             Console.WriteLine("Enter Ship Longitude:");
//             Console.Write("Enter latitude Degree: ");
//             int degreelongitude = int.Parse(Console.ReadLine());
//             Console.Write("Enter latitude Minute: ");
//             float minutelongitude = float.Parse(Console.ReadLine());
//             Console.Write("Enter latitude Direction: ");
//             char directionlongitude = char.Parse(Console.ReadLine());

//             string shiplongitude = $"{degreelongitude}\u00b0{minutelongitude}'{directionlongitude}";
//             foreach (Ship ship in list)
//             {
//                 if (ship.checkcoordinates(shiplatitude, shiplongitude))
//                 {
//                     Console.WriteLine($"Ship's serial number is {ship.srno}");
//                     Console.ReadLine();
//                 }
//             }
//         }
//         static void changeposition(List<Ship> list)
//         {
//             Console.Write("Enter ship's seriel number: ");
//             string str = Console.ReadLine();
//             for (int i = 0; i < list.Count; i++)
//             {
//                 if (list[i].srno == str)
//                 {
//                     list[i].Changeposition();
//                 }
//             }
//         }
//     }
// }

// class 1 Ship

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task1.BL
// {
//     internal class Ship
//     {
//         public Ship()
//         {

//         }

//         public string srno;
//         Angle Latitudes = new Angle();
//         Angle Longitudes = new Angle();


//         public void latitude()
//         {
//             Console.WriteLine("Enter Ship's Latitude: ");
//             Console.Write("Enter degrees:");
//             Latitudes.degrees = int.Parse(Console.ReadLine());
//             Console.Write("Enter minutes:");
//             Latitudes.minutes = float.Parse(Console.ReadLine());
//             Console.Write("Enter direction:");
//             Latitudes.direction = char.Parse(Console.ReadLine());
//         }

//         public void longitude()
//         {
//             Console.WriteLine("Enter Ship's Longitude: ");
//             Console.Write("Enter degrees:");
//             Longitudes.degrees = int.Parse(Console.ReadLine());
//             Console.Write("Enter minutes:");
//             Longitudes.minutes = float.Parse(Console.ReadLine());
//             Console.Write("Enter direction:");
//             Longitudes.direction = char.Parse(Console.ReadLine());
//         }
//         public void viewshipposition()
//         {
//             Console.WriteLine($"Ship is at {Latitudes.viewangle()} and {Longitudes.viewangle()}");
//             Console.Read();
//         }
//         public bool checkcoordinates(string lati, string longi)
//         {
//             if (lati == Latitudes.viewangle() && longi == Longitudes.viewangle())
//             {
//                 return true;
//             }
//             return false;
//         }

//         public void Changeposition()
//         {
//             latitude();
//             longitude();
//         }
//     }
// }

// class 2 Angle

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task1.BL
// {
//     internal class Angle
//     {

//         public Angle() 
//         {

//         }
//         public int degrees;
//         public float minutes;
//         public char direction;
//         public string location;



//         public void Changeangle()
//         {
//             Console.Write("Enter degrees:");
//             degrees = int.Parse(Console.ReadLine());
//             Console.Write("Enter minutes:");
//             minutes = float.Parse(Console.ReadLine());
//             Console.Write("Enter direction:");
//             direction = char.Parse(Console.ReadLine());

//         }

//         public string viewangle()
//         {
//             location = $"{degrees}\u00b0{minutes}'{direction}";
//             return location;
//         }
//     }
// }


// Task2 
// main

// using System;
// using Task2.BL;

// namespace Task2
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Player Alice = new Player();
//             Player Bob = new Player();
//             Stats Skill = new Stats();
//             Alice = PlayerInput();
//             Bob = PlayerInput();
//             string result;

//             while (Alice.hp > 0 && Bob.hp > 0)
//             {
//                 Console.WriteLine(Alice.name+" will Attack");
//                 Skill = Skill_Input();
//                 Alice.LearnSkill(Skill);
//                 result = Alice.Attack(Bob);
//                 Console.WriteLine(result);


//                 Console.WriteLine(Bob.name + "Bob will Attack");
//                 Skill = Skill_Input();
//                 Bob.LearnSkill(Skill);
//                 result = Bob.Attack(Alice);
//                 Console.WriteLine(result);

//                 Console.ReadKey();
//             }

            

//         }
//         static Stats Skill_Input()
//         {
//             float damage;
//             Console.Write("Enter the Skill Name: ");
//             string SkillName = Console.ReadLine();
//             Console.Write("Enter the Damage: ");
//             damage = float.Parse(Console.ReadLine());
//             Console.Write("Enter the heal: ");
//             float heal = float.Parse(Console.ReadLine());
//             Console.Write("Enter the Cost: ");
//             float cost = float.Parse(Console.ReadLine());
//             Console.Write("Enter the penetrartion: ");
//             float penetration = float.Parse(Console.ReadLine());
//             Console.Write("Enter the description: ");
//             string description = Console.ReadLine();

//             Stats stats = new Stats(SkillName, damage, penetration, heal, cost, description);

//             return stats;
//         }
//         static Player PlayerInput()
//         {
//             Player player;
//             Console.Write("Enter the name of the player: ");
//             string name = Console.ReadLine();
//             Console.Write("Enter the armor: ");
//             float armor = float.Parse(Console.ReadLine());
//             Console.Write("Enter the health: ");
//             float health = float.Parse(Console.ReadLine());
//             Console.Write("Enter the energy: ");
//             float energy = float.Parse(Console.ReadLine());

//             player = new Player(name, health, energy, armor);

//             return player;
//         }
//     }
// }

// class 1 Player

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task2.BL
// {
//     internal class Player
//     {

//         public Player(string name, float health, float energy, float armor)
//         {
//             this.name = name;
//             hp = health;
//             this.energy = energy;
//             this.armor = armor;
//         }
//         public Player()
//         {

//         }

//         public float hp;
//         public float maxhp = 100;
//         public float energy;
//         public float maxenergy = 200;
//         public float armor;
//         public string name;
//         public Stats SkillState;
//         public List<Stats> SkillStatictics = new List<Stats>();

//         public void LearnSkill(Stats skillStats)
//         {
//             SkillState = skillStats;
//         }
//         public string Attack(Player target)
//         {
//             string result;

//             float effectiveArmor = Math.Max(0, target.armor - SkillState.penetration);

//             if (SkillState.Cost > energy)
//             {
//                 return $"{name} attempted to use {SkillState.SkillName}, but didn't have enough energy!";
//             }

//             energy -= SkillState.Cost;

//             float damage = SkillState.Damage * ((100 - effectiveArmor) / 100);
//             target.hp -= damage;

//             if (SkillState.heal > 0)
//             {
//                 hp += SkillState.heal;
//             }

//             result = $"{name} used {SkillState.SkillName}, {SkillState.description}, against {target.name}, doing {damage:F2} damage!";

//             if (SkillState.heal > 0)
//             {
//                 result += $" {name} healed for {SkillState.heal} health!";
//             }

//             if (target.hp <= 0)
//             {
//                 result += $" {target.name} died.";
//             }
//             else
//             {
//                 double targetHpPercentage = (target.hp / target.maxhp) * 100;
//                 result += $" {target.name} is at {targetHpPercentage:F2}% health.";
//             }

//             return result;
//         }
        
//     }
// }


// class 2 Stats

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task2.BL
// {
//     internal class Stats
//     {

//         public Stats(string SkillName, float Damage, float penetration, float heal, float Cost, string description)
//         {
//             this.SkillName = SkillName;
//             this.Damage = Damage;
//             this.penetration = penetration;
//             this.heal = heal;
//             this.Cost = Cost;
//             this.description = description;
//         }
//         public Stats()
//         {

//         }
//         public string SkillName;
//         public float Damage;
//         public string description;
//         public float penetration;
//         public float Cost;
//         public float heal;
//     }
// }


// Task 3 
// Main

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Task3.Bl;

// namespace Task3
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Player> PList = new List<Player>();
//             List<Stats> Slist = new List<Stats>();
//             Player player = new Player();
//             Stats stat = new Stats();


//             int attacker = 0;
//             int defender = 0;

//             while (true)
//             {
//                 Console.Clear();
//                 int opt = Menu();
//                 if (opt == 1)
//                 {
//                     player = Addplayer();
//                     PList.Add(player);
//                 }
//                 else if (opt == 2)
//                 {
//                     attacker = Findattacker(PList);
//                     stat = SkillStatistics(PList, attacker, Slist);
//                     Slist.Add(stat);
//                 }
//                 else if (opt == 3)
//                 {
//                     stat = AddSkill();
//                     Slist.Add(stat);
//                 }
//                 else if (opt == 4)
//                 {
//                     attacker = Findattacker(PList);
//                     Console.WriteLine("Now name of the player to be Attacked");
//                     defender = Findattacker(PList);
//                 }
//                 else if (opt == 5)
//                 {
//                     if (attacker != 0 && defender != 0)
//                     {
//                         PrintPlayerInfo(PList[attacker], PList[defender]);
//                     }
//                 }
//                 else if (opt == 6)
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
//             int num;
//             Console.WriteLine("1. Add Player");
//             Console.WriteLine("2. Learn Skill");
//             Console.WriteLine("3. Add Skill");
//             Console.WriteLine("4. Attack");
//             Console.WriteLine("5. PList Info");
//             Console.WriteLine("6. Exit");
//             num = int.Parse(Console.ReadLine());
//             return num;
//         }
//         static Player PlayerInput()
//         {
//             Player player;
//             Console.Write("Enter the name of the player: ");
//             string name = Console.ReadLine();
//             Console.Write("Enter the armor: ");
//             float armor = float.Parse(Console.ReadLine());
//             Console.Write("Enter the health: ");
//             float health = float.Parse(Console.ReadLine());
//             Console.Write("Enter the energy: ");
//             float energy = float.Parse(Console.ReadLine());

//             player = new Player(name, health, energy, armor);

//             return player;
//         }
//         static Player Addplayer()
//         {
//             Player Alice = new Player();
//             Stats Skill = new Stats();
//             Alice = PlayerInput();
//             return Alice;
//         }
//         static Stats Skill_Input()
//         {
//             float damage;
//             Console.Write("Enter the Skill Name: ");
//             string SkillName = Console.ReadLine();
//             Console.Write("Enter the Damage: ");
//             damage = float.Parse(Console.ReadLine());
//             Console.Write("Enter the heal: ");
//             float heal = float.Parse(Console.ReadLine());
//             Console.Write("Enter the Cost: ");
//             float cost = float.Parse(Console.ReadLine());
//             Console.Write("Enter the penetrartion: ");
//             float penetration = float.Parse(Console.ReadLine());
//             Console.Write("Enter the description: ");
//             string description = Console.ReadLine();

//             Stats stats = new Stats(SkillName, damage, penetration, heal, cost, description);

//             return stats;
//         }
//         static Stats AddSkill()
//         {
//             Stats Skill = new Stats();
//             Skill = Skill_Input();
//             return Skill;
//         }
//         static int Findattacker(List<Player> PList)
//         {
//             int num;
//             for (int i = 0; i < PList.Count; i++)
//             {
//                 Console.WriteLine($"{i}\t{PList[i].name}");
//             }
//             Console.WriteLine("Enter the index of the Person you want to add a skill");
//             num = int.Parse(Console.ReadLine());
//             return num;
//         }
//         static Stats SkillStatistics(List<Player> PList, int attacker, List<Stats> Slist)
//         {
//             Player player = PList[attacker];
//             Stats Skill = new Stats();
//             Skill = Skill_Input();
//             player.SkillStatictics.Add(Skill);
//             PList[attacker].LearnSkill(Skill);
//             return Skill;
//         }
//         static void PrintPlayerInfo(Player player1, Player player2)
//         {
//             Console.WriteLine($"The Name and Health of Both the PList is Given below: ");
//             Console.WriteLine($"{player1.name}\t{player1.hp}\t{player1.armor}\t{player1.energy}");
//             Console.WriteLine($"{player2.name}\t{player2.hp}\t{player2.armor}\t{player2.energy}");
//         }

//     }
// }


// class 1
// Player
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task3.Bl
// {
//     internal class Player
//     {
//         public Player(string name, float health, float energy, float armor)
//         {
//             this.name = name;
//             hp = health;
//             this.energy = energy;
//             this.armor = armor;
//         }
//         public Player()
//         {

//         }

//         public float hp;
//         public float maxhp = 100;
//         public float energy;
//         public float maxenergy = 200;
//         public float armor;
//         public string name;
//         public Stats SkillState;
//         public List<Stats> SkillStatictics = new List<Stats>();

//         public void LearnSkill(Stats skillStats)
//         {
//             SkillState = skillStats;
//         }
//         public string Attack(Player target)
//         {
//             string result;

//             float effectiveArmor = Math.Max(0, target.armor - SkillState.penetration);

//             if (SkillState.Cost > energy)
//             {
//                 return $"{name} attempted to use {SkillState.SkillName}, but didn't have enough energy!";
//             }

//             energy -= SkillState.Cost;

//             float damage = SkillState.Damage * ((100 - effectiveArmor) / 100);
//             target.hp -= damage;

//             if (SkillState.heal > 0)
//             {
//                 hp += SkillState.heal;
//             }

//             result = $"{name} used {SkillState.SkillName}, {SkillState.description}, against {target.name}, doing {damage:F2} damage!";

//             if (SkillState.heal > 0)
//             {
//                 result += $" {name} healed for {SkillState.heal} health!";
//             }

//             if (target.hp <= 0)
//             {
//                 result += $" {target.name} died.";
//             }
//             else
//             {
//                 double targetHpPercentage = (target.hp / target.maxhp) * 100;
//                 result += $" {target.name} is at {targetHpPercentage:F2}% health.";
//             }

//             return result;
//         }

//     }
// }
 
//  class 2 Stats

//  namespace Task3.Bl
// {
//     internal class Stats
//     {
//         public Stats(string SkillName, float Damage, float penetration, float heal, float Cost, string description)
//         {
//             this.SkillName = SkillName;
//             this.Damage = Damage;
//             this.penetration = penetration;
//             this.heal = heal;
//             this.Cost = Cost;
//             this.description = description;
//         }
//         public Stats()
//         {

//         }
//         public string SkillName;
//         public float Damage;
//         public string description;
//         public float penetration;
//         public float Cost;
//         public float heal;
//     }
// }


// Task 4 

// Main

// using System;
// using System.Collections.Generic;
// using System.IO;
// using Task4App.BL;

// namespace Task4App
// {
//     internal class Program
//     {
//         static List<User> UserList = new List<User>();
//         static List<Product> ProductList = new List<Product>();

//         static void Main(string[] args)
//         {
//             string path = "usercredentials.txt";
//             string pathproduct = "products.txt";
//             bool getDetails = AccessDetailsOfUser(path);
//             bool getDetailsp = AccessDetailsOfProducts(pathproduct);

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
//                         while (true)
//                         {
//                             Console.WriteLine("You Are An Employee: ");
//                             string EmpOpt = EmployeeMenu();
//                             if (EmpOpt == "1")
//                             {
//                                 bool check = ViewProducts();
//                                 if (check)
//                                 {
//                                     Successfull();
//                                 }
//                                 else
//                                 {
//                                     Unsuccessfull();
//                                 }
//                                 continue;

//                             }
//                             else if (EmpOpt == "2")
//                             {
//                                 string name = EnterName();
//                                 double price = EnterPrice();
//                                 double quant = EnterQuantity();

//                                 Product p = new Product(name, price, quant);
//                                 ProductList.Add(p);
//                                 bool storeData = StoreDetailsOfProducts(pathproduct);

//                                 Successfull();

//                                 continue;
//                             }
//                             else if (EmpOpt == "3")
//                             {
//                                 string name = EnterName();
//                                 bool check = RemoveProduct(name);
//                                 if (check)
//                                 {
//                                     bool storeData = StoreDetailsOfProducts(pathproduct);
//                                     Successfull();
//                                 }
//                                 else
//                                 {
//                                     Unsuccessfull();
//                                 }
//                                 continue;


//                             }
//                             else if (EmpOpt == "3")
//                             {
//                                 string name = EnterName();
//                                 double price = EnterPrice();
//                                 bool check = UpdatePrice(name, price);
//                                 if (check)
//                                 {
//                                     Successfull();
//                                     bool storeData = StoreDetailsOfProducts(pathproduct);

//                                 }
//                                 else
//                                 {
//                                     Unsuccessfull();
//                                 }
//                                 continue;

//                             }
//                             else if (EmpOpt == "4")
//                             {
//                                 string name = EnterName();
//                                 double quant = EnterQuantity();
//                                 bool check = UpdateQuantity(name, quant);
//                                 if (check)
//                                 {
//                                     Successfull();
//                                     bool storeData = StoreDetailsOfProducts(pathproduct);

//                                 }
//                                 else
//                                 {
//                                     Unsuccessfull();
//                                 }
//                                 continue;

//                             }
//                             else if (EmpOpt == "5")
//                             {
//                                 break;
//                             }
//                             else
//                             {
//                                 continue;
//                             }


//                         }


//                     }
//                     else if (role == "Customer")
//                     {
//                         while (true)
//                         {
//                             string CusOpt = CustomerMenu();
//                             if (CusOpt == "1")
//                             {
//                                 bool check = ViewProducts();
//                                 if (check)
//                                 {
//                                     Successfull();
//                                 }
//                                 else
//                                 {
//                                     Unsuccessfull();
//                                 }
//                                 continue;
//                             }
//                             else if (CusOpt == "2")
//                             {

//                                 double quant = EnterQuantity();
//                                 string name = EnterName();

//                                 bool check = BuyProduct(name,quant);
//                                 if (check)
//                                 {
//                                     Successfull();
//                                 }
//                                 else
//                                 {
//                                     Unsuccessfull();
//                                 }
//                                 continue;


//                             }
//                             else if (CusOpt == "2")
//                             {
//                                 break;
//                             }
//                             else
//                             {
//                                 continue;
//                             }


//                         }

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
//                 UserList.Add(user);
//                 result = true;
//             }
//             else if (role == "a")
//             {
//                 role = "Admin";
//                 User user = new User(id, password, role);
//                 UserList.Add(user);
//                 result = true;
//             }
//             else if (role == "e")
//             {
//                 role = "Employee";
//                 User user = new User(id, password, role);
//                 UserList.Add(user);
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

//             for (int i = 0; i < UserList.Count; i++)
//             {
//                 if (id == UserList[i].id && password == UserList[i].password)
//                 {
//                     result = UserList[i].role;
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
//                     UserList.Add(user);

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

//             for (int i = 0; i < UserList.Count; i++)
//             {
//                 User user = UserList[i];
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



//             string option;
//             Console.WriteLine("                      ************************************************************ Admin Menu ************************************************************");
//             Console.WriteLine();
//             Console.WriteLine("1. Add New Employee");
//             Console.WriteLine("2. Remove Employee");
//             Console.WriteLine("3. Update Password");
//             Console.WriteLine("4. Logout");
//             Console.Write("Enter Your Option Here: ");
//             option = Console.ReadLine();


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

//             for (int i = 0; i < UserList.Count; i++)
//             {
//                 if (UserList[i].id == id)
//                 {
//                     UserList.RemoveAt(i);
//                     check = true;
//                     return check;
//                 }
//             }
//             return check;
//         }
//         static bool updatePassword(string id, string newpass)
//         {
//             bool check = false;

//             for (int i = 0; i < UserList.Count; i++)
//             {
//                 if (UserList[i].id == id)
//                 {
//                     UserList[i].password = newpass;
//                     check = true;
//                     return check;
//                 }
//             }

//             return check;
//         }
//         static string EmployeeMenu()
//         {
//             Console.Clear();
//             string option;
//             Console.WriteLine("                           ******************************************************** Employee Menu ********************************************************");
//             Console.WriteLine();
//             Console.WriteLine("1.View products");
//             Console.WriteLine("2.Add products");
//             Console.WriteLine("3.Remove products");
//             Console.WriteLine("4.Update Price");
//             Console.WriteLine("5.Update Quantity");
//             Console.WriteLine("6.Logout");
//             Console.Write("Enter Your Option Here: ");

//             option = Console.ReadLine();

//             return option;
//         }
//         static string EnterName()
//         {
//             Console.Write("Enter the Name of the product: ");
//             string name = Console.ReadLine();
//             return name;
//         }
//         static double EnterPrice()
//         {
//             Console.Write("Enter the Price of the product: ");
//             double price = double.Parse(Console.ReadLine());
//             return price;
//         }
//         static double EnterQuantity()
//         {
//             Console.Write("Enter the Quantity of the product: ");
//             double quantity = double.Parse(Console.ReadLine());
//             return quantity;
//         }
//         static bool RemoveProduct(string name)
//         {
//             bool Result = false;
//             for (int i = 0; i < ProductList.Count; i++)
//             {
//                 if (name == ProductList[i].name)
//                 {
//                     ProductList.RemoveAt(i);
//                     Result = true;
//                 }
//             }
//             return Result;
//         }
//         static bool UpdatePrice(string name, double price)
//         {
//             bool Result = false;
//             for (int i = 0; i < ProductList.Count; i++)
//             {
//                 if (name == ProductList[i].name)
//                 {
//                     ProductList[i].UpdatePrice(price);
//                     Result = true;
//                 }
//             }
//             return Result;
//         }
//         static bool UpdateQuantity(string name, double quantity)
//         {
//             bool Result = false;
//             for (int i = 0; i < ProductList.Count; i++)
//             {
//                 if (name == ProductList[i].name)
//                 {
//                     ProductList[i].UpdateQuantity(quantity);
//                     Result = true;
//                 }
//             }
//             return Result;
//         }
//         static bool ViewProducts()
//         {
//             bool Result = true;
//             for (int i = 0; i < ProductList.Count; i++)
//             {
//                 Console.WriteLine($"Name is " + ProductList[i].ViewName() + "\nPrice is " + ProductList[i].ViewPrice() + "\nQuantity is " + ProductList[i].ViewQuantity());
//                 Console.WriteLine("\n");
//             }

//             return Result;
//         }
//         static bool StoreDetailsOfProducts(string pathproducts)
//         {
//             bool check = false;
//             StreamWriter file = new StreamWriter(pathproducts, append: false);

//             for (int i = 0; i < ProductList.Count; i++)
//             {
//                 User user = UserList[i];
//                 Product p = ProductList[i];
//                 file.WriteLine($"{p.name}|{p.price}|{p.quantity}|");
//             }
//             file.Flush();
//             file.Close();
//             check = true;

//             return check;
//         }
//         static bool AccessDetailsOfProducts(string pathproduct)
//         {
//             bool check = false;

//             if (File.Exists(pathproduct))
//             {
//                 StreamReader file = new StreamReader(pathproduct);

//                 while (!file.EndOfStream)
//                 {
//                     string line = file.ReadLine();

//                     string name = SeperatedText(line, 1);
//                     double price = double.Parse(SeperatedText(line, 2));
//                     double Quant = double.Parse(SeperatedText(line, 3));
//                     Product p = new Product(name, price, Quant);
//                     ProductList.Add(p);
//                 }
//                 check = true;

//                 file.Close();
//             }

//             return check;
//         }
//         static string CustomerMenu()
//         {
//             Console.Clear();
//             string option;
//             Console.WriteLine("                     ************************************************************** Customer Menu **************************************************************");
//             Console.WriteLine();
//             Console.WriteLine("1.View products");
//             Console.WriteLine("2.Buy Product");
//             Console.WriteLine("3. Logout");
//             Console.Write("Enter Your Option Here:");
//             option = Console.ReadLine();
//             return option;
//         }
//         static bool BuyProduct(string name, double quant)
//         {

//             bool Result = false;
//             for (int i = 0; i < ProductList.Count; i++)
//             {
//                 if (name == ProductList[i].name)
//                 {
//                     ProductList[i].BuyItem(quant);
//                     Result = true;
//                 }
//             }
//             return Result;

//         }


//     }
    
// }


// class 1 User
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task4App.BL
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


// class 2 Product
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task4App.BL
// {
//     internal class Product
//     {
//         public Product(string name,double price,double quantity) 
//         {
//             this.name = name;
//             this.price = price;
//             this.quantity = quantity;
//         }

//         public string name;
//         public double price,quantity;
        
//         public void UpdateQuantity(double no)
//         {
//             this.quantity += no;
//         }
//         public void UpdatePrice(double no)
//         {
//             this.quantity = no;
//         }
//         public bool BuyItem(double quan) 
//         {
//             bool result = false;
//             if(quan <= this.quantity)
//             {
//                 this.quantity -= quan;
//                 result = true;
//             }
//             return result;
//         }
//         public string ViewName()
//         {
//             return this.name;
//         }
//         public double ViewPrice()
//         {
//             return this.price;
//         }
//         public double ViewQuantity()
//         {
//             return this.quantity;
//         }

//     }
// }

// Task 5

// main
// using EZInput;
// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Text;
// using System.Threading;
// using System.Threading.Tasks;
// using Task5Game.BL;

// namespace Task5Game
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {

//             List<Bullet> bullets = new List<Bullet>();
//             string path = "Maze.txt";
//             char[,] Maze = new char[25,60];
//             ReadMaze(path, Maze);
//             Player player = new Player(20, 20, 'P', 100, 100);
//             Enemy enemy = new Enemy(30, 10, 'E', 100,"right");
//             Bullet B1 = new Bullet(22, 20, true, '-', 10);
//             player.PrintPlayer(Maze);
//             enemy.PrintEnemy(Maze);
//             B1.PrintBullet(Maze);
//             PrintMaze(Maze);

//             while(true)
//             {
//                 Console.Clear();
//                 enemy.MoveEnemy(Maze);

//                 if (Keyboard.IsKeyPressed(Key.RightArrow))
//                 {
//                     player.MovePlayerRight(Maze);
//                 }
//                 else if (Keyboard.IsKeyPressed(Key.LeftArrow))
//                 {
//                     player.MovePlayerLeft(Maze);
//                 }
//                 else if (Keyboard.IsKeyPressed(Key.UpArrow))
//                 {
//                     player.MovePlayerUp(Maze);
//                 }
//                 else if (Keyboard.IsKeyPressed(Key.DownArrow))
//                 {
//                     player.MovePlayerDown(Maze);
//                 }
//                 Thread.Sleep(50);
//                 PrintMaze(Maze);
//             }
//         }


//         static void ReadMaze(string path, char[,] Maze)
//         {
//             if (File.Exists(path))
//             {
//                 StreamReader file = new StreamReader(path);
//                 string record;
//                 int row = 0;
//                 while ((record = file.ReadLine()) != null)
//                 {
//                     for (int i = 0; i < record.Length; i++)
//                     {
//                         Maze[row, i] = record[i];
//                     }
//                     row++;
//                 }
//                 file.Close();
//             }
//         }
//         static void WriteMaze(string path, char[,] Maze)
//         {
//             StreamWriter file = new StreamWriter(path);

//             int rows = Maze.GetLength(0);
//             int columns = Maze.GetLength(1);

//             for (int i = 0; i < rows; i++)
//             {
//                 for (int j = 0; j < columns; j++)
//                 {
//                     file.Write(Maze[i, j]);
//                 }
//                 file.WriteLine(); 
//             }

//             file.Close();
//         }


//         static void PrintMaze(char[,] Maze)
//         {
//             for (int i = 0; i < 25; i++)
//             {
//                 for (int j = 0; j < 60; j++)
//                 {
//                     Console.Write(Maze[i, j]);
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// class 1 Player
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task5Game.BL
// {
//     internal class Player
//     {
//         public int Px;
//         public int Py;
//         public char character;
//         public int health;
//         public int score;
//         public Player(int Px, int Py, char character, int health, int score)
//         {
//             this.Px = Px;
//             this.Py = Py;
//             this.character = character;
//             this.health = health;
//             this.score = score;
//         }

//         public void PrintPlayer(char[,] Maze)
//         {
//             Maze[Py, Px] = character;
//         }

//         public void ErasePlayer(char[,] Maze)
//         {
//             Maze[Py, Px] = ' ';
//         }

//         public void MovePlayerRight(char[,] Maze)
//         {
//             if (Maze[Px + 1, Py] == ' ')
//             {
//                 Console.SetCursorPosition(Px, Py);
//                 ErasePlayer(Maze);
//                 Px += 1;
//                 PrintPlayer(Maze);
//             }

//         }
//         public void MovePlayerLeft(char[,] Maze)
//         {
//             if (Maze[Px - 1, Py] == ' ')
//             {
//                 Console.SetCursorPosition(Px, Py);
//                 ErasePlayer(Maze);

//                 Px -= 1;
//                 PrintPlayer(Maze);

//             }
//             else
//             {

//             }
//         }
//         public void MovePlayerUp(char[,] Maze)
//         {
//             if (Maze[Px, Py - 1] == ' ' && Py > 1)
//             {
//                 Console.SetCursorPosition(Px, Py);
//                 ErasePlayer(Maze);
//                 Py -= 1;
//                 PrintPlayer(Maze);
//             }
            
//         }
//         public void MovePlayerDown(char[,] Maze)
//         {
//             if (Maze[Px, Py + 1] == ' ' && Py < 22)
//             {
//                 Console.SetCursorPosition(Px, Py);
//                 ErasePlayer(Maze);

//                 Py += 1;
//                 PrintPlayer(Maze);
//             }
            
//         }
        
//     }
// }

// class 2 enemy
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task5Game.BL
// {
//     internal class Enemy
//     {
//         public Enemy(int Ex, int Ey, char character, int health,string direction)
//         {
//             this.Ex = Ex;
//             this.Ey = Ey;
//             this.character = character;
//             this.health = health;
//             this.direction = direction;
//         }

//         public int Ex;
//         public int Ey;
//         public char character;
//         public int health;
//         public string direction;

//         public void PrintEnemy(char[,] Maze)
//         {
//             Maze[Ey, Ex] = character;
//         }

//         public void EraseEnemy(char[,] Maze)
//         {
//             Maze[Ey, Ex] = ' ';
//         }

//         public void MoveHorizontically() { }

//         public void MoveVertically() { }

//         public void MoveEnemy(char[,] Maze)
//         {
//             direction = ChangeDirection();
//             EraseEnemy(Maze);
//             if (direction == "right")
//             {
//                 Ex++;
//             }
//             else if (direction == "left")
//             {
//                 Ex--;
//             }
//             PrintEnemy(Maze);
//         }

//         public string ChangeDirection()
//         {
//             string result = "right";
//             if (Ex >= 54)
//             {

//                 result = "left";

//             }
//             else if (Ex < 4)
//             {
//                 result = "right";
//             }

//             return result;

//         }
//     }
// }

// class 3 Bullet
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Task5Game.BL
// {
//     internal class Bullet
//     {
//         public int Bx;
//         public int By;
//         public bool isActive;
//         public char character;
//         public int damage;

//         public Bullet(int Bx, int By, bool isActive, char character, int damage)
//         {
//             this.Bx = Bx;
//             this.By = By;
//             this.isActive = isActive;
//             this.character = character;
//             this.damage = damage;
//         }

//         public void PrintBullet(char[,] Maze)
//         {
//             Maze[By, Bx] = character;
//         }

//         public void EraseBullet(char[,] Maze)
//         {
//             Maze[By, Bx] = ' ';
//         }

//         public void GenerateBullet(char[,] Maze) { }
//     }
// }
