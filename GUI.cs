using System;

namespace OOP2 {
    public class GUI
    { 
        public static void displayWelcome()
        {
            Console.WriteLine("Welcome to Epic RPG simulator free download no ADS!!!");
            Console.ReadLine(); 
            Console.Clear();
        }
        public static void displayStats(Player player)
            {
                Console.WriteLine($"{player.name}, {player.raceType.name} {player.classType.name}");
                Console.WriteLine($"Attack damage: {player.attackDamage.value}");
                Console.WriteLine($"defence: {player.defence.value}");
                Console.WriteLine($"Critical hit chance: {player.critChance.value * 100}%");
                Console.WriteLine($"Critical hit damage: {player.critDamage.value * 100}%");
                Console.WriteLine($"Maximun health points: {player.healthPoints.value}");
                Console.WriteLine($"Current gold: {player.currentGold}");
            }

        public static void displayItemShop(Player player)
        {
            Console.WriteLine("Welcome to the item shop /n/n here you can buy items to use in your fight");
            Console.WriteLine("Your balance is " + player.currentGold + " gold");

            Console.WriteLine("1. Healing salve 50 gold");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            Console.WriteLine("7. ");
            Console.WriteLine("8. ");
        }

        public static void displayChooseEnemy()
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
        }

        public static void displayChooseAction()
        {
            Console.WriteLine("Choose action");
            Console.WriteLine("1. Fight opponent");
            Console.WriteLine("2. Go to item shop");
            Console.WriteLine("3. See statistics");
        }
    }
}