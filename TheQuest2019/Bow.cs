using System.Drawing;

namespace TheQuest2019
{
    internal class Bow : Weapon
    {
        private Game game;
        private Point point;

        public Bow(Game game, Point point)
        {
            this.game = game;
            this.point = point;
        }
    }
}