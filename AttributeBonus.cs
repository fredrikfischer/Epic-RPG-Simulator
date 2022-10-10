using System;
using System.Collections.Generic;

namespace OOP2 {
    public class AttributeBonus
    { 

        public int bonusRaw {get; private set; }
        public double bonusMultiplyer {get; private set; }
        
        public AttributeBonus(){
            bonusRaw = 0;
            bonusMultiplyer = 0;

        }

        public AttributeBonus(int bonusRaw){

            this.bonusRaw = bonusRaw;
            bonusMultiplyer = 0;
        }

        public AttributeBonus(double bonusMultiplyer){

            
            this.bonusMultiplyer = bonusMultiplyer;
            this.bonusRaw = 0;
        }

        public void recieveUpdate(int newBonusRaw){
            bonusRaw += newBonusRaw;
        }
        
    }
}