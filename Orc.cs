using System;
namespace OOP2
{
    class Orc : IBonusType
    {
        public string name { get; private set; }
        public string description { get; private set; }
        public AttributeBonus attackDamage { get; private set; }
        public AttributeBonus defence { get; private set; }
        public AttributeBonus critChance { get; private set; }
        public AttributeBonus critDamage { get; private set; }
        public AttributeBonus healthPoints { get; private set; }
        public Orc()
        {
            name = "Orc";
            description = "An Orc is a vicous creature from the deeps of darkness. It has a large and ugly apperance with oily black, brown and greenish type skin and large fangs! Its characteristics makes it good at tolerating incoming damage";
            
            attackDamage = new AttributeBonus(0.05);
            defence = new AttributeBonus();
            critChance = new AttributeBonus(0.05);
            critDamage = new AttributeBonus(0.05);
            healthPoints = new AttributeBonus(10);

        }



    }
}

