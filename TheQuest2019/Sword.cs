using System;
using System.Drawing;
using System.Windows.Forms;

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
            string message = "Attacking: " + Environment.NewLine;
            Direction targetDirection = direction;
            // attack in designated direction
            message += $"Direction: {targetDirection}" + Environment.NewLine;
            if (!DamageEnemy(targetDirection, 10, 3, random))
            {
                message += "Missed first time" + Environment.NewLine; 
                // if missed then attack clockwise
                targetDirection = GetDirection(direction, true);
                message += $"Attacking clockwise {targetDirection}" + Environment.NewLine;
                if (!DamageEnemy(targetDirection, 10, 3, random))
                {
                    message += "Missed second time" + Environment.NewLine;
                    targetDirection = GetDirection(direction, false);
                    message += $"Attacking counterclockwise {targetDirection}" + Environment.NewLine;
                    // if missed then attack counterclockwise
                    DamageEnemy(targetDirection, 10, 3, random);
                    message += "Missed third time";
                }
            };
            MessageBox.Show(message);
        }
    }
}