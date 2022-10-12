using System;
using System.Collections.Generic;

namespace OOP2 {
    public class Attribute
    { 
        AttributeBonus attributeBonus;
        double baseValue;
        public double value { get => CalculateValue(); set => this.value = value; } 
        

        // For monster
        public Attribute(int baseValue){   
            attributeBonus = new AttributeBonus();
            this.baseValue = baseValue;
            currentValue = (baseValue + attributeBonus.bonusRaw) * 1 + attributeBonus.bonusMultiplyer;
        }
        // For monster
        public Attribute(double baseValue){   
            attributeBonus = new AttributeBonus();
            this.baseValue = baseValue;
            currentValue = (baseValue + attributeBonus.bonusRaw) * 1 + attributeBonus.bonusMultiplyer;
        }

        public Attribute(int baseValue, AttributeBonus classBonus, AttributeBonus raceBonus){
            //adds raw bonus from class and race
            int totalBonusRaw = classBonus.bonusRaw + raceBonus.bonusRaw;
            
            attributeBonus = new AttributeBonus(totalBonusRaw);
            this.baseValue = baseValue;
            currentValue = (baseValue + attributeBonus.bonusRaw) * 1 + attributeBonus.bonusMultiplyer;
        }
        //For player
        public Attribute(double baseValue, AttributeBonus classBonus, AttributeBonus raceBonus){
            double totalBonusMultiplyer = classBonus.bonusMultiplyer + raceBonus.bonusMultiplyer;

            attributeBonus = new AttributeBonus(totalBonusMultiplyer);
            this.baseValue = baseValue;
            currentValue = (baseValue + attributeBonus.bonusRaw) * 1 + attributeBonus.bonusMultiplyer;
        }

        public double CalculateValue(){
            return (baseValue + attributeBonus.bonusRaw) * 1 + attributeBonus.bonusMultiplyer;
        }    
    }
}