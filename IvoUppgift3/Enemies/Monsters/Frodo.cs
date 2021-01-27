using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class Frodo : Monster
    {

        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { " whiny bitch buddy Samwise whines to you",
            "looks at you with that idiotic annoying look",
            "uses some crappy piece of wood to try to hit you",
            "puts the ring on to try to do some damage" };


        public string Name { get { return "Frodo"; } }



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
