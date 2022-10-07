using System;


namespace OOP2{

    class Program{
        static void Main(string[] args){

        string playerName = "P1";

        Console.WriteLine("Choose your class! \n1. Warrior \n2. Mage");
        var userClass = Console.ReadLine();



            ClassType playerClass = userClass switch{
                "1" => playerClass = new Warrior(),
                "2" => playerClass = new Mage(),
                _ => playerClass = new Warrior(),
            };
            
            Console.Clear();
            Console.WriteLine($"You chose the {playerClass.name} class, that's a good choice! Prepare for an epic adventure!!!");   
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Choose your race! \n1. Elf\n2. Orc");
            var userRace = Console.ReadLine();


            RaceType playerRace = userRace switch{
                "1" => playerRace = new Elf(),
                "2" => playerRace = new Orc(),
                _ => playerRace = new Elf(),
            };

            Player player1 = new Player(playerName, playerClass, playerRace);

            Console.WriteLine(player1.name);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"You chose the {playerRace.name} race! Prepare for an epic adventure!!");  
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Name: {player1.name}");
            Console.WriteLine($"Class: {player1.classType.name}");
            Console.WriteLine($"Race: {player1.raceType.name}");
            Console.WriteLine($"\nAttack damage: {player1.attributes.attackDamage.value}");
            Console.WriteLine($"defence: {player1.attributes.defence.value}");
            Console.WriteLine($"Critical hit chance: {player1.attributes.critChance.value * 100}%");
            Console.WriteLine($"Critical hit damage: {player1.attributes.critDamage.value * 100}%");
            Console.WriteLine($"Health power: {player1.attributes.maxHp.value}");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.WriteLine("Press (1) to attack");
            Console.ReadLine();
            //Console.WriteLine($"You attacked! You did {player1.Attack()} damage!");
            Console.ReadLine();
        }
    }
}







