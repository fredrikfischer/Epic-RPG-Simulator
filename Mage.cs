using System;

namespace OOP2 {
    class Mage : BonusType
    { 
        
        public Mage(){
            name = "Mage";
            description = "A mage is an expert in the art of spells and magic. It is a ranged fighter with high damage capabillities.";
            attackDamage = new AttributeBonus(10);
            //defence = new AttributeBonus();
            critChance = new AttributeBonus(0.1);
            critDamage = new AttributeBonus(0.1);
            //maxHp = new AttributeBonus();
            currentHp = new AttributeBonus();

        }
    }
}