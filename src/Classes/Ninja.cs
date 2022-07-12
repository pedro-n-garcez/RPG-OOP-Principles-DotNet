using System;
using System.Collections.Generic;

namespace Tentod
{
    public class Ninja : Hero
    {
        private Inventory weapons = new Inventory(ItemType.Weapon,20);
        public Ninja(string name) : base(name)
        {
            this.name = name;
            this.alive = true;
            this.characterType = "Ninja";
            this.level = 1;
            this.damage = 5;
            this.health = 50;
            this.magicka = 0;
            this.defense = 8;
        }

        public Inventory Weapons()
        {
            return weapons;
        }

        public void PickUpWeapon(Item item)
        {
            weapons.AddItem(item);
        }

        public override int Attack()
        {
            Console.WriteLine($"{name} ataca com um golpe ligeiro!");
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
            return defense;
        }
    }
}
