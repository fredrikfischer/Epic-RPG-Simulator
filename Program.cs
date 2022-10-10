using System;


namespace OOP2
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Epic RPG simulator free download no ADS!!!");
            Console.ReadLine(); Console.Clear();
            Menu();

        }


        private static void Menu()
        {

            string playerName = ChoosePlayerName();


            BonusType playerClass = ChooseClass();

            BonusType playerRace = ChooseRace();

            Player player = new Player(playerName, playerClass, playerRace/*, new Level()*/);

            ChooseAction(player);



            /*
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
            */


        }

        private static void displayStats(Player player)
        {
            Console.WriteLine($"\nAttack damage: {player.attackDamage.value}");
            Console.WriteLine($"defence: {player.defence.value}");
            Console.WriteLine($"Critical hit chance: {player.critChance.value * 100}%");
            Console.WriteLine($"Critical hit damage: {player.critDamage.value * 100}%");
            Console.WriteLine($"Maximun health power: {player.maxHp.value}");
        }

        private static string ChoosePlayerName()
        {
            string playerName = "P1";
            return playerName;
        }

        private static BonusType ChooseClass()
        {
            Console.WriteLine("Choose your class! \n1. Warrior \n2. Mage");

            BonusType playerClass = Console.ReadLine() switch
            {
                "1" => playerClass = new Warrior(),
                "2" => playerClass = new Mage(),
                _ => playerClass = new Warrior(),
            };


            Console.Clear();
            Console.WriteLine($"You chose the {playerClass.name} class, that's a good choice! Prepare for an epic adventure!!!");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();

            return playerClass;

        }

        private static BonusType ChooseRace()
        {

            Console.WriteLine("Choose your race! \n1. Elf\n2. Orc");

            BonusType playerRace = Console.ReadLine() switch
            {
                "1" => playerRace = new Elf(),
                "2" => playerRace = new Orc(),
                _ => playerRace = new Elf(),
            };

            Console.Clear();
            Console.WriteLine($"You chose the {playerRace.name} race! Prepare for an epic adventure!!");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();

            return playerRace;
        }

        private static void ChooseAction(Player player)
        {
            Console.WriteLine("Choose action");
            Console.WriteLine("1. Fight next opponent");
            Console.WriteLine("2. Go to item shop");
            Console.WriteLine("3. See statistics");
            displayStats(player);
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Match match = new Match(player);
                    
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("item shop");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("statistics");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("xD");
                    break;

            }
        }

    }
}








