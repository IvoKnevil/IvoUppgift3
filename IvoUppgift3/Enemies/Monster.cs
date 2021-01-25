using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies
{
    abstract class Monster
    {
        private int hp;
        private bool dead;
        private string Name;
        private int level;

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


        public virtual int monsterLevel(int playerLevel)
        {
            this.level = playerLevel;
            return this.level;
        }


    }
}
