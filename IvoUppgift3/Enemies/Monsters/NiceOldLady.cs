using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class NiceOldLady : Monster
    {

        Random random = new Random();
        private List<string> listOfUniqueMoves = new List<string>()
        { "tries to tell you a story about WW2",
            "hopes you will be compassionate about her hip pain",
            "says her pension is low", 
            "looks at you with a sad vunerable look",
            "tries to bore you to death with a story about her stupid grandkids"};


        public string Name { get { return "Nice old lady"; } }

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

