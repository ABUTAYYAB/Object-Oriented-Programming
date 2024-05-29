using System;

namespace Task6.BL
{
    internal class Player
    {
        public Player()
        {
            px = 5;
            py = 18;
        }
        public Player(int px, int py)
        {
            this.px = px;
            this.py = py;
        }

        public int px, py;

        public void PrintPlayer()
        {
            Console.SetCursorPosition(px, py);
            Console.Write("P");
        }
        public void RemovePlayer()
        {
            Console.SetCursorPosition(px, py);
            Console.Write(" ");
        }
        public void MovePlayerRight(char[,] maze)
        {
            if (maze[px+1, py] == ' ' )
            {
                Console.SetCursorPosition(px, py);
                RemovePlayer();
                px += 1;
                PrintPlayer();
            }
            
        }
        public void MovePlayerLeft(char[,] maze)
        {
            if (maze[px-1, py] == ' ' && px > 1)
            {
                Console.SetCursorPosition(px, py);
                RemovePlayer();
                px -= 1;
                PrintPlayer();
            }
            else
            {

            }
        }
        public void MovePlayerUp(char[,] maze)
        {
            if (maze[px, py -1] == ' ' && py > 1)
            {
                Console.SetCursorPosition(px, py);
                RemovePlayer();
                py -= 1;
                PrintPlayer();
            }
            else
            {

            }
        }
        public void MovePlayerDown(char[,] maze)
        {
            if (maze[px, py + 1] == ' ' && py < 22)
            {
                Console.SetCursorPosition(px, py);
                RemovePlayer();
                py += 1;
                PrintPlayer();
            }
            else
            {

            }
        }


    }
}
