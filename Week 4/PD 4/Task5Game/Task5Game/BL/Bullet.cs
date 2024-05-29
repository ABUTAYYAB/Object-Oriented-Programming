using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Game.BL
{
    internal class Bullet
    {
        public int Bx;
        public int By;
        public bool isActive;
        public char character;
        public int damage;

        public Bullet(int Bx, int By, bool isActive, char character, int damage)
        {
            this.Bx = Bx;
            this.By = By;
            this.isActive = isActive;
            this.character = character;
            this.damage = damage;
        }

        public void PrintBullet(char[,] Maze)
        {
            Maze[By, Bx] = character;
        }

        public void EraseBullet(char[,] Maze)
        {
            Maze[By, Bx] = ' ';
        }

        public void GenerateBullet(char[,] Maze) { }
    }
}
