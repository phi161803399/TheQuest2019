using System;
using System.Drawing;

namespace TheQuest2019
{
    public class Sword : Weapon
    {
        public Sword(Game game, Point location)
            :base(game, location)
        {
            //
        }

        public override string Name
        {
            get
            {
                return "Sword";
            }
        }

        /// <summary>
        /// first attack in given direction
        /// if missed attack clockwise
        /// if missed attack counterclockwise
        /// </summary>
        /// <param name="direction"><see cref="Direction"/></param>
        /// <param name="random"></param>
        public override void Attack(Direction direction, Random random)
        {
            Direction targetDirection = direction;
            // attack in designated direction
            if (!DamageEnemy(targetDirection, 10, 3, random))
            {
                // if missed then attack clockwise
                targetDirection = GetDirection(targetDirection, true);
                if (!DamageEnemy(targetDirection, 10, 3, random))
                {
                    targetDirection = GetDirection(targetDirection, false);
                    // if missed then attack counterclockwise
                    DamageEnemy(targetDirection, 10, 3, random);
                }
            };
        }
    }
}