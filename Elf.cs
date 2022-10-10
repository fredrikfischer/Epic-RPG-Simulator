using System;

namespace OOP2
{
    class Elf : BonusType
    {
        public Elf()
        {
            name = "Elf";
            description = "Elfs are cool";

            attackDamage = new AttributeBonus(10);
            //defence = new AttributeBonus();
            critChance = new AttributeBonus(0.05);
            critDamage = new AttributeBonus(0.05);
            //maxHp = new AttributeBonus();
            currentHp = new AttributeBonus();
        }
    }
}
