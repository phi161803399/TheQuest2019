using System;
using System.Drawing;

namespace TheQuest2019
{
    public abstract class Mover
    {
        private const int moveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            return Nearby(locationToCheck, location, distance);
        }

        public bool Nearby(Point locationToCheck, Point location, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance &&
                Math.Abs(location.Y - locationToCheck.Y) < distance)
            {
                return true;
            }
            return false;
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            return Move(direction, location, boundaries);
        }

        public Point Move(Direction direction, Point location, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (location.Y - moveInterval >= boundaries.Top)
                        newLocation.Y -= moveInterval;
                    break;
                case Direction.Down:
                    if (location.Y + moveInterval <= boundaries.Bottom)
                        newLocation.Y += moveInterval;
                    break;
                case Direction.Right:
                    if (location.X + moveInterval <= boundaries.Right)
                        newLocation.X += moveInterval;
                    break;
                case Direction.Left:
                    if (location.X - moveInterval >= boundaries.Left)
                        newLocation.X -= moveInterval;
                    break;
                default:
                    break;
            }
            return newLocation;
        }
    }
}
