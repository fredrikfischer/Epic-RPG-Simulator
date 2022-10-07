using System;
using System.Collections.Generic;

namespace OOP2 {
    public class Attribute 
    { 
        List<double>? bonusRaw;
        List<double>? bonusMultiplyer;
        public double baseValue;
        public double value;

        public Attribute(double baseValue){
            List<double> bonusRaw = new List<double>();
            List<double> bonusMultiplyer = new List<double>();
            this.baseValue = baseValue;
            value = this.baseValue;
        }
        
    }
}