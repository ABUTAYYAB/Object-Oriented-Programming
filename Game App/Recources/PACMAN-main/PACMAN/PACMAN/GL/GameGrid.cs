using System;
using System.Drawing;
using System.IO;

namespace PACMAN.GL
{
    internal class GameGrid
    {
        public GameCell[,] Cells;
        public int rows;
        public int columns;
        public GameGrid(string fileName, int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            Cells = new GameCell[rows, columns];
            LoadGrid(fileName);
        }
        private void LoadGrid(string fileName)
        {
            StreamReader fp = new StreamReader(fileName);
            string record;
            for (int row = 0; row < rows; row++)
            {
                record = fp.ReadLine();
                for (int col = 0; col < columns; col++)
                {
                    GameCell cell = new GameCell(row, col, this);
                    char displayCharacter = record[col];
                    GameObjectType objectType = GameObject.GetGameObjectType(displayCharacter);
                    Image displayImage = Game.GetGameObjectImage(displayCharacter);
                    GameObject obj = new GameObject(objectType, displayImage);
                    obj.currentCell = cell;
                    cell.SetGameObject(obj);
                    Cells[row, col] = cell;
                }
            }
            fp.Close();
        }
        public GameCell GetCell(int row, int col)
        {
            return Cells[row, col];
        }
        public static double Get_Distance(GameCell cell1, GameCell cell2)
        {
            return Math.Sqrt(Math.Pow(cell2.x - cell1.x, 2) + Math.Pow(cell2.y - cell1.y, 2));
        }
        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }

    }
}
