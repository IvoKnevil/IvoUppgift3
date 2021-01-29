using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies
{
    abstract class Monster : IEnemy
    {
        private int hp;
        private bool dead;
        private string name;
        private int atkDmg = 10;
        private int gold;
        private int xp;
        Random random = new Random();



        public virtual bool IsDead()
        {
            if (this.hp <= 0)
            {
                this.dead = true;
            }
            else
            {
                this.dead = false;
            }

            return this.dead;
        }


        public virtual int Attack(int level)
        {
            if (random.Next(atkDmg) == 1 || random.Next(atkDmg) == 2)
            {
                return random.Next(20, 26) * level;
            }
            else
            {
                return random.Next(atkDmg * level);
            }
        }

        public virtual int GetHp()
        {
            return this.hp;
        }

        public virtual void TakeDamage(int damage)
        {
            this.hp -= damage;
        }


        public virtual int HealthPoints(int playerLevel)
        {

            this.hp = 100 * playerLevel;
            return hp;
        }


        //Method to show different attacks in the battle screen
        //Method is abstract so each created monster has to create the method
        //Monster unique attacks saved within the listOfUniqueMoves within each subclass

        public abstract string UseUniqueMoves();
        
        public virtual int DropGold()
        {
            this.gold = random.Next(60,100);
            return gold;
        }

        public virtual int GiveXp()
        {
            this.xp = random.Next(59, 80);
            return xp;
        }
    }
}
