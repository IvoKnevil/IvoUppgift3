using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class Superman : Monster
    {

        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { "tries to laser you with his eyes",
            "flies around you like a fly around shit",
            "lifts a house and throws it in your direction",
            "tries to punch you at lightning speed" };


        public string Name { get { return "Superman"; } }



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
