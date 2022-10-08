using System;

namespace OOP2 {
    public class Attributes
    { 
        
        public Attribute attackDamage { get; set; }
        public Attribute defence { get; set;}
        public Attribute critChance { get; set; }
        public Attribute critDamage { get; set; } 
        public Attribute maxHp { get; set; } 
        public Attribute currentHp { get; set; } 
        //maybe public int level { get; set;}
        
       public Attributes(){
        attackDamage = new Attribute(50, 0, 0);
        defence = new Attribute(30, 0, 0);
        critChance = new Attribute(0.1, 0);
        critDamage = new Attribute(0.1, 0);
        maxHp = new Attribute(100, 0, 0);
        currentHp = new Attribute(100, 0, 0);
        //maybe public int level { get; set;}
        }
    }
}