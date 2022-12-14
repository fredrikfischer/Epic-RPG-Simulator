using System;
using System.Collections.Generic;

namespace OOP2 {
    public class Attribute
    { 
        public AttributeBonus attributeBonus;
        public double baseValue { get; private set; }
        public double currentValue { get; private set; }
        public double value { get => CalculateValue(); private set { this.value = value; }  } 
        
        public Attribute(int baseValue){   
            attributeBonus = new AttributeBonus();
            this.baseValue = baseValue;
            currentValue = CalculateValue();
        }

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

        public void ReduceCurrentValue(double incomingDamage)
        {
            currentValue -= incomingDamage;
        }

        public double CalculateValue()
        {
            return (baseValue + attributeBonus.bonusRawList.Sum()) * (1 + attributeBonus.bonusMultiplyerList.Sum());
        }    

        public void ResetHealth(Player player)
        {
            currentValue = baseValue;

        }

        public void AddToCurrentValue(int value)
        {
            currentValue += value;
        }
        public void AddToBaseValue(int valuee)
        {
            baseValue += valuee;
            currentValue += valuee;
        }

    }
}