using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Shop.Trinkets
{
    class Ring : Items
    {


        public Ring (string name, int price, int toughness)
        {
            this.Name = name;
            this.Price = price;
            this.Toughness = toughness;
        }

    }
}
