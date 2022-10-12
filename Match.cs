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
Console.WriteLine($"Your hp: {player.healthPower.currentValue}\n{enemy.name} hp: {enemy.healthPower.currentValue}\n");

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

totalDamage = (player.attackDamage.value  * (1 + player.critDamage.value)) - enemy.defence.value;

Console.Write($"It's a critical hit! ");
}else{
totalDamage = player.attackDamage.value - enemy.defence.value;
}

if(totalDamage >= 0)
{
enemy.healthPower.reduceCurrentValue(totalDamage);
}else{
totalDamage = 0;
}
Console.WriteLine($"You attack and hurt {enemy.name} with {totalDamage} damage");
}

private void useAbility(Enemy enemy, Player player){
//Calculates crit
Random rnd = new Random();
double totalDamage;
if(rnd.NextDouble() <= enemy.critChance.value){

totalDamage = (enemy.attackDamage.value * (1 + player.critDamage.value)) - player.defence.value;

Console.Write($"It's a critical hit! ");
}else{
totalDamage = enemy.attackDamage.value - player.defence.value;
}

if(totalDamage >= 0)
{
player.healthPower.reduceCurrentValue(totalDamage);
}else{
totalDamage = 0;
}
Console.WriteLine($"{enemy.name} attack and hurt you with {totalDamage} damage");

}


}

}
