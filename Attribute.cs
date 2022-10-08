using System;
using System.Collections.Generic;

namespace OOP2 {
    public class Attribute
    { 
        //List<double>? bonusRaw;
        //List<double>? bonusMultiplyer;
        double bonusMultiplyer;
        public double bonusRaw; 
        double baseValue;
        public double value { get => CalculateValue(); set => value = this.baseValue; } 

        public Attribute(double baseValue, int bonusRaw, double bonusMultiplyer){
            //List<double> bonusRaw = new List<double>();
            //List<double> bonusMultiplyer = new List<double>();
            this.baseValue = baseValue;
            this.bonusRaw = bonusRaw;
            this.bonusMultiplyer = 1 + bonusMultiplyer;
            Console.WriteLine("double");
        }

        public Attribute(double baseValue, double bonusMultiplyer){
            //List<double> bonusRaw = new List<double>();
            //List<double> bonusMultiplyer = new List<double>();
            this.baseValue = baseValue;
            this.bonusMultiplyer = 1 + bonusMultiplyer;
            Console.WriteLine("double");
        }


        public double CalculateValue(){
            return (baseValue + bonusRaw) * bonusMultiplyer;
        }
        
    }
}