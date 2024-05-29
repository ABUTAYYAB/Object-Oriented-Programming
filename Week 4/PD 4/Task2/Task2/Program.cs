using System;
using Task2.BL;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Alice = new Player();
            Player Bob = new Player();
            Stats Skill = new Stats();
            Alice = PlayerInput();
            Bob = PlayerInput();
            string result;

            while (Alice.hp > 0 && Bob.hp > 0)
            {
                Console.WriteLine(Alice.name+" will Attack");
                Skill = Skill_Input();
                Alice.LearnSkill(Skill);
                result = Alice.Attack(Bob);
                Console.WriteLine(result);


                Console.WriteLine(Bob.name + "Bob will Attack");
                Skill = Skill_Input();
                Bob.LearnSkill(Skill);
                result = Bob.Attack(Alice);
                Console.WriteLine(result);

                Console.ReadKey();
            }

            

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
    }
}
