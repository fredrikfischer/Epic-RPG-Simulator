using System;
namespace OOP2
{
    class Match
    {
        

        public Match(Player player)
        {
            Enemy enemy = new Enemy();
            Console.WriteLine($"This fight is against {enemy.name}, {enemy.description}\n\n\nPress any button to start the fight...");
            Console.ReadLine();
            Console.Clear();
            Round(player, enemy);
            

        }

        private void Round(Player player, Enemy enemy)
        {
            Console.WriteLine($"Your hp: {player.currentHp.value}\n{enemy.name} hp: {enemy.currentHp.value}\n");

            Console.WriteLine("Choose action\n1. Attack\n2. Run\n3. Consumables");
            string? input = Console.ReadLine();
            Console.Clear();
            switch(input)
            {
                case "1": useAbility(player, enemy);
                    break;
                default: Round(player, enemy);
                    break;
            }
            Console.ReadLine();
            Console.Clear();
            useAbility(enemy, player);
            Console.ReadLine();
            Console.Clear();
            Round(player, enemy);
            
            
        }

        private void useAbility(Player player, Enemy enemy){
            //Calculates crit
            Random rnd = new Random();
            double totalDamage;
            if(rnd.NextDouble() <= player.critChance.value){

                totalDamage = ((player.attackDamage.value + player.attackDamage.attributeBonus.bonusRaw) * 1 + player.attackDamage.attributeBonus.bonusMultiplyer) - enemy.defence.value;

                Console.Write($"It's a critical hit! ");
            }else{
                totalDamage = player.attackDamage.value - enemy.defence.value;
            }

            if(totalDamage >= 0)
                {
                    enemy.currentHp.value -= totalDamage;
                }else{
                    totalDamage = 0;
                }
            Console.WriteLine($"You attack and hurt you with {totalDamage} damage");
        }

        private void useAbility(Enemy enemy, Player player){
            //Calculates crit
            Random rnd = new Random();
            double totalDamage;
            if(rnd.NextDouble() <= enemy.critChance.value){

                totalDamage = ((enemy.attackDamage.value + enemy.attackDamage.attributeBonus.bonusRaw) * 1 + enemy.attackDamage.attributeBonus.bonusMultiplyer) - player.defence.value;

                Console.Write($"It's a critical hit! ");
            }else{
                totalDamage = enemy.attackDamage.value - player.defence.value;
            }

            if(totalDamage >= 0)
                {
                    player.currentHp.value -= totalDamage;
                }else{
                    totalDamage = 0;
                }
            Console.WriteLine($"{enemy.name} attack and hurt you with {totalDamage} damage");

        }

  
        
        

    }


}