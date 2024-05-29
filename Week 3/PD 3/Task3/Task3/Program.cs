using System;
using Task3.BL;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shiritori game = new Shiritori();
            while (true)
            {
                Console.Write("Enter a word:");
                string input = Console.ReadLine();
                string result = game.Play(input);
                if (result == "gameover")
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine("Wanna Play again if  yes press y");
                    string option = Console.ReadLine();
                    if (option == "y")
                    {
                        string restart = game.Restart();
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                Console.WriteLine("You Just Entered: "+result);
                Console.ReadLine();
            }
        }
    }
}
