using Game.Properties;
using GameDLL.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    public partial class Level2 : Form
    {

        GameBL Game;
        int Count = 0;
        int Score = 0;

        public Level2()
        {
            InitializeComponent();
            Game = GameBL.GetInstance(this);

            GameLoop.Interval = 100; // Adjust the interval as needed
            GameLoop.Start();
            progressBar1.Value = 100;
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            Game.CreateBullet(Resources.Bullet);
            Game.Update();
            LoadScore();
            string msg = Game.CheckCollisions();
            if (!string.IsNullOrEmpty(msg) && progressBar1.Value >= 10)
            {
                if (msg == "Increase points logic")
                {
                    Score += 300;
                    Count++;
                    if (Count == 3)
                    {
                        this.Hide();
                        Win form = new Win();
                        form.Show();

                    }
                }
                else if (msg == "Decrease points logic")
                {
                    progressBar1.Value -= 20;
                    if (progressBar1.Value <= 0)
                    {
                        this.Hide();
                        Lose form = new Lose();
                        form.Show();
                    }
                }

            }
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ClientSize.Width, this.ClientSize.Height);

            KeyboardMovement player = new KeyboardMovement(50, p);
            HorizontalPatrol e1 = new HorizontalPatrol(30, p, Direction.Right.ToString());
            VerticalPatrol e2 = new VerticalPatrol(30, p, Direction.Down.ToString());
            ZigZagMovement e3 = new ZigZagMovement(30, p, Direction.Right.ToString());


            Game.AddGameobject(Resources.P1, 20, 500, player, GameObjectType.Player);

            Game.AddGameobject(Resources.E1, 200, 350, e1, GameObjectType.Enemy1);
            Game.AddGameobject(Resources.E2, 1250, 10, e2, GameObjectType.Enemy2);
            Game.AddGameobject(Resources.Enemy3, 0, 250, e3, GameObjectType.Enemy3);


            CollisionDetection collision = new CollisionDetection(GameObjectType.Player, GameObjectType.Enemy1, GameAction.DecreasePoints);
            Game.AddCollision(collision);

            CollisionDetection collision1 = new CollisionDetection(GameObjectType.Player, GameObjectType.Enemy2, GameAction.DecreasePoints);
            Game.AddCollision(collision1);

            CollisionDetection collision2 = new CollisionDetection(GameObjectType.Player, GameObjectType.Enemy3, GameAction.DecreasePoints);
            Game.AddCollision(collision2);

            CollisionDetection collision3 = new CollisionDetection(GameObjectType.Enemy1, GameObjectType.Bullet1, GameAction.IncreasePoints);
            Game.AddCollision(collision3);

            CollisionDetection collision4 = new CollisionDetection(GameObjectType.Enemy2, GameObjectType.Bullet1, GameAction.IncreasePoints);
            Game.AddCollision(collision4);

            CollisionDetection collision5 = new CollisionDetection(GameObjectType.Enemy3, GameObjectType.Bullet1, GameAction.IncreasePoints);
            Game.AddCollision(collision5);
        }
        private void LoadScore()
        {
            textBox1.Text = Score.ToString();
        }
    }
}
