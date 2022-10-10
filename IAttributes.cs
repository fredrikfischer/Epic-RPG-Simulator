using System;

namespace OOP2 {
    interface IAttributes
    { 
        
        Attribute attackDamage { get; set; }
        Attribute defence { get; set;}
        Attribute critChance { get; set; }
        Attribute critDamage { get; set; } 
        Attribute maxHp { get; set; } 
        Attribute currentHp { get; set; } 
        //maybe public int level { get; set;}
        

    }
}