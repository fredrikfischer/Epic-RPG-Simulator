using System;

namespace OOP2
{
    abstract public class ClassType 
    {
        public string? name;
        public string? description;
        public AttributeBonus attackDamage;
        public AttributeBonus defence;
        public AttributeBonus critChance;
        public AttributeBonus critDamage;
        public AttributeBonus maxHp;
        public AttributeBonus currentHp;

        public ClassType() {
            attackDamage = new AttributeBonus();
            defence = new AttributeBonus();
            critChance = new AttributeBonus();
            critDamage = new AttributeBonus();
            maxHp = new AttributeBonus();
            currentHp = new AttributeBonus();
        }
        


    }
}