using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class ObiWan : Monster
    {

        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { "tells you to be mindful of yout thoughts. They betray you",
            "says \"so uncivilized\"",
            "tells you that only Sith deals in absolutes",
            "says \"If you strike me down, I shall become more powerful than you can possibly imagine\"" };


        public string Name { get { return "Obi Wan Kenobi"; } }



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
