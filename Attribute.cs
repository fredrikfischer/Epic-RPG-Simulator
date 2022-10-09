using System;
using System.Collections.Generic;

namespace OOP2 {
    public class Attribute
    { 
        AttributeBonus attributeBonus;
        double baseValue;
        public double value { get => CalculateValue(); set => value = this.baseValue; } 

        public Attribute(int baseValue){
            attributeBonus = new AttributeBonus();
            this.baseValue = baseValue;
        }

        public Attribute(double baseValue){
            attributeBonus = new AttributeBonus();
            this.baseValue = baseValue;
        }

        public double CalculateValue(){
            return (baseValue + attributeBonus.bonusRaw) * 1 + attributeBonus.bonusMultiplyer;
        }
        
    }
}