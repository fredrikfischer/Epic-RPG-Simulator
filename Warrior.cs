using System;

namespace OOP2 {
    class Warrior : IBonusType
    {   
        public string name { get; private set; }
        public string description { get; private set; }
        public AttributeBonus attackDamage { get; private set; }
        public AttributeBonus defence { get; private set; }
        public AttributeBonus critChance { get; private set; }
        public AttributeBonus critDamage { get; private set; }
        public AttributeBonus healthPoints { get; private set; }

       public Warrior(){
            name = "Warrior";
            description = "A warrior is a brave and heroic character. It is a meelee character with excellent fighting capabillities.";
            attackDamage = new AttributeBonus();
            defence = new AttributeBonus(20);
            critChance = new AttributeBonus();
            critDamage = new AttributeBonus();
            healthPoints = new AttributeBonus(30);

       }
    }
}