using System;

namespace OOP2 {
    class Warrior : IClassType{   

       public string classTypeName { get; set; }
       public double strength { get; set; }
       public double intelligence { get; set; }
       public double agility { get; set; }

       public double hp { get; set; }
       

       public Warrior(){
            classTypeName = "Warrior";

            strength = 20;
            intelligence = 5;
            agility = 10;

            hp = 120;
       }

        public double Attack()
        {
            double dmg = (strength * 2) + (intelligence / 2) + agility;
            return dmg;
        }

        public double Attack(int item)
        {
            double dmg = item + ((strength * 2) + (intelligence / 2) + agility);
            return dmg;
        }
    }
}