using System;
using System.Drawing;

namespace TheQuest2019
{
    public class Mace : Weapon
    {
        public Mace(Game game, Point location)
            :base(game, location)
        {
            //
        }

        public override string Name
        {
            get
            {
                return "Mace";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            Direction targetDirection = direction;
            int count = 0; // mace tries to hit enemy at max 4 directions
            while (!DamageEnemy(targetDirection, 20, 6, random) && count < 4)
            {
                // if missed then attack counterclockwise full circle untill hit
                targetDirection = GetDirection(targetDirection, false);
                count++;                
            };
        }
    }
}
