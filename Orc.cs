using System;
namespace OOP2
{
    class Orc : BonusType
    {
        public Orc()
        {
            name = "Orc";
            description = "An Orc is a vicous creature from the deeps of darkness. It has a large and ugly apperance with oily black, brown and greenish type skin and large fangs! Its characteristics makes it good at tolerating incoming damage";
            
            //attackDamage = new AttributeBonus(0.05);
            defence.Add(0.1);
            //critChance = new AttributeBonus(0.05);
            //critDamage = new AttributeBonus(0.05);
            healthPower.Add(10);

        }



    }
}

