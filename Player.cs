using System;

namespace OOP2{
    class Player{
        public string name;
        public Score score;

        public Player(string name){
                this.name = name;
                this.score = new Score();

        }
    }

}