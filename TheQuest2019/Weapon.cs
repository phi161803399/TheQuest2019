using System;
using System.Drawing;

namespace TheQuest2019
{
    public abstract class Weapon: Mover
    {
        public Weapon(Game game, Point location)
            :base(game, location)
        {
            PickedUp = false;
        }

        public bool PickedUp { get; protected set; }

        public abstract void Attack(Direction direction, Random random);

        public void PickUpWeapon()
        {
            PickedUp = true;
        }

        public abstract string Name { get; }

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius/2; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                    target = Move(direction, target, game.Boundaries);
                }
            }
            return false;
        }

        /// <summary>
        /// Get <see cref="Direction"/> clockwise or counterclockwise from initial direction
        /// </summary>
        /// <param name="direction">initial <see cref="Direction"/></param>
        /// <param name="clockwise">determines next direction whether clockwise or counterclockwise</param>
        /// <returns></returns>
        public static Direction GetDirection(Direction direction, bool clockwise)
        {
            Direction nextDirection;
            if (clockwise)
            {
                nextDirection = (Direction)(((int)direction + 1) % 4) + 4;
            }
            else
            {
                nextDirection = (Direction)(((int)direction - 1) % 4) + 4;
            }
            return nextDirection;
        }
    }
}