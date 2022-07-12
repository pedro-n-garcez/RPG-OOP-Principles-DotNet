using System;

namespace Tentod
{
    public class Item
    {
        protected string name { get; set; }
        protected ItemType itemType { get; set; }
        protected int damageChange { get; set; }
        protected int defenseChange { get; set; }
        protected int magickaChange { get; set; }
        protected int weight { get; set; }

        public Item (string name, ItemType itemType, int damageChange, int defenseChange, int magickaChange, int weight)
        {
            this.name = name;
            this.itemType = itemType;
            this.damageChange = damageChange;
            this.defenseChange = defenseChange;
            this.magickaChange = magickaChange;
            this.weight = weight;
        }

        public string GetName()
        {
            return this.name;
        }

        public ItemType GetItemType()
        {
            return this.itemType;
        }

        public int GetDamageChange()
        {
            return this.damageChange;
        }

        public int GetDefenseChange()
        {
            return this.defenseChange;
        }

        public int GetMagickaChange()
        {
            return this.magickaChange;
        }

        public int GetWeight()
        {
            return this.weight;
        }
    }
}
