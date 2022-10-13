using System;

namespace OOP2 {
    class Mage : IBonusType
    { 
        public string name { get; private set; }
        public string description { get; private set; }
        public AttributeBonus attackDamage { get; private set; }
        public AttributeBonus defence { get; private set; }
        public AttributeBonus critChance { get; private set; }
        public AttributeBonus critDamage { get; private set; }
        public AttributeBonus healthPoints { get; private set; }
        
        public Mage(){
            name = "Mage";
            description = "A mage is an expert in the art of spells and magic. It is a ranged fighter with high damage capabillities.";
            attackDamage = new AttributeBonus(20);
            defence = new AttributeBonus();
            critChance = new AttributeBonus(0.5);
            critDamage = new AttributeBonus(0.5);
            healthPoints = new AttributeBonus();
        }
    }
}