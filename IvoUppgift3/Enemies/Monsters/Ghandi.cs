using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class Ghandi : Monster
    {

        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { "says \"An eye for eye only ends up making the whole world blind\"",
            "says \"Where there is love there is life\"",
            "tells you to \"Hate the sin, love the sinner\"",
            "claims \"Action expresses priorities.\"" };


        public string Name { get { return "Ghandi"; } }


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

    }
}
