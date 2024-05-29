using EZInput;
using PACMAN.GL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PACMAN
{
    public partial class MainGame : Form
    {
        PacmanPlayer pacman;
        GameCell startCell;
        List<Ghost> ghosts = new List<Ghost>();
        public MainGame()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("maze.txt", 21, 37);

            Image pacManImage = Game.GetGameObjectImage('P');
            startCell = grid.GetCell(10, 18);
            pacman = new PacmanPlayer(pacManImage, startCell);

            Image ghostHImage = Game.GetGameObjectImage('H');
            GameCell ghostHCell = grid.GetCell(10, 3);
            HorizontalGhost ghostH = new HorizontalGhost(ghostHImage, ghostHCell, GameDirection.RIGHT);

            Image ghostVImage = Game.GetGameObjectImage('V');
            GameCell ghostVCell = grid.GetCell(2, 18);
            VerticalGhost ghostV = new VerticalGhost(ghostVImage, ghostVCell, GameDirection.DOWN);

            Image ghostSImage = Game.GetGameObjectImage('S');
            GameCell ghostSCell = grid.GetCell(5, 5);
            SmartGhost ghostS = new SmartGhost(ghostSImage, ghostSCell, pacman);

            Image ghostRImage = Game.GetGameObjectImage('R');
            GameCell ghostRCell = grid.GetCell(10, 5);
            RandomGhost ghostR = new RandomGhost(ghostRImage, ghostRCell);

            ghosts.Add(ghostH);
            ghosts.Add(ghostV);
            ghosts.Add(ghostR);
            ghosts.Add(ghostS);

            PrintMaze(grid);

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
            ScoreBox.Text = pacman.SCORE.ToString();
            LivesBox.Text = pacman.LIVES.ToString();
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
            foreach (Ghost ghost in ghosts)
            {
                ghost.Move();
                GameRunning(ghost);
            }
        }

        private void GameRunning(Ghost ghost)
        {
            if (Collision.CollisionCheck(pacman, ghost))
            {
                if (pacman.LIVES == 0)
                {
                    GameLoop.Enabled = false;
                    GameOverLabel.Visible = true;
                }
                else
                {
                    pacman.LIVES--;
                    GameLoop.Enabled = false;
                    pacman.currentCell = startCell;
                    MessageBox.Show("1 Live Lost : Reamining Lives : " + pacman.LIVES, "Pacman Position Reset");
                    GameLoop.Enabled = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            GameLoop.Enabled = false;
            MessageBox.Show("Restarting the Game : All your progress will be lost");
            Application.Restart();
        }
    }
}
