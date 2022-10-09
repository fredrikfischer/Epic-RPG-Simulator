using System;

namespace OOP2 {
    public interface IAttributes
    { 
        
        public Attribute attackDamage { get; set; }
        public Attribute defence { get; set;}
        public Attribute critChance { get; set; }
        public Attribute critDamage { get; set; } 
        public Attribute maxHp { get; set; } 
        public Attribute currentHp { get; set; } 
        //maybe public int level { get; set;}
        

    }
}