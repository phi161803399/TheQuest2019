using System.Drawing;

namespace TheQuest2019
{
    internal class Ghoul : Enemy
    {
        private Game game;
        private Point point;

        public Ghoul(Game game, Point point)
        {
            this.game = game;
            this.point = point;
        }
    }
}