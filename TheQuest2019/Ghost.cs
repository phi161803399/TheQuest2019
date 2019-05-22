using System.Drawing;

namespace TheQuest2019
{
    internal class Ghost : Enemy
    {
        private Game game;
        private Point point;

        public Ghost(Game game, Point point)
        {
            this.game = game;
            this.point = point;
        }
    }
}