namespace FACMAN
{
    internal class GameGrid
    {
        public GameCell[,] Cells;
        public int Rows;
        public int Columns;
        public GameGrid(string fileName,int Rows,int Columns) 
        {
            this.Rows = Rows;
            this.Columns = Columns;
            Cells = new GameCell[Rows, Columns];
            LoadGrid(fileName);
        }
        private void LoadGrid(string fileName)
        {
            StreamReader fp = new StreamReader("maze.txt");
            string record;
            for (int row = 0; row < Rows; row++)
            {
                record = fp.ReadLine();
                for (int col = 0; col < Columns; col++)
                {
                    GameCell cell = new GameCell(row, col, this);
                    GameObjectType objectType = GameObject.GetGameObjectType(record[col]);
                    GameObject obj = new GameObject(objectType, record[col]);
                    obj.CurrentCell = cell;
                    cell.CurrentGameObject = obj;
                    Cells[row, col] = cell;
                }
            }
        }
        public GameCell GetCell(int row, int col)
        {
            return Cells[row, col];
        }
        public static double Get_Distance(GameCell cell1, GameCell cell2)
        {
            return Math.Sqrt(Math.Pow(cell2.X - cell1.X, 2) + Math.Pow(cell2.Y - cell1.Y, 2));
        }
    }
}
