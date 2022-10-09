using System;

namespace OOP2 {
    class Mage : ClassType
    { 
        
        public Mage(){
            name = "Mage";
            description = "A mage is an expert in the art of spells and magic. It is a ranged fighter with high damage capabillities.";
            attackDamage = new AttributeBonus(10);
            critChance = new AttributeBonus(0.1);
            critDamage = new AttributeBonus(0.1);

        }
    }
}