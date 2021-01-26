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
        Random random = new Random();



        public virtual bool isDead()
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


        public virtual int attack(int level)
        {
            if (random.Next(atkDmg) == 1 || random.Next(atkDmg) == 2)
            {
                return random.Next(23, 28) * level;
            }
            else
            {
                return random.Next(atkDmg * level);
            }
        }

        public virtual int getHp()
        {
            return this.hp;
        }

        public virtual void takeDamage(int damage)
        {
            this.hp -= damage;
        }


        public virtual int HealthPoints(int playerLevel)
        {

            this.hp = 100 * playerLevel;
            return hp;
        }

        public abstract string UseUniqueMoves();
        

    }
}
