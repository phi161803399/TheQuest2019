using System;
using System.Drawing;

namespace TheQuest2019
{
    internal class BluePotion : Weapon, IPotion
    {
        private bool used;
        public BluePotion(Game game, Point point)
            :base(game, point)
        {
            used = false;
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}