using System;

namespace OOP2 {
    class Mage : ClassType
    { 
        
        public Mage(){
            name = "Mage";
            description = "A mage is an expert in the art of spells and magic. It is a ranged fighter with high damage capabillities.";
            attackDamage = new Attribute(0, 10, 0);
            critChance = new Attribute(0, 0.1);
            critDamage = new Attribute(0, 0.1);
        }
    }
}