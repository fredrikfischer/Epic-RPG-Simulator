using System;

namespace OOP2{
    class Player
    { 
        public Info info;

        public Player(string playerName, Info classInfo){
            this.info = classInfo;
            this.info.name = playerName;

        }

        public void changeName(string name){
            this.info.name = name;
        }
    }
}