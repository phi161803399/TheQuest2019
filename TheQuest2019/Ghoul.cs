using System;
using System.Drawing;

namespace TheQuest2019
{
    internal class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            :base(game, location, hitpoints: 10) // ghoul has 10 hitpoints
        {
            //
        }

        public override void Move(Random random)
        {
            if (Hitpoints > 0)
            {
                // 2 in 3 chance move towards player
                if (random.Next(3) == 0)
                {
                    // stand still
                }
                else // move towards player
                {
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                if (NearPlayer())
                {
                    game.HitPlayer(4, random); // ghoul attacks with 4
                }
            }
        }
    }
}