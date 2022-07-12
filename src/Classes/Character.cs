using System;

namespace Tentod
{
    public abstract class Character
    {
        protected string name { get; set; }
        protected int level { get; set; }
        protected string characterType { get; set; }
        protected bool alive { get; set; }
        protected int health { get; set; }
        protected int damage { get; set; }
        protected int defense { get; set; }
        protected int magicka { get; set; }

        public Character()
        {
            this.alive = true;
        }

        public int GetHealth()
        {
            return this.health;
        }

        public bool GetStatus()
        {
            if (this.health <= 0)
            {
                this.alive = false;
                return alive;
            } 
            else 
            {
                return this.alive;
            }
        }

        public virtual void LoseHealth(int amount)
        {
            Console.WriteLine($"{name} recebeu ataque e perdeu {amount} de vida.");
            this.health -= amount;
        }

        public virtual void GainHealth(int amount)
        {
            Console.WriteLine($"{name} ganhou {amount} de vida.");
            this.health += amount;
        }

        public virtual void LoseMagicka(int amount)
        {
            Console.WriteLine($"{name} gastou {amount} de magicka.");
            this.magicka -= amount;
        }

        public virtual void GainMagicka(int amount)
        {
            Console.WriteLine($"{name} ganhou {amount} de magicka.");
            this.magicka += amount;
        }

        public virtual void GainDefense(int amount)
        {
            Console.WriteLine($"{name} ganhou {amount} de defesa.");
            this.defense += amount;
        }

        public virtual void GainDamage(int amount)
        {
            Console.WriteLine($"{name} ganhou {amount} de ataque.");
            this.damage += amount;
        }

        public virtual int Attack()
        {
            Console.WriteLine($"{name} ataca!");
            return damage;
        }

        public virtual int Defend()
        {
            return defense;
        }

        public override string ToString()
        {
            return $"{characterType} {name} de level {level}";
        }
    }
}
