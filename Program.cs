using System;


namespace OOP2{

    class Program{
        static void Main(string[] args){

        string playerName = "P1";

        Console.WriteLine("Choose your class! \n1. Warrior \n2. Mage");
        var userInput = Console.ReadLine();

            Charachter playerType;

            var result = userInput switch{
                "1" => playerType = new Warrior(),
                "2" => playerType = new Mage(),
                _ => playerType = new Warrior(),
            };
            
            Console.WriteLine("hej");
            //Console.WriteLine($"Strength: {playerType.strength}");

            Player player1 = new Player(playerName, playerType);
            
            Console.Clear();
            //Console.WriteLine($"Name: {player1.info.name}, Stringth:{player1.info.strength}, Int: {player1.info.intelligence}, agg: {player1.info.agility}, hp: {player1.info.hp}");
            Console.WriteLine($"You chose the {player1.info.classTypeName} class, that's a good choice! Prepare for an epic adventure!!!");    
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Attack damage: {player1.info.attackDamage}");
            Console.WriteLine($"\ndefence: {player1.info.defence}");
            Console.WriteLine($"\nCritical hit chance: {player1.info.critChance}");
            Console.WriteLine($"\nHealth power: {player1.info.hp}");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.WriteLine("Press (1) to attack");
            Console.ReadLine();
            Console.WriteLine($"You attacked! You did {player1.info.Attack()} damage!");
            Console.ReadLine();
        }
    }
}







