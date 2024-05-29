using GameDLL.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDLL.Core
{
    public class ZigZagMovement : IMovement
    {
        private int speed,count,offset = 150;
        private Point boundry;
        private string direction;

        public ZigZagMovement(int speed, Point boundry, string direction)
        {
            this.speed = speed;
            this.boundry = boundry;
            this.direction = direction;
            this.count = 0;
        }

        public Point move(Point Location)
        {

            if ((Location.X + offset) > boundry.X)
            {
                direction = "Left";
            }
            else if ((Location.X + speed) <= 0)
            {
                direction = "Right";
            }
            if (count == 10)
            {
                count = 0;
            }


            if (direction == "Right")
            {
                if (count < 5)
                {
                    Location.X += speed;
                    Location.Y -= speed;
                }
                else if (count >= 5 && count < 10)
                {
                    Location.X += speed;
                    Location.Y += speed;
                }
            }
            else if (direction == "Left")
            {
                if (count < 5)
                {
                    Location.X -= speed;
                    Location.Y += speed;
                }
                else if (count >= 5 && count < 10)
                {
                    Location.X -= speed;
                    Location.Y -= speed;
                }
            }
            count++;
            return Location;
        }
    }
}
