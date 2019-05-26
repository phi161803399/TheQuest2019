﻿using System;
using System.Drawing;

namespace TheQuest2019
{
    public abstract class Weapon: Mover
    {
        public Weapon(Game game, Point location)
            :base(game, location)
        {
            //
        }

        public string Name { get; }
        public bool PickedUp { get; protected set; }

        internal void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}