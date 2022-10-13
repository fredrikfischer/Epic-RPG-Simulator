﻿using System;


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


            IBonusType playerClass = ChooseClass();

            IBonusType playerRace = ChooseRace();

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
            Console.WriteLine($"Maximun health points: {player.healthPoints.value}");
        }

        private static string ChoosePlayerName()
        {
            string playerName = "P1";
            return playerName;
        }

        private static IBonusType ChooseClass()
        {
            Console.WriteLine("Choose your class! \n1. Warrior \n2. Mage");

            IBonusType playerClass = Console.ReadLine() switch
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

        private static IBonusType ChooseRace()
        {

            Console.WriteLine("Choose your race! \n1. Elf\n2. Orc");

            IBonusType playerRace = Console.ReadLine() switch
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
            Console.WriteLine("1. Fight opponent");
            Console.WriteLine("2. Go to item shop");
            Console.WriteLine("3. See statistics");
            displayStats(player);
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    //Match match = new Match(player);
                    ChooseEnemy(player);

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
        private static void ChooseEnemy(Player player)
        {
            Console.WriteLine("Choose difficulty for your next opponent");
            //CW visar fakta om bounty osv för varje difficulty

            Console.WriteLine("1. n gold, easy difficulty");
            Console.WriteLine("2. n gold, easy difficulty");
            Console.WriteLine("3. n gold, medium difficulty");
            Console.WriteLine("4. n gold, medium difficulty");
            Console.WriteLine("5. n gold, hard difficulty");
            Console.WriteLine("6. n gold, extreme difficulty");
            Console.WriteLine("7. n gold, super mega extreme difficulty");



            switch (Console.ReadLine())
            {
                case "1":
                    CreateMatch(player, 1);
                    break;
                case "2":
                    CreateMatch(player, 2);
                    break;
                case "3":
                    CreateMatch(player, 3);
                    break;
                case "4":
                    CreateMatch(player, 4);
                    break;
                case "5":
                    CreateMatch(player, 5);
                    break;
                case "6":
                    CreateMatch(player, 6);
                    break;
                case "7":
                    CreateMatch(player, 7);
                    break;
                default:
                    Console.WriteLine("xD");
                    break;

            }


        }

        static void CreateMatch(Player player, int difficulty)
        {
            Match match = new Match(player, new Enemy(difficulty));

        }

    }
}








