using System.Drawing;

namespace PACMAN.GL
{
    public class Fire : GameObject
    {
        public int score = 0;
        GameDirection direction;
        public Fire(Image image, GameCell CurrentCell, GameDirection direction) : base(GameObjectType.ENEMY, image)
        {
            this.CurrentCell = CurrentCell;
            this.direction = direction;
        }
        public GameCell Move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            if (nextCell.currentGameObject.gameObjectType == GameObjectType.ENEMY)              
                 score++;
            base.CurrentCell = nextCell;

            currentCell.SetGameObject(Game.GetBlankGameObject());
            return nextCell;
        }
    }
}
