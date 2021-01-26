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
            "says her pension is low", "gives you an angry look",
            "tries to bore to death with a story about her stupid grandkids"};


        public string Name { get { return "Nice old lady"; } }

        public override string UseUniqueMoves()
        {
            return listOfUniqueMoves[random.Next(4)];
        }


        public override string ToString()
        {
            return Name;
        }
    }
}

