using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class Greta : Monster
    {

        List<string> listOfUniqueMoves = new List<string>()
        { "tries to hit you with info about polar ice melting",
            "tries to move you by saying how many species have gone extinct",
            "tries to get you to stop by saying the planet's average surface temperature has risen over one degree",
            "gives you an angry teenage look" };

 
        public string Name { get { return "Greta"; } }

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
