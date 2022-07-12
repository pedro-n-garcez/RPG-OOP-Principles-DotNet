using System;
using System.Collections.Generic;

namespace Tentod
{
    //Hero herda da classe abstrata Character
    public class Hero : Character
    {
        public Hero(string name)
        {
            this.name = name;
            this.alive = true;
            this.level = 1;
            this.damage = 5;
        }

        //habilidades aumentam pelo numero do level
        public virtual void LevelUp()
        {
            this.level++;
            GainHealth(this.level);
            GainDamage(this.level);
            GainDefense(this.level);
            GainMagicka(this.level);
        }

        public virtual int Attack(int index)
        {
            return this.damage;
        }

        public virtual int Defend(int index)
        {
            return this.defense;
        }
    }
}
