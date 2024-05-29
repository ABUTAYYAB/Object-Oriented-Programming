using System;

namespace Task6.BL
{
    internal class Enemy
    {
        public int ex, ey;
        public string direction; 

        public Enemy()
        {
            ex = 1;
            ey = 1;
            this.direction = "right"; 
        }

        public Enemy(int ex, int ey)
        {
            this.ex = ex;
            this.ey = ey;
            direction = "right";
        }

        public void PrintEnemy()
        {
            Console.SetCursorPosition(ex, ey);
            Console.Write("E");
        }

        public void RemoveEnemy()
        {
            Console.SetCursorPosition(ex, ey);
            Console.Write(" ");
        }

        public void MoveEnemy()
        {
            direction = ChangeDirection();
            RemoveEnemy();
            if (direction == "right")
            { 
                ex++;
            }
            else if (direction == "left")
            { 
                ex--; 
            }
            PrintEnemy();
        }

        public string ChangeDirection()
        {
            string result = "right";
            if (ex >= 54)
            {
                RemoveEnemy();

                result = "left";
                ex = 5;

            }
            else if (ex < 4)
            {
                result = "right";
            }

            return result;

        }
    }
}

