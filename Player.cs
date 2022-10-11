using System;
using System.Reflection.PortableExecutable;

namespace OOP2{
    public class Player : IAttributes
    {
        public string? name { get; set; }
        public BonusType classType { get; set; }
        public BonusType raceType { get; set; }

        public Attribute attackDamage { get; set; }
        public Attribute defence { get; set;}
        public Attribute critChance { get; set; }
        public Attribute critDamage { get; set; } 
        public Attribute maxHp { get; set; } 
        public Attribute currentHp { get; set; } 

        public Player(string playerName, BonusType classType, BonusType raceType){
            name = playerName;
            this.classType = classType;
            this.raceType = raceType; 

            attackDamage = new Attribute(50, classType.attackDamage, raceType.attackDamage);
            defence = new Attribute(30, classType.defence, raceType.defence);
            critChance = new Attribute(0.1, classType.critChance, raceType.critChance);
            critDamage = new Attribute(0.1, classType.critDamage, raceType.critDamage);
            maxHp = new Attribute(100, classType.maxHp, raceType.maxHp);
            currentHp = new Attribute(100, classType.maxHp, raceType.maxHp);
        }

        void updateAttributeBonus(BonusType bonusType){
            
        } 
    }
}