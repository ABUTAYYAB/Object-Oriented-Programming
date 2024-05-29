using EZInput;

namespace TRY
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

        private void Form1_Load(object sender, EventArgs e)
        {
            enemyBlack = createEnemy(TRY.Properties.Resources.monster);
            enemyBlue = createEnemy(TRY.Properties.Resources.monster);
            this.Controls.Add(enemyBlack);
            this.Controls.Add(enemyBlue);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                Image fireImage = Properties.Resources.fire;
                PictureBox pbFire = new PictureBox();
                pbFire.Image = fireImage;
                pbFire.Width = fireImage.Width;
                pbFire.Height = fireImage.Height;
                pbFire.BackColor = Color.Transparent;
                System.Drawing.Point fireLocation;

                // working
                pbFire.Left = pictureBox1.Left + (pictureBox1.Width / 2) - 5;
                pbFire.Top = pictureBox1.Top;
                fires.Add(pbFire);
                Controls.Add(pbFire);
            }
            moveEnemy(enemyBlue, ref enemyBlueDirection);
            moveEnemy(enemyBlack, ref enemyBlackDirection);
            foreach (PictureBox pb in fires)
            {
                pb.Top -= 20;
            }
            for (int i = 0; i < fires.Count; i++)
            {
                if (fires[i].Bottom < 0)
                {
                    fires.Remove(fires[i]);
                }
            }
        }
        /* private PictureBox createFire(Image fireImage,PictureBox source)
         {

         }*/
        private PictureBox createEnemy(Image img)
        {
            PictureBox pbEnemy = new PictureBox();
            int left = rand.Next(30, Width);
            int right = rand.Next(5, img.Height + 20);
            pbEnemy.Left = left;
            pbEnemy.Top = right;
            pbEnemy.Height = img.Height;
            pbEnemy.Width = img.Width;
            pbEnemy.Image = img;
            pbEnemy.BackColor = Color.Transparent;
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
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}