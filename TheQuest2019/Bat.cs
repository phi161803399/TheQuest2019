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
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                else // move in random direction
                {
                    location = Move((Direction)(random.Next(4) + 4), game.Boundaries); // see enum Direction
                }
                if (NearPlayer())
                {
                    game.HitPlayer(2, random); // bat attacks with 2
                }
            }
        }
    }
}