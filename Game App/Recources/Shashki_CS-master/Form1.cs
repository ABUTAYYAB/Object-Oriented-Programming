using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shashki_CS
{
  public partial class Form1 : Form
  {
    public int player_position;
    public int object_rad;
    double object_y;
    public Random rnd = new Random();
    public int velocity = 150;
    double time = 0;
    public Form1()
    {
      InitializeComponent();

      object_y = obyect.Location.Y;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      time += timer1.Interval / 1000.0;
      if (time > 1/2.0 )
        switch(key)
        {
          case Keys.A:
          case Keys.Left:
            if (player_position == 1)
            {
              player_position = 0;
            }
            else if (player_position == 2)
            {
              player_position = 1;
            }
            else
            {
              break;
            }
            player.Location = new Point(25 + 105 * player_position, 450);
            break;

          case Keys.D:
          case Keys.Right:
            if (player_position == 1)
            {
              player_position = 2;
            }
            else if (player_position == 0)
            {
              player_position = 1;
            }
            else
            {
              break;
            }

            player.Location = new Point(25 + 105 * player_position, 450);
            break;
        }
      if (time > 50) time -= 50;
      object_y += velocity * timer1.Interval / 1000.0;
      Point op = obyect.Location;
      op.Y = (int)object_y;
      obyect.Location = op;
      if (op.Y > 550)
      {
        object_rad = rnd.Next(0, 3);
        obyect.Location = new Point(25 + 105 * object_rad, 10);
        object_y = 10;
      }
      
      if (player_position == object_rad && obyect.Location.Y >= 354 && obyect.Location.Y < 550)
      {
        label1.Visible = true;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      label1.Visible = false;
      timer1.Enabled = true;
      player_position = 1;
      object_rad = rnd.Next(0, 3);
      obyect.Location = new Point(25 + 105 * (int)object_rad, 10);
    }
    Keys key;
    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      key = e.KeyCode;
    }
    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
      key = Keys.None;
    }
    private void Form1_Click(object sender, EventArgs e){}
    private void obyect_Click(object sender, EventArgs e){}
    private void player_Click(object sender, EventArgs e){}
  }
}
