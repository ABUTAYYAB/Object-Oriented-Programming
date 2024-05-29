using GameDLL.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDLL.Core
{
    public class VerticalPatrol : IMovement
    {
        private int speed;
        private int offset = 200;
        private Point boundry;
        private string direction;

        public VerticalPatrol(int speed, Point boundry, string direction)
        {
            this.speed = speed;
            this.boundry = boundry;
            this.direction = direction;
        }        

        public Point move(Point Location)
        {

            if ((Location.Y + offset) >= boundry.Y)
            {
                direction = "Up";
            }
            else if ((Location.Y - speed) <= 0)
            {
                direction = "Down";
            }

            if (direction == "Up")
            {
                Location.Y -= speed;
            }
            else
            {
                Location.Y += speed;
            }

            return Location;
        }
    }
}
