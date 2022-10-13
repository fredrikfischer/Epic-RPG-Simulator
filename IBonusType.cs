using System;

namespace OOP2
{
    public interface IBonusType 
    {
        public string name { get; }
        public string description { get; }
        public AttributeBonus attackDamage { get; }
        public AttributeBonus defence { get; }
        public AttributeBonus critChance { get; }
        public AttributeBonus critDamage { get; }
        public AttributeBonus healthPoints { get; }
    }
}