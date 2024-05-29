namespace FACMAN
{
    internal class VerticalGhost : Ghost
    {
        public GameDirection direction;
        public VerticalGhost(GameObjectType type, char DisplayCharacter,GameDirection d) : base(type, DisplayCharacter)
        {
            direction = d;
        }
        public override GameCell Move()
        {
            GameCell nextCell = CurrentCell.NextCell(direction);
            if (nextCell == CurrentCell)
            {
                if (direction == GameDirection.UP)
                    direction = GameDirection.DOWN;
                else if (direction == GameDirection.DOWN)
                    direction = GameDirection.UP;
                nextCell = CurrentCell.NextCell(direction);
            }
            return nextCell;
        }
    }
}
