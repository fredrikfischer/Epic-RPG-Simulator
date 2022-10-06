using System;

namespace OOP2{

    public abstract class Character {
        public string? name { get; set; }
        public ClassType? classType { get; set; }
        public RaceType? raceType { get; set; }
        public double attackDamage { get; set; }
        public double defence { get; set;}
        public double critChance { get; set; }
        public double critDamage { get; set; } 
        public double maxHp { get; set; } 
        public double currentHp { get; set; } 

        public double Attack(){
            //Calculates crit
            Random rnd = new Random();
            if(rnd.NextDouble() < critChance){
                Console.WriteLine("It's a critical hit! ");
                return attackDamage * (1 + critDamage);
            }else{
                return attackDamage;
            }

        }
        
    }
}