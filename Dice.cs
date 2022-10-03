using System;


namespace OOP2 {
    class Dice{

        public Dice(){

        }

        public void roll(){
            Random random = new Random();
            Console.WriteLine(random.Next(1, 7));
        }
    }
}