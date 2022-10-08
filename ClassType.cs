using System;

namespace OOP2
{
    public class ClassType 
    {
        public string? name;
        public string? description;
        public Attribute? attackDamage;
        public Attribute? defence;
        public Attribute? critChance;
        public Attribute? critDamage;
        public Attribute? maxHp;
        
        public ClassType()
        {
            name = "no name";
            description = "no description";

        }
    }
}