using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3
{
    class Player
    {

        private string name;
        private int level = 1;
        private int gold;
        private int xp;
        private int xpToNextLevel = 150;
        private int hp = 200;
        private int atkDmg = 10;
        private bool isdead = true;

        public Player()
        {

        }

        public Player(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        /*
        public int attack(IMonster monster)
        {
            monster.takeDamage(AtkDmg);
            return AtkDmg;
        }
        */

        public string Name { get => name; set => name = value; }

        public int Level { get => level; set => level = value; }
        public int Gold { get => gold; set => gold = value; }
        public int Xp { get => xp; set => xp = value; }
        public int XpToNextLevel { get => xpToNextLevel; set => xpToNextLevel = value; }
        public int Hp { get => hp; set => hp = value; }
        public int AtkDmg { get => atkDmg; set => atkDmg = value; }
        public bool Isdead { get => isdead; set => isdead = value; }

        public void takeDamage(int monsterdmg)
        {
            hp -= monsterdmg;
        }

        public override string ToString()
        {
            return ($"{name}");
        }
    }
}
