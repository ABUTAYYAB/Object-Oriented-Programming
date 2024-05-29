using EZInput;

namespace FACMAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 71);
            GameCell start = new GameCell(12, 22, grid);
            PacmanPlayer pacman = new PacmanPlayer('P', start);

            PrintMaze(grid);

            HorizontalGhost ghostH = new HorizontalGhost(GameObjectType.ENEMY, 'H', GameDirection.RIGHT);
            GameCell nextCellH = new GameCell(22, 7, grid);
            ghostH.CurrentCell = nextCellH;
            nextCellH.CurrentGameObject = ghostH;

            VerticalGhost ghostV = new VerticalGhost(GameObjectType.ENEMY, 'V', GameDirection.DOWN);
            GameCell nextCellV = new GameCell(3, 51, grid);
            ghostV.CurrentCell = nextCellV;
            nextCellV.CurrentGameObject = ghostV;

            RandomGhost ghostR = new RandomGhost(GameObjectType.ENEMY, 'R');
            GameCell nextCellR = new GameCell(6, 51, grid);
            ghostR.CurrentCell = nextCellR;
            nextCellR.CurrentGameObject = ghostR;

            SmartGhost ghostS = new SmartGhost(GameObjectType.ENEMY, 'S', pacman);
            GameCell nextCellS = new GameCell(1, 20, grid);
            ghostS.CurrentCell = nextCellS;
            nextCellS.CurrentGameObject = ghostS;

            PrintGameObject(pacman);
            PrintGameObject(ghostH);
            PrintGameObject(ghostV);
            PrintGameObject(ghostR);
            PrintGameObject(ghostS);

            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    MoveGameObject(pacman, GameDirection.UP);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    MoveGameObject(pacman, GameDirection.DOWN);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    MoveGameObject(pacman, GameDirection.RIGHT);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    MoveGameObject(pacman, GameDirection.LEFT);
                }

                Move_Ghost(ghostH);
                Move_Ghost(ghostV);
                Move_Ghost(ghostR);
                Move_Ghost(ghostS);
            }
        }
        public static void ClearGameCellContent(GameCell gameCell, GameObject newGameObject)
        {
            gameCell.CurrentGameObject = newGameObject;
            Console.SetCursorPosition(gameCell.Y, gameCell.X);
            Console.Write(newGameObject.DisplayCharacter);

        }
        public static void PrintGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.CurrentCell.Y, gameObject.CurrentCell.X);
            Console.Write(gameObject.DisplayCharacter);

        }
        public static void MoveGameObject(GameObject gameObject, GameDirection direction)
        {
            GameCell nextCell = gameObject.CurrentCell.NextCell(direction);
            if (nextCell != null && nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
            {
                GameObject newGO = new GameObject(GameObjectType.NONE, ' ');
                GameCell currentCell = gameObject.CurrentCell;
                ClearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                PrintGameObject(gameObject);
            }
        }
        public static void PrintMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                int abc = 0;
                for (int y = 0; y < grid.Columns; y++)
                {
                    GameCell cell = grid.GetCell(x, y);
                    PrintCell(cell);
                }

            }
        }
        public static void PrintCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }
        public static void Move_Ghost(Ghost g)
        {
            GameCell nextcell = g.Move();
            if (nextcell != null)
            {
                GameObject newGo;
                if (nextcell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
                {
                    newGo = new GameObject(GameObjectType.REWARD, '.');
                }
                else
                {
                    newGo = new GameObject(GameObjectType.NONE, ' ');
                }
                Change_Cell(nextcell, g, newGo);
            }
        }
        public static void Change_Cell(GameCell nextcell, GameObject CurrentObject, GameObject newGo)
        {
            GameCell currentCell = CurrentObject.CurrentCell;
            ClearGameCellContent(currentCell, newGo);
            CurrentObject.CurrentCell = nextcell;
            PrintGameObject(CurrentObject);
        }
    }
}