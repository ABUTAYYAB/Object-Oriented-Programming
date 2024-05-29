namespace FACMAN
{
    internal class GameCell
    {
        public int X;
        public int Y;
        public GameObject CurrentGameObject;
        public GameGrid Grid;

        public GameCell(int X, int Y, GameGrid Grid)
        {
            this.X = X;
            this.Y = Y;
            this.Grid = Grid;
        }
        public GameCell NextCell(GameDirection direction)
        {
            GameCell nextcell;
            if (direction == GameDirection.UP)
                nextcell = Grid.GetCell(X - 1, Y);
            else if (direction == GameDirection.DOWN)
                nextcell = Grid.GetCell(X + 1, Y);
            else if (direction == GameDirection.LEFT)
                nextcell = Grid.GetCell(X, Y - 1);
            else
                nextcell = Grid.GetCell(X, Y + 1);

            if (nextcell.CurrentGameObject.GameObjectType == GameObjectType.WALL)
                return this;
             
            return nextcell;
        }
    }
}
