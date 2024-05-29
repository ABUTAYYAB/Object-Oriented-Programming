using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Bl;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> PList = new List<Player>();
            List<Stats> Slist = new List<Stats>();
            Player player = new Player();
            Stats stat = new Stats();


            int attacker = 0;
            int defender = 0;

            while (true)
            {
                Console.Clear();
                int opt = Menu();
                if (opt == 1)
                {
                    player = Addplayer();
                    PList.Add(player);
                }
                else if (opt == 2)
                {
                    attacker = Findattacker(PList);
                    stat = SkillStatistics(PList, attacker, Slist);
                    Slist.Add(stat);
                }
                else if (opt == 3)
                {
                    stat = AddSkill();
                    Slist.Add(stat);
                }
                else if (opt == 4)
                {
                    attacker = Findattacker(PList);
                    Console.WriteLine("Now name of the player to be Attacked");
                    defender = Findattacker(PList);
                }
                else if (opt == 5)
                {
                    if (attacker != 0 && defender != 0)
                    {
                        PrintPlayerInfo(PList[attacker], PList[defender]);
                    }
                }
                else if (opt == 6)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        static int Menu()
        {
            int num;
            Console.WriteLine("1. Add Player");
            Console.WriteLine("2. Learn Skill");
            Console.WriteLine("3. Add Skill");
            Console.WriteLine("4. Attack");
            Console.WriteLine("5. PList Info");
            Console.WriteLine("6. Exit");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static Player PlayerInput()
        {
            Player player;
            Console.Write("Enter the name of the player: ");
            string name = Console.ReadLine();
            Console.Write("Enter the armor: ");
            float armor = float.Parse(Console.ReadLine());
            Console.Write("Enter the health: ");
            float health = float.Parse(Console.ReadLine());
            Console.Write("Enter the energy: ");
            float energy = float.Parse(Console.ReadLine());

            player = new Player(name, health, energy, armor);

            return player;
        }
        static Player Addplayer()
        {
            Player Alice = new Player();
            Stats Skill = new Stats();
            Alice = PlayerInput();
            return Alice;
        }
        static Stats Skill_Input()
        {
            float damage;
            Console.Write("Enter the Skill Name: ");
            string SkillName = Console.ReadLine();
            Console.Write("Enter the Damage: ");
            damage = float.Parse(Console.ReadLine());
            Console.Write("Enter the heal: ");
            float heal = float.Parse(Console.ReadLine());
            Console.Write("Enter the Cost: ");
            float cost = float.Parse(Console.ReadLine());
            Console.Write("Enter the penetrartion: ");
            float penetration = float.Parse(Console.ReadLine());
            Console.Write("Enter the description: ");
            string description = Console.ReadLine();

            Stats stats = new Stats(SkillName, damage, penetration, heal, cost, description);

            return stats;
        }
        static Stats AddSkill()
        {
            Stats Skill = new Stats();
            Skill = Skill_Input();
            return Skill;
        }
        static int Findattacker(List<Player> PList)
        {
            int num;
            for (int i = 0; i < PList.Count; i++)
            {
                Console.WriteLine($"{i}\t{PList[i].name}");
            }
            Console.WriteLine("Enter the index of the Person you want to add a skill");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static Stats SkillStatistics(List<Player> PList, int attacker, List<Stats> Slist)
        {
            Player player = PList[attacker];
            Stats Skill = new Stats();
            Skill = Skill_Input();
            player.SkillStatictics.Add(Skill);
            PList[attacker].LearnSkill(Skill);
            return Skill;
        }
        static void PrintPlayerInfo(Player player1, Player player2)
        {
            Console.WriteLine($"The Name and Health of Both the PList is Given below: ");
            Console.WriteLine($"{player1.name}\t{player1.hp}\t{player1.armor}\t{player1.energy}");
            Console.WriteLine($"{player2.name}\t{player2.hp}\t{player2.armor}\t{player2.energy}");
        }

    }
}
