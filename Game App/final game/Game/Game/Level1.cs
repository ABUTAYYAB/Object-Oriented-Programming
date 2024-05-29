using Game.Properties;
using GameDLL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Game
{
    public partial class Level1 : Form
    {
        GameBL Game;
        int Count = 0;
        int Score = 0;

        public Level1()
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
                    Score += 100;
                    Count++;
                    if (Count == 2)
                    {
                        this.Hide();
                        Win form = new Win();
                        form.Show();
                        
                    }
                }
                else if (msg == "Decrease points logic")
                {
                    progressBar1.Value -= 20;
                    if(progressBar1.Value <= 0)
                    {
                        this.Hide();
                        Lose form = new Lose ();
                        form.Show();
                    }
                }
            }
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ClientSize.Width, this.ClientSize.Height);

            KeyboardMovement player = new KeyboardMovement(50, p);
            HorizontalPatrol e1 = new HorizontalPatrol(30, p, Direction.Right.ToString());
            VerticalPatrol e2 = new VerticalPatrol(30, p, Direction.Down.ToString());
            //ZigZagMovement e3 = new ZigZagMovement(30, p, Direction.Right.ToString());

            Game.AddGameobject(Resources.P1, 20, 500, player, GameObjectType.Player);

            Game.AddGameobject(Resources.Enemy1, 200, 0, e1, GameObjectType.Enemy1);
            Game.AddGameobject(Resources.Enemy2, 1250, 10, e2, GameObjectType.Enemy2);
            //Game.AddGameobject(Resources.Enemy3, 0, 200, e3, GameObjectType.Enemy3);
                
            CollisionDetection collision = new CollisionDetection(GameObjectType.Player, GameObjectType.Enemy1, GameAction.DecreasePoints);
            Game.AddCollision(collision);
            CollisionDetection collision1 = new CollisionDetection(GameObjectType.Player, GameObjectType.Enemy2, GameAction.DecreasePoints);
            Game.AddCollision(collision1);
            //CollisionDetection collision2 = new CollisionDetection(GameObjectType.Player, GameObjectType.Enemy3, GameAction.DecreasePoints);
            //Game.AddCollision(collision2);
            CollisionDetection collision3 = new CollisionDetection(GameObjectType.Enemy1, GameObjectType.Bullet1, GameAction.IncreasePoints);
            Game.AddCollision(collision3);
            CollisionDetection collision4 = new CollisionDetection(GameObjectType.Enemy2, GameObjectType.Bullet1, GameAction.IncreasePoints);
            Game.AddCollision(collision4);
            //CollisionDetection collision5 = new CollisionDetection(GameObjectType.Enemy3, GameObjectType.Bullet1, GameAction.IncreasePoints);
            //Game.AddCollision(collision5);

        }
        private void LoadScore()
        {
            textBox1.Text = Score.ToString();
        }
    }
}
