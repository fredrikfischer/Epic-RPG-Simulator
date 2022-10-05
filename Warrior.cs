using System;

namespace OOP2 {
    class Warrior : Charachter
    {   

       public Warrior(){
            classTypeName = "Warrior";
            attackDamage = 40;
            defence = 30;
            critChance = 0.05;
            critDamage = 1.05;
            hp = 120;
       }
    }
}