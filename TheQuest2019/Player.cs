using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TheQuest2019
{
    internal class Player: Mover
    {
        private Weapon equippedWeapon;

        public Player(Game game, Point location)
            :base(game, location)
        {
            HitPoints = 10;
        }

        public int HitPoints { get; private set; }
        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                //List<string> names = new List<string>();
                //foreach (Weapon weapon in inventory)
                //{
                //    names.Add(weapon.Name);
                //}
                //return names;

                var names = inventory.Select(w => w.Name);
                return names;
            }
        }

        internal void Move(Direction direction)
        {
            location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {

            }
        }

        internal void Equip(string weaponName)
        {
            //foreach (var weapon in inventory)
            //{
            //    if (weapon.Name == weaponName)
            //        equippedWeapon == weapon;
            //}
            var equippedWeapon = inventory.Where(w => w.Name == weaponName).First();
        }

        internal void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        internal void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        internal void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}