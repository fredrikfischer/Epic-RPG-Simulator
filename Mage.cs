using System;

namespace OOP2 {
    class Mage : BonusType
    { 
        
        public Mage(){
            name = "Mage";
            description = "A mage is an expert in the art of spells and magic. It is a ranged fighter with high damage capabillities.";
            attackDamage.Add(20);
            //defence = new AttributeBonus();
            critChance.Add(0.5);
            critDamage.Add(0.5);
            //maxHp = new AttributeBonus();
        }
    }
}