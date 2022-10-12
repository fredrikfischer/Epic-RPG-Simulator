using System;

namespace OOP2 {
    class Warrior : BonusType
    {   

       public Warrior(){
            name = "Warrior";
            description = "A warrior is a brave and heroic character. It is a meelee character with excellent fighting capabillities.";
            //attackDamage = new AttributeBonus();
            defence.Add(20);
            //critChance = new AttributeBonus();
            //critDamage = new AttributeBonus();
            maxHp.Add(30);
            currentHp.Add(30);
       }
    }
}