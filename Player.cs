using System;
using System.Reflection.PortableExecutable;

namespace OOP2{
    class Player : Character
    {


        public Player(){
            

        }

        public Player(string playerName, ClassType classType, RaceType raceType){
            this.classType = classType;
            this.raceType = raceType;
            this.name = playerName;
        }
        
    }
}