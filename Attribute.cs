using System;
using System.Collections.Generic;

namespace OOP2 {
    public class Attribute
    { 
        public AttributeBonus attributeBonus;
        double baseValue;
        public double value { get => CalculateValue(); set => this.value = value; } 
    

        // For monster
        public Attribute(int baseValue){   
            attributeBonus = new AttributeBonus();
            this.baseValue = baseValue;
        }

        public Attribute(double baseValue){   
            attributeBonus = new AttributeBonus();
            this.baseValue = baseValue;
        }
        public Attribute(int baseValue1, int baseValue2){   
            attributeBonus = new AttributeBonus();
            this.baseValue = baseValue1 + baseValue2;
        }

        public void AddAttributeBonuses(AttributeBonus attributeBonusLists)
        {
            if(0 < attributeBonusLists.bonusRawList.Sum())
            {
                this.attributeBonus.bonusRawList.Add(attributeBonusLists.bonusRawList.Sum());
            }

            if(0 < attributeBonusLists.bonusMultiplyerList.Sum())
            {
                this.attributeBonus.bonusMultiplyerList.Add(attributeBonusLists.bonusMultiplyerList.Sum());
            }   
        }



       /* public Attribute(int baseValue, AttributeBonus classBonus, AttributeBonus raceBonus){
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
        */
        public double CalculateValue(){
            return (baseValue + attributeBonus.bonusRawList.Sum()) * (1 + attributeBonus.bonusMultiplyerList.Sum());
        }    
    }
}