using GameDLL.Core;
using GameFrontEnd.Properties;
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

namespace GameFrontEnd
{
    public partial class Form1 : Form
    {
        GameBL game;

        public Form1()
        {
            InitializeComponent();
            game = new GameBL(this);
            timer1.Interval = 100; 
            progressBar1.Value = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Update();

            game.CreateBullet(Resources.Bullet);
            string msg = game.CheckCollisions();
            if (!string.IsNullOrEmpty(msg) && progressBar1.Value >= 10)
            {
                if (msg == "Increase points logic")
                {
                    if (progressBar1.Value < 100)
                    {
                        progressBar1.Value += 10;
                    }
                }
                else if (msg == "Decrease points logic")
                {
                    progressBar1.Value -= 10;
                    if (progressBar1.Value <= 0)
                    {
                        this.Hide();
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Point p = new Point(this.ClientSize.Width, this.ClientSize.Height);

            KeyboardMovement player = new KeyboardMovement(20, p);
            HorizontalPatrol e1 = new HorizontalPatrol(20, p, Direction.Left.ToString());
            VerticalPatrol e2 = new VerticalPatrol(20, p, Direction.Down.ToString());
            ZigZagMovement e3 = new ZigZagMovement(20, p, Direction.Right.ToString());

            game.AddGameobject(Resources.p, 0, 500, player, GameObjectType.Player);

            game.AddGameobject(Resources.e1, 0, 0, e1, GameObjectType.Enemy1);
            game.AddGameobject(Resources.e2, 1200, 10, e2, GameObjectType.Enemy2);
            game.AddGameobject(Resources.e3, 0, 300, e3, GameObjectType.Enemy3);

            CollisionDetection collision = new CollisionDetection(GameObjectType.Player, GameObjectType.Enemy1, GameAction.DecreasePoints);
            game.AddCollision(collision);
            CollisionDetection collision1 = new CollisionDetection(GameObjectType.Player, GameObjectType.Enemy2, GameAction.DecreasePoints);
            game.AddCollision(collision1);
            CollisionDetection collision2 = new CollisionDetection(GameObjectType.Player, GameObjectType.Enemy3, GameAction.DecreasePoints);
            game.AddCollision(collision2);
            CollisionDetection collision3 = new CollisionDetection(GameObjectType.Enemy1, GameObjectType.Bullet1, GameAction.IncreasePoints);
            game.AddCollision(collision3);
            CollisionDetection collision4 = new CollisionDetection(GameObjectType.Enemy2, GameObjectType.Bullet1, GameAction.IncreasePoints);
            game.AddCollision(collision4);
            CollisionDetection collision5 = new CollisionDetection(GameObjectType.Enemy3, GameObjectType.Bullet1, GameAction.IncreasePoints);
            game.AddCollision(collision5);
        }
    }
}
