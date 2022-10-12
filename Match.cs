using System;
namespace OOP2
{
    class Match
    {
        

        public Match(Player player)
        {
            Console.WriteLine("The Fight begins!!!");
            Console.ReadLine();
            Console.Clear();
            Enemy Enemy = new Enemy();
            Round(player, Enemy);
            

        }

        private void Round(Player player, Enemy enemy)
        {
            Console.WriteLine($"Your hp: {player.currentHp}\nEnemy hp: {enemy.currentHp}");

            Console.WriteLine("Choose action\n1. Attack\n2. Run\n3. Consumables");
            string? input = Console.ReadLine();
            Console.Clear();
            switch(input)
            {
                case "1": Attack(player, enemy);
                    break;
                default: Round(player, enemy);
                    break;
            }
            Console.ReadLine();
            Console.Clear();
            Round(player, enemy);
            
            
        }

        private void Attack(Player player, Enemy enemy){
            //Calculates crit
            Random rnd = new Random();
            if(rnd.NextDouble() <= player.critChance.value){
                Console.WriteLine($"It's a critical hit! You did {(player.attackDamage.value * (1 + player.critDamage.value) - enemy.defence.value)}");
            }else{
                enemy.currentHp -= (player.attackDamage.value - enemy.defence.value);
                Console.WriteLine($"You attack with {player.attackDamage.value} attack damage and hurt {enemy.name} with {player.attackDamage.value - enemy.defence.value} damage");
                
            }
        }

  
        
        

    }


}