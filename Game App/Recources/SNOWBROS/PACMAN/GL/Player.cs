using System.Drawing;

namespace PACMAN.GL
{
    internal class Player : GameObject
    {
        public static int health = 100;
        public Player(Image DisplayImage, GameCell CurrentCell) : base(GameObjectType.PLAYER, DisplayImage)
        {
            this.CurrentCell = CurrentCell;
        }
        public GameCell Move(GameDirection direction)
        {
            GameCell currentCell = CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            if (nextCell.currentGameObject.gameObjectType == GameObjectType.REWARD)
                if (health < 100)
                    health+=50;
            CurrentCell = nextCell;
            if (currentCell != nextCell)
                currentCell.SetGameObject(Game.GetBlankGameObject());

            return nextCell;
        }
    }
}
