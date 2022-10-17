using System;

namespace OOP2
{
    class Elf : IBonusType
    {
        public string name { get; private set; }
        public string description { get; private set; }
        public AttributeBonus attackDamage { get; private set; }
        public AttributeBonus defence { get; private set; }
        public AttributeBonus critChance { get; private set; }
        public AttributeBonus critDamage { get; private set; }
        public AttributeBonus healthPoints { get; private set; }
        public Elf()
        {
            name = "Elf";
            description = "Elfs are cool";
            attackDamage = new AttributeBonus(10);
            defence = new AttributeBonus();
            critChance = new AttributeBonus(0.5);
            critDamage = new AttributeBonus(0.5);
            healthPoints = new AttributeBonus();
            
        }
    }
}
