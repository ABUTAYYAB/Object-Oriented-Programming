using EZInput;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task5Game.BL;

namespace Task5Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Bullet> bullets = new List<Bullet>();
            string path = "Maze.txt";
            char[,] Maze = new char[25,60];
            ReadMaze(path, Maze);
            Player player = new Player(20, 20, 'P', 100, 100);
            Enemy enemy = new Enemy(30, 10, 'E', 100,"right");
            Bullet B1 = new Bullet(22, 20, true, '-', 10);
            player.PrintPlayer(Maze);
            enemy.PrintEnemy(Maze);
            B1.PrintBullet(Maze);
            PrintMaze(Maze);

            while(true)
            {
                Console.Clear();
                enemy.MoveEnemy(Maze);

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    player.MovePlayerRight(Maze);
                }
                else if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    player.MovePlayerLeft(Maze);
                }
                else if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    player.MovePlayerUp(Maze);
                }
                else if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    player.MovePlayerDown(Maze);
                }
                Thread.Sleep(50);
                PrintMaze(Maze);
            }
        }


        static void ReadMaze(string path, char[,] Maze)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                int row = 0;
                while ((record = file.ReadLine()) != null)
                {
                    for (int i = 0; i < record.Length; i++)
                    {
                        Maze[row, i] = record[i];
                    }
                    row++;
                }
                file.Close();
            }
        }
        static void WriteMaze(string path, char[,] Maze)
        {
            StreamWriter file = new StreamWriter(path);

            int rows = Maze.GetLength(0);
            int columns = Maze.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    file.Write(Maze[i, j]);
                }
                file.WriteLine(); 
            }

            file.Close();
        }


        static void PrintMaze(char[,] Maze)
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    Console.Write(Maze[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
