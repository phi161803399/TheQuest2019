using System.Drawing;

namespace TheQuest2019
{
    internal class RedPotion : Weapon
    {
        private Game game;
        private Point point;

        public RedPotion(Game game, Point point)
        {
            this.game = game;
            this.point = point;
        }
    }
}