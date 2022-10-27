using System;

namespace OOP2 {
    public interface IAttributes
    { 
        public string name { get; }
        public Attribute attackDamage { get; }
        public Attribute defence { get; }
        public Attribute critChance { get; }
        public Attribute critDamage { get; } 
        public Attribute healthPoints { get; } 
        //maybe public int level { get; set;}
        

    }
}