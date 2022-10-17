using System;
using System.Media;


namespace OOP2
{
    class Match
    {

        public Match(Player player, Enemy enemy)
        {

            if (OperatingSystem.IsWindows())
            {
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = Environment.CurrentDirectory + "/Dragonforce - Through The Fire And The Flames (Renegade 8 Bit Remix).wav";
                sound.Load();
                sound.Play();

            }




            //fixa problemet med att båda dör samt trippla writelines
            Console.WriteLine($"This fight is against {enemy.name}, {enemy.description}, If you win, this fight will earn you {enemy.bounty} gold");
            //Console.WriteLine("i början av round);\n\n\nPress any button to start the fight...");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            Round(player, enemy);

        }

        private void Round(Player player, Enemy enemy)
        {
            //Console.Beep();
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            while (player.healthPoints.currentValue > 0 && enemy.healthPoints.currentValue > 0)
            {


                Console.WriteLine($"Your hp: {player.healthPoints.currentValue}/{player.healthPoints.value}\n{enemy.name} hp: {enemy.healthPoints.currentValue}/{enemy.healthPoints.value}\n");

                Console.WriteLine("Choose action\n1. Attack\n2. Run\n3. Consumables");
                string? input = Console.ReadLine();
                //Console.Clear();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        UseAbility(player, enemy);
                        UseAbility(enemy, player);
                        break;

                    case "3":
                        Console.Clear();
                        ChooseConsumable(player);

                        break;
                    default:

                        break;
                }
                //Console.ReadLine();
                //Console.Clear();

                /*  Console.ReadLine();
                 Console.Clear(); */

            }
            

            if (player.healthPoints.currentValue < 0 && enemy.healthPoints.currentValue < 0)
            {
                Console.WriteLine("You both died in the fight RIP");
            }
            else if (player.healthPoints.currentValue > enemy.healthPoints.currentValue)
            {
                //Console.Beep();
                Console.WriteLine("Congrats " + player.name + ", you won the fight!!");
                //Console.WriteLine("1. return to menu");
                //Console.WriteLine("2. see stats");
                int bounty = 50;
                UpdatePlayer(player, bounty);
                Console.ReadLine();
                Console.Clear();
                Program.ChooseAction(player);
            }
            else
            {
                Console.WriteLine("You lost against " + enemy.name + "!");
            }


            Console.ReadLine();
            Console.Clear();



        }

        private void UpdatePlayer(Player player, int bounty)
        {
            player.UpdatePlayerHealth(player);
            player.AddGold(bounty);
        }


        private void UseAbility(Player player, Enemy enemy)
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
                enemy.healthPoints.ReduceCurrentValue(totalDamage);
            }
            else
            {
                totalDamage = 0;
            }
            Console.WriteLine($"You attacked and hurt {enemy.name} with {totalDamage} damage");
        }

        private void UseAbility(Enemy enemy, Player player)
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
                player.healthPoints.ReduceCurrentValue(totalDamage);
            }
            else
            {
                totalDamage = 0;
            }
            Console.WriteLine($"{enemy.name} attacked and hurt you with {totalDamage} damage");

        }

        private void UseItem(Player player, Item item)
        {

            if (item.type == "Heal")
            {
                player.HealPlayer(item.value);
            }

            player.RemoveItem(item);


        }

        private void ChooseConsumable(Player player)
        {

            int i = 1;
            foreach (Item item in player.items)
            {

                System.Console.WriteLine(i + ". " + item.name);
                i++;
            }

            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player.UseConsumable(player.items.ElementAt(0));
                    break;

                case "2":

                    break;
                default:
                    break;
            }

        }


    }

}
