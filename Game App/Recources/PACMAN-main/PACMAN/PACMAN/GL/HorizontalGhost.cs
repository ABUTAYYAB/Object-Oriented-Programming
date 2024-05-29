using System.Drawing;

namespace PACMAN.GL
{
    internal class HorizontalGhost : Ghost
    {
        GameDirection direction;
        public HorizontalGhost(Image image, GameCell CurrentCell, GameDirection direction) : base(GameObjectType.ENEMY, image)
        {
            this.direction = direction;
            this.CurrentCell = CurrentCell;
        }
        public override GameCell Move()
        {
            GameCell currentCell = CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            GameObjectType type = nextCell.CurrentGameObject.GameObjectType;
            CurrentCell = nextCell;
            if (nextCell == currentCell)
            {
                if (direction == GameDirection.RIGHT)
                    direction = GameDirection.LEFT;
                else
                    direction = GameDirection.RIGHT;

                nextCell = currentCell.NextCell(direction);
                CurrentCell = nextCell;
            }
            if (type == GameObjectType.REWARD)
                currentCell.SetGameObject(Game.GetRewardGameObject());
            else
            currentCell.SetGameObject(Game.GetBlankGameObject());

            return nextCell;
        }
    }
}
