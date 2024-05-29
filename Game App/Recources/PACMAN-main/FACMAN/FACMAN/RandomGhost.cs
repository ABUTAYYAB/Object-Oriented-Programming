namespace FACMAN
{
    internal class RandomGhost : Ghost
    {
        public RandomGhost(GameObjectType type, char DisplayCharacter) : base(type, DisplayCharacter)
        {
        }

        public override GameCell Move()
        {
            GameCell nextcell = null;
            while (nextcell == null)
            {
                GameDirection random = Get_Random_Direction();
                nextcell = CurrentCell.NextCell(random);
            }
            return nextcell;
        }
        private GameDirection Get_Random_Direction()
        {
            GameDirection randomDirection;
            Random rand = new Random();
            int number = rand.Next(1, 5);
            if (number == 1) randomDirection = GameDirection.UP;
            else if (number == 2) randomDirection = GameDirection.DOWN;
            else if (number == 3) randomDirection = GameDirection.LEFT;
            else randomDirection = GameDirection.RIGHT;
            return randomDirection;
        }
    }
}
