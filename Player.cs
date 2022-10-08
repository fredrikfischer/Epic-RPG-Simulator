using System;
using System.Reflection.PortableExecutable;

namespace OOP2{
    public class Player 
    {
        public string? name { get; set; }
        public ClassType classType { get; set; }
        public RaceType raceType { get; set; }
        public Attributes attributes {get; set; }

        public Player(string playerName, ClassType classType, RaceType raceType){
            Attributes attributes = new Attributes();
            name = playerName;
            this.classType = classType;
            this.raceType = raceType; 
            this.attributes = attributes;

        }
    }
}