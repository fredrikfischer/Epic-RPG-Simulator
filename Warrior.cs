using System;

namespace OOP2 {
    class Warrior : BonusType
    {   

       public Warrior(){
            name = "Warrior";
            description = "A warrior is a brave and heroic character. It is a meelee character with excellent fighting capabillities.";
            //attackDamage = new AttributeBonus();
            defence = new AttributeBonus(20);
            //critChance = new AttributeBonus();
            //critDamage = new AttributeBonus();
            maxHp = new AttributeBonus(30);
            currentHp = new AttributeBonus(30);
       }
    }
}