using System;

namespace OOP2{

    public abstract class Character {
        public string? name { get; set; } = "unnamed";
        public ClassType? classType { get; set; }
        public RaceType? raceType { get; set; }
        public double attackDamage { get; set; } = 50;
        public double defence { get; set; } = 30;
        public double critChance { get; set; } = 0.1;
        public double critDamage { get; set; } = 1.1;
        public double hp { get; set; } = 100;

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