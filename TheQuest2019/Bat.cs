using System.Drawing;

namespace TheQuest2019
{
    internal class Bat : Enemy
    {
        private Game game;
        private Point point;

        public Bat(Game game, Point point)
        {
            this.game = game;
            this.point = point;
        }
    }
}