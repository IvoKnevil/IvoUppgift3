using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class MLK : Monster
    {

        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { "says \"A riot is the language of the unheard\"",
            "yells \"Free at last, Free at last, Thank God almighty we are free at last\"",
            "asks you \"Life's most persistent and urgent question is, 'What are you doing for others?\"",
            "claims \"We must learn to live together as brothers or perish together as fools\"" };


        public string Name { get { return "Martin Luther King, Jr"; } }



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
