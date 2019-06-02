using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TheQuest2019
{
    public class Player: Mover
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

        public void Move(Direction direction)
        {
            location = Move(direction, game.Boundaries);
            Weapon weaponInRoom = game.WeaponInRoom;
            if (!weaponInRoom.PickedUp)
            {
                int distance = 30; // todo: within a single unit of distance => MoveInterval??
                if (weaponInRoom.Nearby(location, distance))
                {
                    weaponInRoom.PickUpWeapon();
                    inventory.Add(weaponInRoom);
                }
                // if player has no weapons in inventory it will be equipped
                if (equippedWeapon == null && inventory.Any())
                {
                    Equip(weaponInRoom.Name);
                }
            }
        }

        public void Equip(string weaponName)
        {
            //foreach (var weapon in inventory)
            //{
            //    if (weapon.Name == weaponName)
            //        equippedWeapon == weapon;
            //}
            equippedWeapon = inventory.Where(w => w.Name == weaponName).First();
        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
                if (equippedWeapon is IPotion)
                {
                    inventory.Remove(equippedWeapon);
                }
            }
        }
    }
}