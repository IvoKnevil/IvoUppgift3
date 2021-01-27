﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class HarryPotter : Monster
    {

        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { "looks at you with that stupid face. It makes you sick",
            "says some jibberish thats apparently \"magic\". God how sad",
            "throws some magic powder at you",
            "cries to his turd friends to stop you" };


        public string Name { get { return "Harry Potter"; } }



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
