using System;

namespace OOP2
{

    public class Item
    {

        public string name { get; private set; }
        public int cost { get; private set; }

        public Item(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}