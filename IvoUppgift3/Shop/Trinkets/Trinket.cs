using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Shop.Trinkets
{
    class Trinket : Items
    {

        public Trinket(string name, int price, int critChance)
        {
            this.Name = name;
            this.Price = price;
            this.CritChance = critChance;
        }

    }
}
