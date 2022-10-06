using System;


namespace OOP2{

    class Program{
        static void Main(string[] args){

        string playerName = "P1";

        Console.WriteLine("Choose your class! \n1. Warrior \n2. Mage");
        var userClass = Console.ReadLine();

            ClassType playerClass;

            var result = userClass switch{
                "1" => playerClass = new Warrior(),
                "2" => playerClass = new Mage(),
                _ => playerClass = new Warrior(),
            };
            
            Console.WriteLine("Choose your race! \n1. Elf\n2. Orc");
            var userRace = Console.ReadLine();
            RaceType playerRace;

             var result1 = userRace switch{
                "1" => playerRace = new Elf(),
                "2" => playerRace = new Orc(),
                _ => playerRace = new Elf(),
            };

            Character player1 = new Player(playerName, playerClass, playerRace);
            
            Console.Clear();
            //Console.WriteLine($"Name: {player1.info.name}, Stringth:{player1.info.strength}, Int: {player1.info.intelligence}, agg: {player1.info.agility}, hp: {player1.info.hp}");
            Console.WriteLine($"You chose the {player1.classType.name} class, that's a good choice! Prepare for an epic adventure!!!");   
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"You chose the {player1.raceType.name} race! Prepare for an epic adventure!!");  
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Attack damage: {player1.attackDamage}");
            Console.WriteLine($"\ndefence: {player1.defence}");
            Console.WriteLine($"\nCritical hit chance: {player1.critChance}");
            Console.WriteLine($"\nHealth power: {player1.hp}");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.WriteLine("Press (1) to attack");
            Console.ReadLine();
            Console.WriteLine($"You attacked! You did {player1.Attack()} damage!");
            Console.ReadLine();
        }
    }
}







