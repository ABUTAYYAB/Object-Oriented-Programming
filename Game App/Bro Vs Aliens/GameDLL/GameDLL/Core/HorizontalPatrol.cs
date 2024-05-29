using GameDLL.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDLL.Core
{
    public class HorizontalPatrol : IMovement
    {
        private int speed;
        private int offset = 100;
        private Point boundry;
        private string direction;

        public HorizontalPatrol(int speed, Point boundry, string direction)
        {
            this.speed = speed;
            this.boundry = boundry;
            this.direction = direction;
        }        
        public Point move(Point Location)
        {
            
            if ((Location.X + speed) >= boundry.X - offset)
            {
                direction = "Left";
            }
            else if ((Location.X - speed) <= 300)
            {
                direction = "Right";
            }

            if (direction == "Left")
            {
                Location.X -= speed;
            }
            else
            {
                Location.X += speed;
            }

            return Location;
            
        }
    }
}
