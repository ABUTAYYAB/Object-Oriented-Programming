using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Game.BL
{
    internal class Enemy
    {
        public Enemy(int Ex, int Ey, char character, int health,string direction)
        {
            this.Ex = Ex;
            this.Ey = Ey;
            this.character = character;
            this.health = health;
            this.direction = direction;
        }

        public int Ex;
        public int Ey;
        public char character;
        public int health;
        public string direction;

        public void PrintEnemy(char[,] Maze)
        {
            Maze[Ey, Ex] = character;
        }

        public void EraseEnemy(char[,] Maze)
        {
            Maze[Ey, Ex] = ' ';
        }

        public void MoveHorizontically() { }

        public void MoveVertically() { }

        public void MoveEnemy(char[,] Maze)
        {
            direction = ChangeDirection();
            EraseEnemy(Maze);
            if (direction == "right")
            {
                Ex++;
            }
            else if (direction == "left")
            {
                Ex--;
            }
            PrintEnemy(Maze);
        }

        public string ChangeDirection()
        {
            string result = "right";
            if (Ex >= 54)
            {

                result = "left";

            }
            else if (Ex < 4)
            {
                result = "right";
            }

            return result;

        }
    }
}
