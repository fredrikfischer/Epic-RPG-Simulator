using System;

namespace OOP2
{

    public class Item
    {

        public string name {get; private set;}
        public int value {get; private set;}
        public string type {get; private set;}
        public int cost {get; private set;}

        public Item(string name, int value, string type, int cost)
        {
            this.name = name;
            this.value = value;
            this.type = type;
            this.cost = cost;



        }

        
    }
    
}