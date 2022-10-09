using System;
using System.Reflection.PortableExecutable;

namespace OOP2{
    public class Player : IAttributes
    {
        public string? name { get; set; }
        public ClassType classType { get; set; }
        public RaceType raceType { get; set; }

        public Attribute attackDamage { get; set; }
        public Attribute defence { get; set;}
        public Attribute critChance { get; set; }
        public Attribute critDamage { get; set; } 
        public Attribute maxHp { get; set; } 
        public Attribute currentHp { get; set; } 

        public Player(string playerName, ClassType classType, RaceType raceType){
            name = playerName;
            this.classType = classType;
            this.raceType = raceType; 
            
            attackDamage = new Attribute(50);
            defence = new Attribute(30);
            critChance = new Attribute(0.1);
            critDamage = new Attribute(0.1);
            maxHp = new Attribute(100);
            currentHp = new Attribute(100);
            
        }

        void updateAttributeBonus(ClassType classType){
            
            
        } 
    }
}