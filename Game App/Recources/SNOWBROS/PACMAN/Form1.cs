using EZInput;
using PACMAN.GL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PACMAN
{
	public partial class Form1 : Form
	{
		Player pacman;
		Fire fire;
		List<Ghost> enemies = new List<Ghost>();
		List<Fire> fires = new List<Fire>();
		public int scoreI = 0;
		public int Health_P = 3;
        
        public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			GameGrid grid = new GameGrid("maze.txt", 21, 54);

			Image pacManImage = Game.GetGameObjectImage('P');
			GameCell startCell = grid.GetCell(10, 18);
			pacman = new Player(pacManImage, startCell);
			fire = new Fire(pacManImage, startCell, GameDirection.LEFT);
			Image ghostHImage = Game.GetGameObjectImage('H');
			GameCell ghostHCell = grid.GetCell(10, 2);
			HorizontalGhost ghostH = new HorizontalGhost(ghostHImage, ghostHCell, GameDirection.RIGHT);

			Image ghostVImage = Game.GetGameObjectImage('V');
			GameCell ghostVCell = grid.GetCell(1, 18);
			VerticalGhost ghostV = new VerticalGhost(ghostVImage, ghostVCell, GameDirection.DOWN);

			Image ghostSImage = Game.GetGameObjectImage('S');
			GameCell ghostSCell = grid.GetCell(5, 5);
			SmartGhost ghostS = new SmartGhost(ghostSImage, ghostSCell, pacman);

			Image ghostRImage = Game.GetGameObjectImage('R');
			GameCell ghostRCell = grid.GetCell(10, 5);
			GameCell ghostRCell1 = grid.GetCell(16, 5);

			RandomGhost ghostR = new RandomGhost(ghostRImage, ghostRCell);

			//VerticalGhost f2 = new VerticalGhost(ghostRImage, ghostRCell1, GameDirection.UP);
			    
			PrintMaze(grid);

			enemies.Add(ghostH);
			enemies.Add(ghostV);
			enemies.Add(ghostS);
			enemies.Add(ghostR);
			pb_playerHealth.Value = Player.health;

		}
		private void PrintMaze(GameGrid grid)
		{
			for (int x = 0; x < grid.Rows; x++)
			{
				for (int y = 0; y < grid.Columns; y++)
				{
					GameCell cell = grid.GetCell(x, y);
					Controls.Add(cell.PictureBox);
				}
			}
		}
		private void GameLoop_Tick(object sender, EventArgs e)
		{

			if (Keyboard.IsKeyPressed(Key.LeftArrow))
			{
				pacman.Move(GameDirection.LEFT);
			}
			if (Keyboard.IsKeyPressed(Key.RightArrow))
			{
				pacman.Move(GameDirection.RIGHT);
			}
			if (Keyboard.IsKeyPressed(Key.UpArrow))
			{
				pacman.Move(GameDirection.UP);
			}
			if (Keyboard.IsKeyPressed(Key.DownArrow))
			{
				pacman.Move(GameDirection.DOWN);
			}
			foreach (var ghost in enemies)
			{
				ghost.Move();
				Collision(ghost, pacman);
				bool flag = false;
				foreach(var i in fires)
				{
					if (Fire_Collision(ghost, i))
					{
						fires.Remove(i);
						flag = true;
						break;
					}
				}
				if (flag) break;
			}
			GenerateBullet();
			foreach (var bulllet in fires)
			{
				bulllet.Move();
			}
            if (pb_playerHealth.Value == 0)
            {
                GameLoop.Enabled = false;
                gamoOver form = new gamoOver();
                form.Show();
                this.Hide();
            }
            if (enemies.Count == 0)
            {
                Win frm = new Win();
                frm.Show();
                this.Hide();
                GameLoop.Enabled = false;
            }
            lbl_score.Text = "Score: "+scoreI.ToString();
			lbl_enemyCout.Text ="Enemies: "+ enemies.Count.ToString();
		}
		private void GenerateBullet()
		{
			if (Keyboard.IsKeyPressed(Key.W))
			{
				Image bulletImage = Properties.Resources.SNOWBALL;
				Fire fire = new Fire(bulletImage, pacman.CurrentCell.NextCell(GameDirection.UP), GameDirection.UP);
				fires.Add(fire);
			}
			if (Keyboard.IsKeyPressed(Key.S))
			{
				Image bulletImage = Properties.Resources.SNOWBALL;
				Fire fire = new Fire(bulletImage, pacman.CurrentCell.NextCell(GameDirection.DOWN), GameDirection.DOWN);
				fires.Add(fire);
			}
			if (Keyboard.IsKeyPressed(Key.A))
			{
				Image bulletImage = Properties.Resources.SNOWBALL;
				Fire fire = new Fire(bulletImage, pacman.CurrentCell.NextCell(GameDirection.LEFT), GameDirection.LEFT);
				fires.Add(fire);
			}
			if (Keyboard.IsKeyPressed(Key.D))
			{
				Image bulletImage = Properties.Resources.SNOWBALL;
				Fire fire = new Fire(bulletImage, pacman.CurrentCell.NextCell(GameDirection.RIGHT), GameDirection.RIGHT);
				fires.Add(fire);
			}
		}
		private void Collision(Ghost ghost, Player pacman)
		{
			if (detectCollision(ghost, pacman))
			{
				pb_playerHealth.Value=pb_playerHealth.Value-50;                 
            }					
		}
		private bool Fire_Collision(Ghost ghost, Fire fire)
		{
			if (detectCollision(ghost, fire))
			{
				ghost.health--;
				scoreI++;
			}
			if (ghost.health == 0)
			{
				enemies.Remove(ghost);
				return true;
			}

			return false;
		}
		public static bool detectCollision(GameObject obj1, GameObject obj2)
		{
			if (obj1.currentCell.X == obj2.currentCell.X && obj1.currentCell.Y == obj2.currentCell.Y)
				return true;
			return false;
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}


		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}