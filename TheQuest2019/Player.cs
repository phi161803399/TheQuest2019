using System;
using System.Collections.Generic;
using System.Drawing;

namespace TheQuest2019
{
    internal class Player
    {
        private Game game;
        private Point point;

        public Player(Game game, Point point)
        {
            this.game = game;
            this.point = point;
        }

        public int HitPoints { get; internal set; }
        public Point Location { get; internal set; }
        public IEnumerable<string> Weapons { get; internal set; }

        internal void Move(Direction direction)
        {
            throw new NotImplementedException();
        }

        internal void Equip(string weaponName)
        {
            throw new NotImplementedException();
        }

        internal void Hit(int maxDamage, Random random)
        {
            throw new NotImplementedException();
        }

        internal void IncreaseHealth(int health, Random random)
        {
            throw new NotImplementedException();
        }

        internal void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}