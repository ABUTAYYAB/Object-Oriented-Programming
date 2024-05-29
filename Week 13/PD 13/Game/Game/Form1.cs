using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Game
{
    public partial class Form1 : Form
    {
        List<PictureBox> fires = new List<PictureBox>();
        PictureBox enemyBlack;
        PictureBox enemyBlue;
        Random rand = new Random();
        string enemyBlackDirection = "Left";
        string enemyBlueDirection = "Right";

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pictureBox1.Left += 25;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                pictureBox1.Left -= 25;
            }
            if(Keyboard.IsKeyPressed(Key.UpArrow))
            {
                pictureBox1.Top -= 25;

            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                pictureBox1.Top += 25;

            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                Image fireImage = Properties.Resources.Bullet;
                PictureBox pbFire = new PictureBox();
                pbFire.Image = fireImage;
                pbFire.Width = fireImage.Width;
                pbFire.Height = fireImage.Height;
                pbFire.BackColor = Color.Transparent;

                // working
                pbFire.Left = pictureBox1.Left + (pictureBox1.Width / 2) - 5;
                pbFire.Top = pictureBox1.Top + 50;
                fires.Add(pbFire);
                Controls.Add(pbFire);
            }
            moveEnemy(enemyBlue, ref enemyBlueDirection);
            moveEnemy(enemyBlack, ref enemyBlackDirection);

            foreach (PictureBox pb in fires)
            {
                //pb.Top -= 20;
                pb.Left += 20;
            }
            for (int i = 0; i < fires.Count; i++)
            {
                if (fires[i].Bottom < 0)
                {
                    fires.Remove(fires[i]);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int enemyWidth = 50; // Example width
            int enemyHeight = 50; // Example height
            enemyBlack = createEnemy(Game.Properties.Resources.Enemy1,enemyWidth,enemyHeight);
            enemyBlue = createEnemy(Game.Properties.Resources.Enemy2, enemyWidth, enemyHeight);
            this.Controls.Add(enemyBlack);
            this.Controls.Add(enemyBlue);

        }
        private PictureBox createEnemy(Image img, int width, int height)
        {
            
            PictureBox pbEnemy = new PictureBox();
            pbEnemy.Image = img;
            pbEnemy.BackColor = Color.Transparent;
            pbEnemy.Width = width;
            pbEnemy.Height = height;
            return pbEnemy;
        }
        private void moveEnemy(PictureBox enemy, ref string enemyDirection)
        {
            if (enemyDirection == "Right")
            {
                enemy.Left += 10;
            }
            if (enemyDirection == "Left")
            {
                enemy.Left -= 10;
            }
            if ((enemy.Left + enemy.Width) > Width)
            {
                enemyDirection = "Left";
            }
            if (enemy.Left <= 2)
            {
                enemyDirection = "Right";
            }
        }
    }
}
