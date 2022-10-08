using System;

namespace OOP2 {
    class Warrior : ClassType
    {   

       public Warrior(){
            name = "Warrior";
            description = "A warrior is a brave and heroic character. It is a meelee character with excellent fighting capabillities.";
            defence = new Attribute(0, 20, 0);
            maxHp = new Attribute(0, 30, 0);
       }
    }
}