using System.Drawing;

namespace PACMAN.GL
{
    internal class PacmanPlayer : GameObject
    {
        public int SCORE = 0;
        public int LIVES = 3;
        public PacmanPlayer(Image DisplayImage, GameCell CurrentCell) : base(GameObjectType.PLAYER, DisplayImage)
        {
            this.CurrentCell = CurrentCell;
        }
        public GameCell Move(GameDirection direction)
        {
            GameCell currentCell = CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            if (nextCell.currentGameObject.gameObjectType == GameObjectType.REWARD)
                SCORE++;
            CurrentCell = nextCell;
            if (currentCell != nextCell)
                currentCell.SetGameObject(Game.GetBlankGameObject());
            return nextCell;
        }
    }
}
