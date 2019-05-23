using System;
using System.Drawing;

namespace TheQuest2019
{
    public class Enemy: Mover
    {
        public Enemy(Game game, Point location)
            :base(game, location)
        {
            //
        }
        internal void Move(Random random)
        {
            // Todo: direction
            base.Move(Direction.Down, game.Boundaries);
        }
    }
}