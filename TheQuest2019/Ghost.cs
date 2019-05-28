using System;
using System.Drawing;

namespace TheQuest2019
{
    internal class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
            :base(game, location, hitpoints: 8) // ghost has 8 hitpoints
        {
            //
        }

        public override void Move(Random random)
        {
            if (Hitpoints > 0)
            {
                // 1 in 3 chance move towards player
                if (random.Next(3) == 0) // move towards player
                {
                    base.Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                else
                {
                    // stand still
                }
                if (NearPlayer())
                {
                    game.HitPlayer(3, random); // ghost attacks with 3
                }
            }
        }
    }
}