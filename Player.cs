using System;
using System.Reflection.PortableExecutable;

namespace OOP2{
    public class Player 
    {
        public string? name { get; private set; }
        public IBonusType classType {get; private set; }
        public IBonusType raceType { get; private set; }

        public Attribute attackDamage { get; private set; }
        public Attribute defence { get; private set;}
        public Attribute critChance { get; private set; }
        public Attribute critDamage { get; private set; } 
        public Attribute healthPoints { get; private set; } 

        public Player(string playerName, IBonusType classType, IBonusType raceType){
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
            
            healthPoints = new Attribute(100);
            healthPoints.AddAttributeBonuses(classType.healthPoints);
            healthPoints.AddAttributeBonuses(raceType.healthPoints);

        }

        void updateAttributeBonus(IBonusType IBonusType)
        {


            
        } 
    }
}
