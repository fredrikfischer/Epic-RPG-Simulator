using System;
using System.Collections.Generic;

namespace OOP2 {
    public class Attribute
    { 
        public AttributeBonus attributeBonus;
        double baseValue;
        public double currentValue { get; private set; }
        public double value { get => CalculateValue(); private set { this.value = value; }  } 
        

        // For monster
        public Attribute(int baseValue){   
            attributeBonus = new AttributeBonus();
            this.baseValue = baseValue;
            currentValue = CalculateValue();
        }
        // For monster
        public Attribute(double baseValue){   
            attributeBonus = new AttributeBonus();
            this.baseValue = baseValue;
            currentValue = CalculateValue();
        }

        public void AddAttributeBonuses(AttributeBonus attributeBonusLists)
        {
            if(0 < attributeBonusLists.bonusRawList.Sum())
            {
                this.attributeBonus.bonusRawList.Add(attributeBonusLists.bonusRawList.Sum());
                AddCurrentValue(attributeBonusLists.bonusRawList.Sum());
            }

            if(0 < attributeBonusLists.bonusMultiplyerList.Sum())
            {
                this.attributeBonus.bonusMultiplyerList.Add(attributeBonusLists.bonusMultiplyerList.Sum());
                AddCurrentValue(attributeBonusLists.bonusRawList.Sum());
            }   
        }

        public void AddCurrentValue(double incomingDamage)
        {
            currentValue += incomingDamage;
        }

        public void reduceCurrentValue(double incomingDamage)
        {
            currentValue -= incomingDamage;1
        }

        public double CalculateValue()
        {
            return (baseValue + attributeBonus.bonusRawList.Sum()) * (1 + attributeBonus.bonusMultiplyerList.Sum());
        }    
    }
}