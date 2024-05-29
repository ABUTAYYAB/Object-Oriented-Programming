namespace PACMAN.GL
{
    internal class Collision
    {
        public static bool CollisionCheck(GameObject player, GameObject enemy)
        {
            if (player.currentCell.X == enemy.currentCell.X && player.currentCell.Y == enemy.currentCell.Y)
                return true;
            return false;
        }
    }
}
