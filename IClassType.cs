using System;

namespace OOP2 {
   
    
    interface IClassType{
        string classTypeName { get; set; }

        double strength { get; set; }
        double intelligence { get; set; }
        double agility { get; set; }

        double hp { get; set;}

        //public string classTypeName;
        double Attack();
    }
}