namespace FACMAN
{
    internal class SmartGhost : Ghost
    {
        GameObject Pacman;
        public SmartGhost(GameObjectType type, char DisplayCharacter, GameObject p) : base(type, DisplayCharacter)
        {
            Pacman = p;
        }
        public override GameCell Move()
        {
            GameCell upcell = CurrentCell.NextCell(GameDirection.UP);
            GameCell downcell = CurrentCell.NextCell(GameDirection.DOWN);
            GameCell leftcell = CurrentCell.NextCell(GameDirection.LEFT);
            GameCell rightcell = CurrentCell.NextCell(GameDirection.RIGHT);

            double UpCD = GameGrid.Get_Distance(upcell, Pacman.CurrentCell);
            double DownCD = GameGrid.Get_Distance(downcell, Pacman.CurrentCell);
            double LeftCD = GameGrid.Get_Distance(leftcell, Pacman.CurrentCell);
            double RightCD = GameGrid.Get_Distance(rightcell, Pacman.CurrentCell);

            if (RightCD < DownCD && RightCD < LeftCD && RightCD < UpCD)
                return rightcell;
            else if (DownCD < UpCD && DownCD < LeftCD && DownCD < RightCD)
                return downcell;
            else if (LeftCD < RightCD && LeftCD < UpCD && LeftCD < DownCD)
                return leftcell;
            else
                return upcell;
        }
    }
}
