using System;

namespace OOP2 {
    public class GUI
    { 
        public static void displayWelcome()
        {
            Console.WriteLine("Welcome to Epic RPG simulator free download no ADS!!!");
            Console.WriteLine(@"     
                 ___====-_  _-====___
           _--^^^#####//      \\#####^^^--_
        _-^##########// (    ) \\##########^-_
       -############//  |\^^/|  \\############-
     _/############//   (@::@)   \\############\_
    /#############((     \\//     ))#############\
   -###############\\    (oo)    //###############-
  -#################\\  / VV \  //#################-
 -###################\\/      \//###################-
_#/|##########/\######(   /\   )######/\##########|\#_
|/ |#/\#/\#/\/  \#/\##\  |  |  /##/\#/  \/\#/\#/\#| \|
`  |/  V  V  `   V  \#\| |  | |/#/  V   '  V  V  \|  '
   `   `  `      `   / | |  | | \   '      '  '   '
                    (  | |  | |  )
                   __\ | |  | | /__
                  (vvv(VVV)(VVV)vvv)");
            Console.ReadLine(); 
            Console.Clear();
        }

        public static void displayStats(Player player)
            {
                Console.WriteLine($"{player.name}, {player.raceType.name} {player.classType.name}");
                Console.WriteLine($"Health points: {player.healthPoints.currentValue}/{player.healthPoints.value}");
                Console.WriteLine($"Current gold: {player.currentGold}");
                Console.WriteLine($"\nAttack damage: {player.attackDamage.value}");
                Console.WriteLine($"defence: {player.defence.value}");
                Console.WriteLine($"Critical hit chance: {Math.Round(player.critChance.value * 100, 2, MidpointRounding.ToEven)}%");
                Console.WriteLine($"Critical hit damage: {Math.Round(player.critDamage.value * 100, 2, MidpointRounding.ToEven)}%");
            }

        public static void displayItemShop(Player player)
        {
            Console.WriteLine("Welcome to the item shop /n/n here you can buy items to use in your fight");
            Console.WriteLine("Your balance is " + player.currentGold + " gold");

            Console.WriteLine("1. Healing salve     50 gold");
            Console.WriteLine("2. Sword             50 gold");
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

            Console.WriteLine("1. Very easy ");
            Console.WriteLine("2. Easy ");
            Console.WriteLine("3. Easy/medium");
            Console.WriteLine("4. Medium");
            Console.WriteLine("5. Hard");
            Console.WriteLine("6. Extreme");
            Console.WriteLine("7. Mega extreme");
        }
        
        public static void displayChooseAction()
        {
            Console.WriteLine("Choose action");
            Console.WriteLine("1. Fight opponent");
            Console.WriteLine("2. Go to item shop");
            Console.WriteLine("3. See statistics");
            Console.WriteLine("4. Share options");
        }
    }
}