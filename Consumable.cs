using System;

namespace OOP2
{

    public class Consumable : Item
    {

        public int healValue {get; set; }

        public Consumable(string name, int cost, int healValue) : base(name, cost)
        {
            this.healValue = healValue;
        }
    }    
}