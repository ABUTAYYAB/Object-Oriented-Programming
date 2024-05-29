using System.Drawing;
using System.Windows.Forms;

namespace PACMAN.GL
{
    public class GameCell
    {
        public int x;
        public int y;
        public GameObject currentGameObject;
        public GameGrid Grid;
        public PictureBox pictureBox;
        const int width = 20;
        const int height = 20;
        int score = 0;
        public GameCell(int x, int y, GameGrid Grid)
        {
            this.x = x;
            this.y = y;
            pictureBox = new PictureBox();
            pictureBox.Left = y * width;
            pictureBox.Top = x * height;
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;
            this.Grid = Grid;
        }
        public void SetGameObject(GameObject gameObject)
        {
            currentGameObject = gameObject;
            pictureBox.Image = gameObject.Image;

        }
        public GameCell NextCell(GameDirection direction)
        {
            GameCell nextcell;
            if (direction == GameDirection.UP)
                nextcell = Grid.GetCell(x - 1, y);
            else if (direction == GameDirection.DOWN)
                nextcell = Grid.GetCell(x + 1, y);
            else if (direction == GameDirection.LEFT)
                nextcell = Grid.GetCell(x, y - 1);
            else
                nextcell = Grid.GetCell(x, y + 1);

            if (nextcell.CurrentGameObject.GameObjectType == GameObjectType.WALL)
                return this;
            
            return nextcell;
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public GameObject CurrentGameObject { get => currentGameObject; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }

        
    }
}
