using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class Batman : Monster
    {

        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { "uses one of his toys to attempt to stop you",
            "uses his idiotic voice to try to scare you",
            "calls his buddy Robin to help him out",
            "tries to punch you" };


        public string Name { get { return "Batman"; } }



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
