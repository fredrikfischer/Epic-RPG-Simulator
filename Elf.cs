using System;

namespace OOP2
{
    class Elf : BonusType
    {
        public Elf()
        {
            name = "Elf";
            description = "Elfs are cool";

            attackDamage.Add(10);
            //defence = new AttributeBonus();
            critChance.Add(0.5);
            critDamage.Add(0.5);
            //maxHp = new AttributeBonus();
            //currentHp = new AttributeBonus();
        }
    }
}
