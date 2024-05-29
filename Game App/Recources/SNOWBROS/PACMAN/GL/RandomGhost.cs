using System;
using System.Drawing;

namespace PACMAN.GL
{
    internal class RandomGhost : Ghost
    {
        public RandomGhost(Image image, GameCell CurrentCell) : base(GameObjectType.ENEMY, image)
        {
            this.CurrentCell = CurrentCell;
        }

        public override GameCell Move()
        {
            int score = 0;
            GameCell currentCell = CurrentCell;
            GameCell nextCell = null;
            while (nextCell == null)
            {
                GameDirection random = Get_Random_Direction();
                nextCell = currentCell.NextCell(random);
                if (nextCell.currentGameObject.gameObjectType == GameObjectType.BULLET)
                    score--;
                CurrentCell = nextCell;
                currentCell.SetGameObject(Game.GetBlankGameObject());
            }
            return nextCell;
        }
        private GameDirection Get_Random_Direction()
        {
            GameDirection randomDirection;
            Random rand = new Random();
            int number = rand.Next(1, 5);
            if (number == 1)
                randomDirection = GameDirection.UP;
            else if (number == 2)
                randomDirection = GameDirection.DOWN;
            else if (number == 3)
                randomDirection = GameDirection.LEFT;
            else
                randomDirection = GameDirection.RIGHT;

            return randomDirection;
        }
    }
}
