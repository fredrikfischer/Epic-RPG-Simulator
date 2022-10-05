using System;

namespace OOP2{
    class Player
    {
        public string name;
        public IClassType classType;
        //public IStats stats;

        public Player(string playerName, IClassType classType){
            this.classType = classType;
            this.name = playerName;
            //this.classtype = new ClassType();
        }

        public void changeName(string name){
            this.name = name;
        }
    }
}