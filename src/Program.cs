using System;
using System.Collections.Generic;

namespace Tentod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar heróis
            Wizard wizard = new Wizard("Luna");
            Knight knight = new Knight("Sir Robin");
            Ninja ninja = new Ninja("Doshun");

            //Instanciar feiticos de wizard
            wizard.PickUpAttackSpell(new Item("Estaca de Gelo",ItemType.AttackSpell,5,0,1,2));
            wizard.PickUpAttackSpell(new Item("Bola de Fogo",ItemType.AttackSpell,7,0,2,3));
            wizard.PickUpAttackSpell(new Item("Raio",ItemType.AttackSpell,9,0,4,4));
            wizard.PickUpDefenseSpell(new Item("Vento",ItemType.DefenseSpell,0,3,1,2));
            wizard.PickUpDefenseSpell(new Item("Magia Refletora",ItemType.DefenseSpell,0,6,2,2));

            //Instanciar itens de knight
            knight.PickUpWeapon(new Item("Borduna",ItemType.Weapon,5,0,0,2));
            knight.PickUpWeapon(new Item("Espada de Gelo",ItemType.Weapon,7,0,0,3));
            knight.PickUpShield(new Item("Escudo de Madeira",ItemType.Shield,0,2,0,2));
            knight.PickUpShield(new Item("Escudo de Ferro",ItemType.Shield,0,5,0,4));

            //Instanciar itens de ninja
            ninja.PickUpWeapon(new Item("Uchigatana",ItemType.Weapon,9,0,0,5));
            ninja.PickUpWeapon(new Item("Sabre",ItemType.Weapon,12,0,0,4));

            //instanciar inimigo
            Enemy boss = new Enemy("Fulano","Cavaleiro do Mal",3,90,8,0,6);

            Console.Clear();

            Console.WriteLine("Bem vindo ao mundo de Tentod, onde heróis lutam contra forças do Mal!");
            Console.WriteLine($"A sua equipe vai enfrentar {boss.ToString()}!");
            
            //loop do jogo - continua até todos os heróis ou inimigo morrerem
            while ((wizard.GetStatus() || knight.GetStatus() || ninja.GetStatus()) && boss.GetStatus())
            {
                BattleAttack(knight,boss,knight.Weapons());
                BattleAttack(wizard,boss,wizard.AttackSpells());
                BattleAttack(ninja,boss,ninja.Weapons());

                BattleDefense(knight,boss,knight.Shields());
                BattleDefense(wizard,boss,wizard.DefenseSpells());
                BattleDefense(ninja,boss); //a classe Ninja nao usa escudos nem feitiços

                if (!boss.GetStatus())
                {
                    Console.WriteLine($"Vocês venceram a batalha!\n");
                    Console.WriteLine("LEVEL UP!\n");
                    knight.LevelUp();
                    wizard.LevelUp();
                    ninja.LevelUp();
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("The End");
        }

        static void BattleAttack(Hero hero, Enemy enemy, Inventory inv)
        {
            if (hero.GetStatus() && enemy.GetStatus())
            {
                Console.WriteLine($"É a vez de {hero.ToString()}.");
                inv.ListInventory();

                //se herói tiver items, usará o item escolhido
                if (inv.GetInventory().Count != 0)
                {
                    Console.Write("Escolha sua arma/feitiço de ataque: ");
                    int input = Int32.Parse(Console.ReadLine());
                    enemy.LoseHealth(hero.Attack(input));
                } else { //caso contrário usará habilidade padrão
                    Console.ReadKey();
                    enemy.LoseHealth(hero.Attack());
                }
            }
            Console.WriteLine();
        }

        static void BattleDefense(Hero hero, Enemy enemy)
        {
            if (hero.GetStatus() && enemy.GetStatus())
            {
                Console.WriteLine($"{enemy.ToString()} vai atacar {hero.ToString()}.");
                Console.WriteLine($"Você não tem itens de defesa. Aperte qualquer tecla para continuar.");

                Console.ReadKey();
                hero.LoseHealth(Math.Abs(enemy.Attack() - hero.Defend()));
            }
            Console.WriteLine();
        }

        //polimorfismo - overload do método acima
        static void BattleDefense(Hero hero, Enemy enemy, Inventory inv)
        {
            if (hero.GetStatus() && enemy.GetStatus())
            {
                Console.WriteLine($"É a vez de {enemy.ToString()}.");
                inv.ListInventory();

                if (inv.GetInventory().Count != 0)
                {
                    Console.Write("Escolha seu escudo/feitiço de defesa: ");
                    int input = Int32.Parse(Console.ReadLine());
                    hero.LoseHealth(Math.Abs(enemy.Attack() - hero.Defend(input)));
                } else {
                    Console.ReadKey();
                    hero.LoseHealth(Math.Abs(enemy.Attack() - hero.Defend()));
                }
            }
            Console.WriteLine();
        }
    }
}
