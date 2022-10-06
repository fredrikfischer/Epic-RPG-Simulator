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
            this.attackDamage = 50 + classType.attackDamage;
            this.defence = 30 + classType.defence;
            this.critChance = 0.1 + classType.critChance;
            this.critDamage = 0.1 + classType.critDamage;
            this.hp = 100 + classType.hp;
        }
        
    }
}