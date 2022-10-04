using System;

namespace OOP2{
    class Player{
        public string name;
        public ClassType classtype;
        public Score score;

        public Player(){
            this.name = "no name";
            this.classtype = new ClassType();
            this.score = new Score();

        }

        public void changeName(string name){
            this.name = name;
        }
    }
}