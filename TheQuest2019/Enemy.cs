using System;
using System.Drawing;

namespace TheQuest2019
{
    public abstract class Enemy: Mover
    {
        private const int NearPlayerDistance = 25;
        public int Hitpoints { get; private set; }
        public bool Dead {
            get
            {
                if (Hitpoints <= 0)
                    return true;
                return false;
            }
        }
        public Enemy(Game game, Point location, int hitpoints)
            :base(game, location)
        {
            Hitpoints = hitpoints;
        }
        public abstract void Move(Random random);

        // same as player
        public void Hit(int maxDamage, Random random)
        {
            Hitpoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, NearPlayerDistance));
        }

        protected Direction FindPlayerDirection(Point playerlocation)
        {
            Direction directionToMove;
            if (playerlocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerlocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerlocation.Y > location.Y + 10)
                directionToMove = Direction.Down;
            else
                directionToMove = Direction.Up;
            return directionToMove;
        }
    }
}