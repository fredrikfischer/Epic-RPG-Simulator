using System;

namespace OOP2{
    public abstract class Charachter{
        public string? name { get; set; } 
        public string? classTypeName { get; set; } 
        public double attackDamage{ get; set; }
        public double defence { get; set; }
        public double critChance {get; set;}
        public double critDamage {get; set;}
        public double hp { get; set;}

        public double Attack(){
            //Calculates crit
            Random rnd = new Random();
            if(rnd.NextDouble() < critChance){
                return attackDamage * critDamage;
            }else{
                return attackDamage;
            }

        }
        
    }
}