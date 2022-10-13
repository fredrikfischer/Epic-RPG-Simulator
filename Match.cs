using System;
namespace OOP2
{
    class Match
    {

        //Player player;???
        //Enemy enemy;????

        public Match(Player player, Enemy enemy)
        {

            //TODO enemy ska passas in i Match()
            //Enemy enemy = new Enemy(1);
            //fixa problemet med att båda dör samt trippla writelines
            Console.WriteLine($"This fight is against {enemy.name}, {enemy.description}, If you win, this fight will earn you {enemy.bounty} gold \n\n\nPress any button to start the fight...");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            Round(player, enemy);

        }

        private void Round(Player player, Enemy enemy)
        {

            while (player.healthPoints.currentValue > 0 && enemy.healthPoints.currentValue > 0)
            {

                Console.WriteLine($"Your hp: {player.healthPoints.currentValue}/{player.healthPoints.value}\n{enemy.name} hp: {enemy.healthPoints.currentValue}/{enemy.healthPoints.value}\n");

                Console.WriteLine("Choose action\n1. Attack\n2. Run\n3. Consumables");
                string? input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1":
                        useAbility(player, enemy);
                        break;
                    default:
                        Round(player, enemy);
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                useAbility(enemy, player);
                Console.ReadLine();
                Console.Clear();
                Round(player, enemy);
                System.Console.WriteLine("i while");

            }
            System.Console.WriteLine("efter while");

            if (player.healthPoints.currentValue > 0 && enemy.healthPoints.currentValue > 0)
            {
                Console.WriteLine("You both died in the fight RIP");
            }
            else if (player.healthPoints.currentValue > enemy.healthPoints.currentValue)
            {
                Console.WriteLine("Congrats " + player.name + ", you won the fight!!");
                //Console.WriteLine("1. return to menu");
                //Console.WriteLine("2. see stats");
            }
            else
            {
                Console.WriteLine("You lost against " + enemy.name + "!");
            }

            System.Console.WriteLine("efter if else");




        }

        private void useAbility(Player player, Enemy enemy)
        {
            //Calculates crit
            Random rnd = new Random();
            double totalDamage;
            if (rnd.NextDouble() <= player.critChance.value)
            {

                totalDamage = (player.attackDamage.value * (1 + player.critDamage.value)) - enemy.defence.value;

                Console.Write($"It's a critical hit! ");
            }
            else
            {
                totalDamage = player.attackDamage.value - enemy.defence.value;
            }

            if (totalDamage >= 0)
            {
                enemy.healthPoints.reduceCurrentValue(totalDamage);
            }
            else
            {
                totalDamage = 0;
            }
            Console.WriteLine($"You attack and hurt {enemy.name} with {totalDamage} damage");
        }

        private void useAbility(Enemy enemy, Player player)
        {
            //Calculates crit
            Random rnd = new Random();
            double totalDamage;
            if (rnd.NextDouble() <= enemy.critChance.value)
            {

                totalDamage = (enemy.attackDamage.value * (1 + player.critDamage.value)) - player.defence.value;

                Console.Write($"It's a critical hit! ");
            }
            else
            {
                totalDamage = enemy.attackDamage.value - player.defence.value;
            }

            if (totalDamage >= 0)
            {
                player.healthPoints.reduceCurrentValue(totalDamage);
            }
            else
            {
                totalDamage = 0;
            }
            Console.WriteLine($"{enemy.name} attack and hurt you with {totalDamage} damage");

        }


    }

}
