namespace FACMAN
{
    internal class GameObject
    {
        public char DisplayCharacter;
        public GameCell CurrentCell;
        public GameObjectType GameObjectType;
        public GameObject(GameObjectType type, char DisplayCharacter)
        {
            GameObjectType = type;
            this.DisplayCharacter = DisplayCharacter;
        }
        public static GameObjectType GetGameObjectType(char DisplayCharacter)
        {
            if (DisplayCharacter == '|' || DisplayCharacter == '#' || DisplayCharacter == '%')
                return GameObjectType.WALL;
            if(DisplayCharacter=='.')
                return GameObjectType.REWARD;
            else
                return GameObjectType.NONE;
        }
    }
}
