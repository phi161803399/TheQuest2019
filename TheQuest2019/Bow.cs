using System;
using System.Drawing;

namespace TheQuest2019
{
    internal class Bow : Weapon
    {
        public Bow(Game game, Point location)
            :base(game, location)
        {
            //
        }

        public override string Name
        {
            get
            {
                return "Bow";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            // bow attacks in one direction
            DamageEnemy(direction, 30, 1, random);
        }
    }
}