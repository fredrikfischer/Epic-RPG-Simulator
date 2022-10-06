using System;

namespace OOP2
{
    public abstract class RaceType 
    {
        public string name;
        public string description;
        public double attackDamage;
        public double defence;
        public double critChance;
        public double critDamage;
        public double maxHp;

        public RaceType()
        {
            name = "no name";
            description = "no description";
        }
    }
}