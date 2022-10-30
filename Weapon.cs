using System;

namespace OOP2
{

    public class Weapon : Item
    {

        public int damage {get; set; }

        public Weapon(string name, int cost, int damage) : base(name, cost)
        {
            this.damage = damage;
        }
    }    
}