using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Game.BL
{
    internal class Player
    {
        public int Px;
        public int Py;
        public char character;
        public int health;
        public int score;
        public Player(int Px, int Py, char character, int health, int score)
        {
            this.Px = Px;
            this.Py = Py;
            this.character = character;
            this.health = health;
            this.score = score;
        }

        public void PrintPlayer(char[,] Maze)
        {
            Maze[Py, Px] = character;
        }

        public void ErasePlayer(char[,] Maze)
        {
            Maze[Py, Px] = ' ';
        }

        public void MovePlayerRight(char[,] Maze)
        {
            if (Maze[Px + 1, Py] == ' ')
            {
                Console.SetCursorPosition(Px, Py);
                ErasePlayer(Maze);
                Px += 1;
                PrintPlayer(Maze);
            }

        }
        public void MovePlayerLeft(char[,] Maze)
        {
            if (Maze[Px - 1, Py] == ' ')
            {
                Console.SetCursorPosition(Px, Py);
                ErasePlayer(Maze);

                Px -= 1;
                PrintPlayer(Maze);

            }
            else
            {

            }
        }
        public void MovePlayerUp(char[,] Maze)
        {
            if (Maze[Px, Py - 1] == ' ' && Py > 1)
            {
                Console.SetCursorPosition(Px, Py);
                ErasePlayer(Maze);
                Py -= 1;
                PrintPlayer(Maze);
            }
            
        }
        public void MovePlayerDown(char[,] Maze)
        {
            if (Maze[Px, Py + 1] == ' ' && Py < 22)
            {
                Console.SetCursorPosition(Px, Py);
                ErasePlayer(Maze);

                Py += 1;
                PrintPlayer(Maze);
            }
            
        }
        
    }
}
