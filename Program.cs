using System;


namespace OOP2{

    class Program{
        static void Main(string[] args){

        string playerName = "P1";
        //string p2_name = "P2";

        //Player player_1 = new Player(p1_name);
        // Player player_2 = new Player(p2_name);

        Console.WriteLine("Choose your class! \n1. Warrior \n2. Mage");
        string userInput = Console.ReadLine();

            IClassType playerType;

            switch (userInput)
            {
                case "1": playerType = new Warrior();
                    break;
                case "2": playerType = new Mage();
                    break;
                default: playerType = new Warrior();
                    break;
            }

            Player player1 = new Player(playerName, playerType);
            Console.Clear();
            Console.WriteLine($"You chose the {player1.classType.classTypeName} class, that's a good choice! Prepare for an epic adventure!!!");    
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\n Your strength is {player1.classType.strength}");
            Console.WriteLine($"\n Your intelligence is {player1.classType.intelligence}");
            Console.WriteLine($"\n Your agility is {player1.classType.agility}");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.WriteLine("Press (1) to attack");
            Console.ReadLine();
            Console.WriteLine($"You attacked! You did {player1.classType.Attack()} damage!");
            Console.ReadLine();
        }
    }
}







