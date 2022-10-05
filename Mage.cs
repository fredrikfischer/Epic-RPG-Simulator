using System;

namespace OOP2 {
    class Mage : Info
    { 

       public Mage(){
            classTypeName = "Mage";
            attackDamage = 60;
            defence = 5;
            critChance = 0.20;
            critDamage = 1.20;
            hp = 80;
        }
    }
}