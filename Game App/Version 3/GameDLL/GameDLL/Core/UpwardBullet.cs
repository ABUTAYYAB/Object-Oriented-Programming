using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDLL.Interface;
using Point = System.Drawing.Point;
using EZInput;


namespace GameDLL.Core
{
    public class UpwardBullet : IbulletMovement
    {
        private int speed;         

        public UpwardBullet(int speed)
        {
            this.speed = speed;            
        }

        public Point move(Point Location)
        {            
            Location.Y -= speed;
            return Location;
        }
    }
}
