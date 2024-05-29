using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Properties;
using GameDLL;
using GameDLL.Core;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GameBL game;


        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ClientSize.Width, this.ClientSize.Height);

            game = new GameBL(this);

            HorizontalPatrol e1 = new HorizontalPatrol(10,p,Direction.Left.ToString());
            VerticalPatrol e2 = new VerticalPatrol(10, p, Direction.Down.ToString());
            ZigZagMovement e3 = new ZigZagMovement(30,p,Direction.Right.ToString());
            KeyboardMovement player = new KeyboardMovement(20, p);

            game.AddGameobject(Resources.Enemy1, 0, 0, e1);
            game.AddGameobject(Resources.Enemy2, 900, 0, e2);
            game.AddGameobject(Resources.Enemy3, 900, 270, e3);

            game.AddGameobject(Resources.Player, 0, 500, player);
        }
    }
}
