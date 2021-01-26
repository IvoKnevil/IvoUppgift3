using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class NiceOldLady : Monster
    {


        private List<string> listOfUniqueMoves = new List<string>()
        { "tries to tell you a story about WW2",
            "hopes you will be compassionate about her hip pain",
            "says her pension is low", "gives you an angry look" };


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

