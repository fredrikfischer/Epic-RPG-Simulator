using System;


namespace OOP2 {
    class Die{
        public Die(){
        }
        public void roll(){
            Random random = new Random();
            Console.WriteLine(random.Next(1, 7));
        }
    }
}