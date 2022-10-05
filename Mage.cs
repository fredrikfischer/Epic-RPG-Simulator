using System;

namespace OOP2 {
    class Mage : IClassType
    { 
       public string classTypeName { get; set;} 
       public double strength { get; set; }
       public double intelligence { get; set; }
       public double agility { get; set; }

       public double hp { get; set; }

       public Mage(){
            classTypeName = "Mage";

            strength = 5;
            intelligence = 20;
            agility = 10;

            hp = 80;
        }

        public double Attack()
        {
            
            double dmg = (strength / 2) + (intelligence * 2.5) + agility;

            return dmg;

        }

        public double Attack(double item)
        {
            double dmg = item + ((strength / 2) + (intelligence * 2.5) + agility);
            return dmg;
        }
    }
}