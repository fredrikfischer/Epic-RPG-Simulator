using System;

namespace OOP2
{
    abstract public class BonusType 
    {
        public string name;
        public string description;
        public AttributeBonus attackDamage;
        public AttributeBonus defence;
        public AttributeBonus critChance;
        public AttributeBonus critDamage;
        public AttributeBonus healthPower;

        public BonusType() {
            name = "N/A";
            description = "N/A";
            attackDamage = new AttributeBonus();
            defence = new AttributeBonus();
            critChance = new AttributeBonus();
            critDamage = new AttributeBonus();
            healthPower = new AttributeBonus();
        }
        


    }
}