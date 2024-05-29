using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACMAN
{
    internal class PacmanPlayer : GameObject
    {
        public PacmanPlayer(char DisplayCharacter, GameCell CurrentCell) : base(FACMAN.GameObjectType.PLAYER, DisplayCharacter)
        {
            this.CurrentCell = CurrentCell;
        }
    }
}
