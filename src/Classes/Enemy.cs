using System;

namespace Tentod
{
    //Enemy herda da classe abstrata Character
    public class Enemy : Character
    {
        private Inventory weapon = new Inventory(ItemType.Weapon,100);
        private Inventory shield = new Inventory(ItemType.Shield,100);
        private Inventory attackSpell = new Inventory(ItemType.AttackSpell,100);
        private Inventory defenseSpell = new Inventory(ItemType.DefenseSpell,100);

        public Enemy(string name, string characterType, int level, int health, int damage, int magicka, int defense)
        {
            this.name = name;
            this.alive = true;
            this.characterType = characterType;
            this.level = level;
            this.health = health;
            this.damage = damage;
            this.magicka = magicka;
            this.defense = defense;
        }
    }
}
