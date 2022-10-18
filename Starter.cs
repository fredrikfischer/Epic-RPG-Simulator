using System;

namespace OOP2 {
    public class Starter
    { 
        public static Player GetStarterChoises()
        {
            string playerName = ChoosePlayerName();
            
            Console.WriteLine("Choose your class! \n1. Warrior \n2. Mage");
            IBonusType playerClass = ChooseClass();
            Console.Clear();
            Console.WriteLine($"You chose the {playerClass.name} class, that's a good choice! Prepare for an epic adventure!!!");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Choose your race! \n1. Elf\n2. Orc");
            IBonusType playerRace = ChooseRace();
            Console.Clear();
            Console.WriteLine($"You chose the {playerRace.name} race! Prepare for an epic adventure!!");
            Console.ReadLine();
            Console.Clear();

            return new Player(playerName, playerClass, playerRace);
        }


        private static string ChoosePlayerName()
        {
            string playerName = "P1";
            return playerName;
        }


        private static IBonusType ChooseClass()
        {
            IBonusType playerClass = Console.ReadLine() switch
            {
                "1" => playerClass = new Warrior(),
                "2" => playerClass = new Mage(),
                _ => playerClass = new Warrior(),
            };

            return playerClass;
        }


        private static IBonusType ChooseRace()
        {     
            IBonusType playerRace = Console.ReadLine() switch
            {
                "1" => playerRace = new Elf(),
                "2" => playerRace = new Orc(),
                _ => playerRace = new Elf(),
            };
            return playerRace;
        }
    }
}