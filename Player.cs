using System;
using System.Reflection.PortableExecutable;

namespace OOP2{
    public class Player 
    {
        public string? name { get; private set; }
        public BonusType classType {get; private set; }
        public BonusType raceType { get; private set; }

        public Attribute attackDamage { get; set; }
        public Attribute defence { get; set;}
        public Attribute critChance { get; set; }
        public Attribute critDamage { get; set; } 
        public Attribute maxHp { get; set; } 
        public double currentHp { get; set; } 

        public Player(string playerName, BonusType classType, BonusType raceType){
            name = playerName;
            this.classType = classType;
            this.raceType = raceType; 
            //this.attackDamage.Add(raceType.attackDamage);

            attackDamage = new Attribute(50);
            attackDamage.AddAttributeBonuses(classType.attackDamage);
            attackDamage.AddAttributeBonuses(raceType.attackDamage);

            defence = new Attribute(30);
            defence.AddAttributeBonuses(classType.defence);
            defence.AddAttributeBonuses(raceType.defence);

            attackDamage = new Attribute(50, classType.attackDamage, raceType.attackDamage);
            defence = new Attribute(30, classType.defence, raceType.defence);
            critChance = new Attribute(0.1, classType.critChance, raceType.critChance);
            critDamage = new Attribute(0.1, classType.critDamage, raceType.critDamage);
            maxHp = new Attribute(100, classType.maxHp, raceType.maxHp);
            currentHp = maxHp.value;
        }

        void updateAttributeBonus(BonusType bonusType)
        {


            
        } 
    }
}