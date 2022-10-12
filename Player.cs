using System;
using System.Reflection.PortableExecutable;

namespace OOP2{
    public class Player 
    {
        public string? name { get; private set; }
        public BonusType classType {get; private set; }
        public BonusType raceType { get; private set; }

        public Attribute attackDamage { get; private set; }
        public Attribute defence { get; private set;}
        public Attribute critChance { get; private set; }
        public Attribute critDamage { get; private set; } 
        public Attribute healthPower { get; private set; } 

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

            critChance = new Attribute(0.1);
            critChance.AddAttributeBonuses(classType.critChance);
            critChance.AddAttributeBonuses(raceType.critChance);

            critDamage = new Attribute(0.1);
            critDamage.AddAttributeBonuses(classType.critDamage);
            critDamage.AddAttributeBonuses(raceType.critDamage);
            
            healthPower = new Attribute(100);
            healthPower.AddAttributeBonuses(classType.healthPower);
            healthPower.AddAttributeBonuses(raceType.healthPower);

        }

        void updateAttributeBonus(BonusType bonusType)
        {


            
        } 
    }
}
