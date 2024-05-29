using EZInput;
using GameDLL.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = System.Drawing.Point;

namespace GameDLL.Core
{
    public class KeyboardMovement : IMovement
    {
        private int speed;
        private Point boundry;
        private int offset;

        public KeyboardMovement(int speed, Point boundry)
        {
            this.speed = speed;
            this.boundry = boundry;
            this.offset = 50;      
        }        

        public Point move(Point Location)
        {
            if(EZInput.Keyboard.IsKeyPressed(Key.UpArrow))
            {
                if(Location.Y + speed > 50)
                {
                    Location.Y -= speed;
                }
            }
            if (EZInput.Keyboard.IsKeyPressed(Key.DownArrow))
            {
                if (Location.Y + speed < boundry.Y - 100)
                {
                    Location.Y += speed;
                }
            }
            if (EZInput.Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                if (Location.X + speed > 50 )
                {
                    Location.X -= speed;
                }
            }
            if (EZInput.Keyboard.IsKeyPressed(Key.RightArrow))
            {
                if (Location.X + speed < boundry.X - 50)
                {
                    Location.X += speed;
                }
            }
            return Location;
        }
    }
}
