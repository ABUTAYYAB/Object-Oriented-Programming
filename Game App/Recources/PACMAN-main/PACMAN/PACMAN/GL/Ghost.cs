using System.Drawing;

namespace PACMAN.GL
{
    internal abstract class Ghost : GameObject
    {
        public Ghost(GameObjectType type, Image displayImage) : base(type, displayImage)
        {
        }
        public abstract GameCell Move();
    }
}
