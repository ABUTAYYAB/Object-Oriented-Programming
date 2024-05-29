using System.Drawing;

namespace PACMAN.GL
{
    internal class SmartGhost : Ghost
    {
        GameObject Pacman;
        public SmartGhost(Image image, GameCell CurrentCell, GameObject p) : base(GameObjectType.ENEMY, image)
        {
            Pacman = p;
            this.CurrentCell = CurrentCell;
        }
        public override GameCell Move()
        {
            GameCell returnCell;
            GameCell currentCell = CurrentCell;
            GameCell upCell = currentCell.NextCell(GameDirection.UP);
            GameCell downCell = currentCell.NextCell(GameDirection.DOWN);
            GameCell leftCell = currentCell.NextCell(GameDirection.LEFT);
            GameCell rightCell = currentCell.NextCell(GameDirection.RIGHT);

            double UpCD = GameGrid.Get_Distance(upCell, Pacman.currentCell);
            double DownCD = GameGrid.Get_Distance(downCell, Pacman.currentCell);
            double LeftCD = GameGrid.Get_Distance(leftCell, Pacman.currentCell);
            double RightCD = GameGrid.Get_Distance(rightCell, Pacman.currentCell);

            if (RightCD < DownCD && RightCD < LeftCD && RightCD < UpCD)
            {
                returnCell = rightCell;
            }
            else if (DownCD < UpCD && DownCD < LeftCD && DownCD < RightCD)
            {
                returnCell = downCell;
            }
            else if (LeftCD < RightCD && LeftCD < UpCD && LeftCD < DownCD)
            {
                returnCell = leftCell;
            }
            else
            {
                returnCell = upCell;
            }
            currentCell.SetGameObject(Game.GetBlankGameObject());

            GameObjectType type = returnCell.CurrentGameObject.GameObjectType;
            CurrentCell = returnCell;
            if (type == GameObjectType.REWARD)
                currentCell.SetGameObject(Game.GetRewardGameObject());

            return returnCell;
        }
    }
}
