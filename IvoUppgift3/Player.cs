using IvoUppgift3.Enemies;
using IvoUppgift3.Shop.Trinkets;
using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3
{
    class Player
    {

        private string name;
        private int level;
        private bool dead;
        private int hp;
        private int hpCoef;
        private int atkDmg = 10;
        private int dmgDone;
        private int xp;
        private int gold;
        private int strenght;
        private int toughness;
        private int critChance;

        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { "You bitchslap",
            "You headbutt",
            "You use your knife to cut",
            "You elbow the crap out of" };
        List<Items> equippedItems = new List<Items>();


        public Player()
        {

        }

        public Player(string name, int level, int hpCoef, int strenght, int toughness, int critChance, int gold)
        {
            this.name = name;
            this.level = level;
            this.hpCoef = hpCoef;
            this.strenght = strenght;
            this.toughness = toughness;
            this.critChance = critChance;
            this.gold = gold;
        }

        public string Name { get => name; set => name = value; }

        public int Level { get => level; set => level = value; }

        public int Hp { get => hp; set => hp = value; }

        public int HpCoef { get => hpCoef; set => hpCoef = value;  }

        public int AtkDmg { get => atkDmg; set => atkDmg = value; }

        public int Xp { get => xp; set => xp = value; }

        public int Gold { get => gold; set => gold = value; }

        public int Strenght { get => strenght; set => strenght = value; }

        public int Toughness { get => toughness; set => toughness = value; }

        public int CritChance { get => critChance; set => critChance = value; }


        public int Attack(Monster monster)
        {
            if (random.Next(atkDmg) == 1 || random.Next(atkDmg) == 2)
            {
                dmgDone = random.Next((28 + CritChance),(35 + CritChance)) * level;
            }
            else
            {
                dmgDone = random.Next((AtkDmg + Strenght) * Level);
            }
            monster.TakeDamage(dmgDone);
            return dmgDone;
        }
        

        public void TakeDamage(int monsterdmg)
        {
            hp -= monsterdmg + Toughness;
        }

       
        public int HealthPoints(int playerLevel)
        {

            this.hp = HpCoef * playerLevel;
            return hp;
        }
        

        public int GetHp()
        {
            return this.hp;
        }

        public string UseUniqueMoves()
        {
            return listOfUniqueMoves[random.Next(listOfUniqueMoves.Count)];
        }

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

        public int GetGold(int lootGold)
        {
            Gold += lootGold;
            return this.Gold;
        }

        public int GainXp(int receiveXp)
        {
            Xp += receiveXp;
            return this.Xp;
        }

        public int GiveGold(int goldToPay)
        {
            Gold -= goldToPay;
            return this.Gold;
        }

        public int ResetXp ()
        {
            this.Xp = 0;
            return Xp;
        }

        
        public void EquipItems(Items purchasedItem)
        {
            Strenght += purchasedItem.Strenght;
            Toughness += purchasedItem.Toughness;
            CritChance += purchasedItem.CritChance;
        }
        

        public override string ToString()
        {
            return ($"{name}");
        }
    }
}
