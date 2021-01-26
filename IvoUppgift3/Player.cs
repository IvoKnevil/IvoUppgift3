using IvoUppgift3.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3
{
    class Player
    {

        private string name;
        private int level = 1;
        private bool dead;
        private int hp = 100;
        private int atkDmg = 10;
        private int dmgDone;

        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { "You bitchslap",
            "You headbutt",
            "You use your knife to cut",
            "You elbow the crap out of" };


        public Player()
        {

        }

        public Player(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        
        public int attack(Monster monster)
        {
            if (random.Next(atkDmg) == 1 || random.Next(atkDmg) == 2)
            {
                dmgDone = random.Next(30,33) * level;
            }
            else
            {
                dmgDone = random.Next(AtkDmg * Level);
            }
            monster.takeDamage(dmgDone);
            return dmgDone;
        }
        

        public string Name { get => name; set => name = value; }

        public int Level { get => level; set => level = value; }

        public int Hp { get => hp; set => hp = value; }
        public int AtkDmg { get => atkDmg; set => atkDmg = value; }

        public void takeDamage(int monsterdmg)
        {
            hp -= monsterdmg;
        }

        public string UseUniqueMoves()
        {
            return listOfUniqueMoves[random.Next(3)];
        }

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

        public override string ToString()
        {
            return ($"{name}");
        }
    }
}
