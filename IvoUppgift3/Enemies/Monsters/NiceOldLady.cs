using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class NiceOldLady : Monster
    {

        public int Level { get; set; }

        public string Name { get { return "Nice old lady"; } }




        public override int monsterLevel(int playerLevel)
        {
            this.Level = playerLevel;
            return this.Level;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

