using System;

namespace OOP2
{

    public class HealingSalve : Item
    {

        public int healValue {get; set; }

        public HealingSalve(string name, int cost, int healValue) : base(name, cost)
        {
            this.healValue = healValue;
        }
    }    
}