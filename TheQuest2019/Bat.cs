using System;
using System.Drawing;

namespace TheQuest2019
{
    internal class Bat : Enemy
    {
        public Bat(Game game, Point location)
            :base(game, location, hitpoints: 6) // bat has 6 hitpoints
        {
            //
        }

        public override void Move(Random random)
        {
            if (Hitpoints > 0)
            {
                // 50% chance of enemy moving towards player
                if (random.Next(2) == 0) // move towards player
                {
                    base.Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                else // move in random direction
                {
                    base.Move((Direction)random.Next(4), game.Boundaries);
                }
                if (NearPlayer())
                {
                    game.HitPlayer(2, random); // bat attacks with 2
                }
            }
        }
    }
}