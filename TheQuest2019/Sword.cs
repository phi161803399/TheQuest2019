using System.Drawing;

namespace TheQuest2019
{
    internal class Sword : Weapon
    {
        private Game game;
        private Point point;

        public Sword(Game game, Point point)
        {
            this.game = game;
            this.point = point;
        }
    }
}