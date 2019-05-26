using System;
using System.Drawing;

namespace TheQuest2019
{
    internal class RedPotion : Weapon, IPotion
    {
        private bool used;
        public RedPotion(Game game, Point location) : base(game, location)
        {
            used = false;
        }

        public override string Name
        {
            get
            {
                return "Red Potion";
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
            game.IncreasePlayerHealth(10, random);
            used = true;
        }
    }
}