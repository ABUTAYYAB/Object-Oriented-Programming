using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACMAN
{
    internal abstract class Ghost : GameObject
    {
        public Ghost(GameObjectType type, char DisplayCharacter) : base(type, DisplayCharacter)
        {
        }
        public abstract GameCell Move();
    }
}
