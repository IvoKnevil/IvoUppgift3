using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Shop
{
    class Store
    {

        private int storeCredit;
        List<string> listOfClerks = new List<string>() { "Dan Eliasson", "Darth Vader", "Ivan Drago" };
        Random random = new Random();

        public int StoreCredit { get; set; }

        public Store()
        {

        }

        public int TakeGold(int goldReceived)
        {
            StoreCredit += goldReceived;
            return this.StoreCredit;
        }

        public string StoreClerk()
        {
            return listOfClerks[random.Next(listOfClerks.Count)];
        }

    }
}
