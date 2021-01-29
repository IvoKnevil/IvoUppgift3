using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Shop.Trinkets
{
    class Items
    {

        private int strenght;
        private int toughness;
        private int critChance;
        private int price;
        private string name;

        public int Strenght { get; set; }

        public int Toughness { get; set; }

        public int CritChance { get; set; }

        public int Price { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public virtual void ShowDetalis()
        {

            Console.WriteLine("___________________________________\n");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Strenght: {Strenght}");
            Console.WriteLine($"Toughness: {Toughness}");
            Console.WriteLine($"Crit increase {CritChance}");
            Console.WriteLine($"Price {Price}");
            Console.WriteLine("___________________________________\n\n");

        }
    }
}
