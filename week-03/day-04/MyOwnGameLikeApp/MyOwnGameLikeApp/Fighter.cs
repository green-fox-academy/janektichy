using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnGameLikeApp
{
    class Fighter
    {
        protected string type;
        protected Gun gun;
        protected int health;
        protected int chanceToHit;
        protected int chanceToDodge;
        protected int power;
        protected string name;




        public void HitOrDodge(Fighter enemy)
        {
            Random random = new Random();
            int thisHitChance = this.chanceToHit + this.gun.hitUpgrade;
            int enemyChanceToDodge = enemy.chanceToDodge - enemy.gun.dodgeDowngrade;

            int hitDiceThrow = random.Next(0, 101);
            int dodgeDiceThrow = random.Next(0, 101);
            if (hitDiceThrow < thisHitChance && dodgeDiceThrow > enemyChanceToDodge)
            {
                Console.WriteLine($"That was a good hit by {this.name}");
                this.Hit(enemy);
            }
            else if (hitDiceThrow >= thisHitChance)
            {
                Console.WriteLine($"This hit was missed by {this.name}");
            }
            else
            {
                Console.WriteLine($"This hit was dodged by {enemy.name}");
            }
        }
        public void Hit(Fighter enemy)
        {
            enemy.health -= (this.power + this.gun.powerIncrease);
            enemy.ShowHealth();
        }
        public void Fight(Fighter enemy)
        {
            while (this.health > 0 && enemy.health > 0)
            {
                this.HitOrDodge(enemy);
                enemy.HitOrDodge(this);
                Console.WriteLine();
            }
            if (this.health <= 0)
            {
                Console.WriteLine($"{this.name} died, your fighter has lost the fight");
            }
            else
            {
                Console.WriteLine($"{enemy.name} died, your fighter has won the fight");
            }
        }
        public void ShowSkills()
        {
            Console.WriteLine($"Warrior name: {this.name}" +
                $"\nWarrior type: {this.type}" +
                $"\nHealth: {this.health}" +
                $"\nPower: {this.power + this.gun.powerIncrease}" +
                $"\nChance to Dodge: {this.chanceToDodge - this.gun.dodgeDowngrade}%" +
                $"\nChance to Hit: {this.chanceToHit + this.gun.hitUpgrade}%" +
                $"\nWeapon: {this.gun.type}");
        }
        public void ShowHealth()
        {
            Console.WriteLine($"{this.name} current health is {this.health}");
        }

    }
}
