using System;
using System.Drawing;

namespace TheQuest2019
{
    internal class BluePotion : Weapon, IPotion
    {
        private bool used;
        public BluePotion(Game game, Point location) : base(game, location)
        {
            used = false;
        }

        public override string Name
        {
            get
            {
                return "Blue Potion";
            }
        }

        public bool Used
        {
            get
            {
                return used;
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            used = true;
        }
    }
}