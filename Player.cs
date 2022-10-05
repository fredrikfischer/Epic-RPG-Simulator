using System;

namespace OOP2{
    class Player
    { 
        public Charachter info;

        public Player(string playerName, Charachter classInfo){
            this.info = classInfo;
            this.info.name = playerName;

        }

        public void changeName(string name){
            this.info.name = name;
        }
    }
}