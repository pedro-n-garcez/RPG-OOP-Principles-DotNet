using System;
using System.Collections.Generic;

namespace Tentod
{
    public class Knight : Hero
    {
        private Inventory weapons = new Inventory(ItemType.Weapon,10);
        private Inventory shields = new Inventory(ItemType.Shield,10);
        public Knight(string name) : base(name)
        {
            this.name = name;
            this.alive = true;
            this.characterType = "Knight";
            this.level = 1;
            this.damage = 10;
            this.health = 50;
            this.magicka = 0;
            this.defense = 5;
        }

        public Inventory Weapons()
        {
            return weapons;
        }

        public Inventory Shields()
        {
            return shields;
        }

        public void PickUpWeapon(Item item)
        {
            weapons.AddItem(item);
        }

        public void PickUpShield(Item item)
        {
            shields.AddItem(item);
        }

        public override int Attack()
        {
            Console.WriteLine($"{name} ataca com um soco!");
            return damage;
        }

        //polimorfismo - overload do método acima
        public override int Attack(int index)
        {
            Console.WriteLine($"{name} ataca com {weapons.GetItemAt(index).GetName()}!");
            int tempDamage = damage + weapons.GetItemAt(index).GetDamageChange();
            return tempDamage;
        }

        public override int Defend()
        {
            LoseHealth(5);
            return defense;
        }

        public override int Defend(int index)
        {
            Console.WriteLine($"{name} defende com {shields.GetItemAt(index).GetName()}!");
            int tempDefense = defense + shields.GetItemAt(index).GetDefenseChange();
            return tempDefense;
        }
    }
}
