using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACMAN.GL
{
    internal abstract class Ghost : GameObject
    {
        public int health = 5;
        public Ghost(GameObjectType type, Image displayImage) : base(type, displayImage)
        {
        }
        public abstract GameCell Move();
    }
}
