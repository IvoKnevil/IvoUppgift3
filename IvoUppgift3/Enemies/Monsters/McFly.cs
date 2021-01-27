using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies.Monsters
{
    class McFly : Monster
    {

        Random random = new Random();
        List<string> listOfUniqueMoves = new List<string>()
        { "plays guitar so it hurts your ears",
            "it turns out he has a thing for his mum. It makes you sick",
            "skates around you so you get dizy",
            "tries to go back to the future and the car almost runs you over" };


        public string Name { get { return "Marty McFly"; } }



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
