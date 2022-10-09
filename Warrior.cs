using System;

namespace OOP2 {
    class Warrior : ClassType
    {   

       public Warrior(){
            name = "Warrior";
            description = "A warrior is a brave and heroic character. It is a meelee character with excellent fighting capabillities.";
            defence = new AttributeBonus(20);
            maxHp = new AttributeBonus(30);
            currentHp = new AttributeBonus(30);
       }
    }
}