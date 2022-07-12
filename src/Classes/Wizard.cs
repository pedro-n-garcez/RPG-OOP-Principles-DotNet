using System;
using System.Collections.Generic;

namespace Tentod
{
    public class Wizard : Hero
    {
        private Inventory attackSpells = new Inventory(ItemType.AttackSpell, 10);
        private Inventory defenseSpells = new Inventory(ItemType.DefenseSpell,10);
        public Wizard(string name) : base(name)
        {
            this.name = name;
            this.alive = true;
            this.characterType = "Wizard";
            this.level = 1;
            this.health = 50;
            this.damage = 5;
            this.magicka = 5;
            this.defense = 5;
        }

        public Inventory AttackSpells()
        {
            return attackSpells;
        }

        public Inventory DefenseSpells()
        {
            return defenseSpells;
        }

        public void PickUpAttackSpell(Item item)
        {
            attackSpells.AddItem(item);
        }

        public void PickUpDefenseSpell(Item item)
        {
            defenseSpells.AddItem(item);
        }

        public override int Attack()
        {
            Console.WriteLine($"{name} ataca com um feitiço padrão!");
            return damage;
        }

        //polimorfismo - overload do método acima
        public override int Attack(int index)
        {
            Console.WriteLine($"{name} ataca com o feitiço {attackSpells.GetItemAt(index).GetName()}!");
            int tempDamage = damage + attackSpells.GetItemAt(index).GetDamageChange();
            this.LoseMagicka(attackSpells.GetItemAt(index).GetMagickaChange());
            return tempDamage;
        }

        public override int Defend()
        {
            return defense;
        }

        public override int Defend(int index)
        {
            Console.WriteLine($"{name} defende com o feitiço {defenseSpells.GetItemAt(index).GetName()}!");
            int tempDefense = defense + defenseSpells.GetItemAt(index).GetDefenseChange();
            return tempDefense;
        }
    }
}
