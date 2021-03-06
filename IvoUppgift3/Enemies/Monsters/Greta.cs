﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class Greta : Monster
    {
        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { "tries to hit you with info about polar ice melting",
            "tries to move you by saying how many species have gone extinct",
            "tries to get you to stop by saying the planet's average surface temperature has risen over one degree",
            "gives you an angry teenage look" };

 
        public string Name { get { return "Greta"; } }


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
