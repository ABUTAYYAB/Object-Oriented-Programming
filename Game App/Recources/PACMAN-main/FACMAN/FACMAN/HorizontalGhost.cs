namespace FACMAN
{
    internal class HorizontalGhost : Ghost
    {
        public GameDirection direction;
        public HorizontalGhost(GameObjectType type, char DisplayCharacter,GameDirection d) : base(type, DisplayCharacter)
        {
            direction= d;
        }
        public override GameCell Move()
        {
            GameCell nextCell = CurrentCell.NextCell(direction);
            if (nextCell == CurrentCell)
            {
                if (direction == GameDirection.RIGHT)
                    direction = GameDirection.LEFT;
                else if (direction == GameDirection.LEFT)
                    direction = GameDirection.RIGHT;
                nextCell = CurrentCell.NextCell(direction);
            }
            return nextCell;
        }
    }
}
