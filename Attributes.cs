using System;

namespace OOP2 {
    abstract class Attributes
    { 
        public double attackDamage { get; set; }
        public double defence { get; set;}
        public double critChance { get; set; }
        public double critDamage { get; set; } 
        public double hp { get; set; } 
        public int level { get; set;}
        
       public Attributes(){
            
        }
    }
}