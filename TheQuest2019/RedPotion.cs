using System.Drawing;

namespace TheQuest2019
{
    internal class BluePotion : Weapon
    {
        private Game game;
        private Point point;

        public BluePotion(Game game, Point point)
        {
            this.game = game;
            this.point = point;
        }
    }
}