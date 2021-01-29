using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class TrashMob : Monster
    {
        private int atkDmg = 7;
        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { "tries to kick you",
            "pushes you",
            "actually tries to punch you",
            "begs you to stop" };


        public string Name { get { return "Random dude"; } }

        public int Gold { get; set; }
        public int Xp { get; set; }


        //Method to show different attacks in the battle screen
        //Monster unique attacks saved within the listOfUniqueMoves
        public override string UseUniqueMoves()
        {
            return listOfUniqueMoves[random.Next(listOfUniqueMoves.Count)];
        }

        public override string ToString()
        {
            return Name;
        }

        public override int Attack(int level)
        {
            if (random.Next(atkDmg) == 1 || random.Next(atkDmg) == 2)
            {
                return random.Next(10, 15) * level;
            }
            else
            {
                return random.Next(atkDmg * level);
            };
        }

        public override int DropGold()
        {
            this.Gold = random.Next(15, 30);
            return Gold;
        }

        public override int GiveXp()
        {
            this.Xp = random.Next(22, 35);
            return Xp;
        }
    }
}
