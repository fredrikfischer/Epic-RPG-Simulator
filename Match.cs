using System;
using System.Media;


namespace OOP2
{
    public class Match
    {
        public Player player { get; }
        public Enemy enemy { get; }
        public DateTime matchStart;
        public DateTime matchEnd;
        public int roundsPlayed;
        List<IMatchObserver> observerCollection;
        public bool didWin;

        public Match(Player player, Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
            this.matchStart = DateTime.Now;
            this.roundsPlayed = 0;
            observerCollection = new List<IMatchObserver>();
            Console.WriteLine($"This fight is against {enemy.name}, {enemy.description}, If you win, this fight will earn you {enemy.bounty} gold\n");
            Console.ReadLine();
            Console.Clear();
        }

        public void Round()
        {
            while (player.healthPoints.currentValue > 0 && enemy.healthPoints.currentValue > 0)
            {
                roundsPlayed++;
                Console.WriteLine($"Your hp: {player.healthPoints.currentValue}/{player.healthPoints.value}\n{enemy.name} hp: {enemy.healthPoints.currentValue}/{enemy.healthPoints.value}\n");
                Console.WriteLine("Choose action\n1. Attack\n2. Run\n3. Consumables");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        UseAbility(player, enemy);
                        Console.WriteLine();
                        UseAbility(enemy, player);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        ChooseConsumable(player);

                        break;
                    default:
                        Console.Clear();
                        break;
                }

            }

            if (player.healthPoints.currentValue < 0 && enemy.healthPoints.currentValue < 0)
            {
                Console.WriteLine("You both died in the fight RIP");
            }
            else if (player.healthPoints.currentValue > enemy.healthPoints.currentValue)
            {
                //Console.Beep();
                matchEnd = DateTime.Now;
                Console.WriteLine("Congrats " + player.name + ", you won the fight!!");
                didWin = true;
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("You lost against " + enemy.name + "!");
            }
            Console.ReadLine();
            Console.Clear();
        }

        private void UseAbility(IAttributes offender, IAttributes defender)
        {
            //Calculates crit
            Random rnd = new Random();
            double totalDamage;
            if (rnd.NextDouble() <= offender.critChance.value)
            {
                totalDamage = (offender.attackDamage.value * (1 + offender.critDamage.value)) - defender.defence.value;
                Console.Write($"It's a critical hit! ");
            }
            else
            {
                totalDamage = offender.attackDamage.value - defender.defence.value;
            }

            if (totalDamage >= 0)
            {
                defender.healthPoints.ReduceCurrentValue(totalDamage);
            }
            else
            {
                totalDamage = 0;
            }
            Console.WriteLine($"{offender.name} attacked and hurt {defender.name} with {totalDamage} damage");
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
                    player.UseConsumable(player.items.ElementAt(1));
                    break;
                default:
                    break;
            }
        }

        public void AddObserver(IMatchObserver observer)
        {
            observerCollection.Add(observer);
        }

        public void RemoveObserver()
        {
        }

        public void NotifyObservers()
        {
            foreach (var observer in observerCollection)
            {
                observer.UpdatePostMatch(this);
            }
        }
    }
}
