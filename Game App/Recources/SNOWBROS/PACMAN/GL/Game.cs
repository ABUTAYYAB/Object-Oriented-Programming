using System.Drawing;

namespace PACMAN.GL
{
    internal class Game
    {
        public static GameObject GetBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, PACMAN.Properties.Resources.simplebox);
            return blankGameObject;
        }
        public static Image GetGameObjectImage(char displayCharacter)
        {
            Image img = PACMAN.Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
                img = PACMAN.Properties.Resources.wall;
            if (displayCharacter == '#')
                img = PACMAN.Properties.Resources.wall;
            if (displayCharacter == '.')
                img = PACMAN.Properties.Resources.FRUIT;
            if (displayCharacter == 'P' || displayCharacter == 'p')
                img = PACMAN.Properties.Resources.PLAYER;
            if (displayCharacter == 'H' || displayCharacter == 'h')
                img = PACMAN.Properties.Resources.ENEMY_H;
            if(displayCharacter=='V'||displayCharacter=='v')
                img = PACMAN.Properties.Resources.ENEMY_V;
            if(displayCharacter=='R'||displayCharacter=='r')
                img = PACMAN.Properties.Resources.ENEMY_R;
            if(displayCharacter=='S'||displayCharacter=='s')
                img = PACMAN.Properties.Resources.ENEMY_S;
            if (displayCharacter == ',')
            {
                img = PACMAN.Properties.Resources.SNOWBALL;
            }

                return img;
        }
    }
}
