using System;
using System.Collections.Generic;

namespace OOP2 {
    public class Attribute
    { 
        AttributeBonus attributeBonus;
        double baseValue;
        public double value { get => CalculateValue(); set => value = this.baseValue; } 


        public Attribute(int baseValue, AttributeBonus classBonus, AttributeBonus raceBonus){
            //adds raw bonus from class and race
            int totalBonusRaw = classBonus.bonusRaw + raceBonus.bonusRaw;
            
            attributeBonus = new AttributeBonus(totalBonusRaw);
            this.baseValue = baseValue;
        }

        public Attribute(double baseValue, AttributeBonus classBonus, AttributeBonus raceBonus){
            double totalBonusMultiplyer = classBonus.bonusMultiplyer + raceBonus.bonusMultiplyer;

            attributeBonus = new AttributeBonus(totalBonusMultiplyer);
            this.baseValue = baseValue;
        }

        public double CalculateValue(){
            return (baseValue + attributeBonus.bonusRaw) * 1 + attributeBonus.bonusMultiplyer;
        }
        
    }
}