using System;

namespace OOP2{

    public abstract class Character {
        public string? name { get; set; } = "unnamed";
        public ClassType? classType { get; set; }
        public RaceType? raceType { get; set; }
        public double attackDamage { get; set; }
        public double defence { get; set;}
        public double critChance { get; set; }
        public double critDamage { get; set; } 
        public double hp { get; set; } 

        public double Attack(){
            //Calculates crit
            Random rnd = new Random();
            if(rnd.NextDouble() < critChance){
                Console.WriteLine("Crit! ");
                return attackDamage * critDamage;
            }else{
                return attackDamage;
            }

        }
        
    }
}