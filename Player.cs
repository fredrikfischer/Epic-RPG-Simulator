using System;
using System.Reflection.PortableExecutable;

namespace OOP2
{
    public class Player
    {
        public string? name { get; private set; }
        public IBonusType classType { get; private set; }
        public IBonusType raceType { get; private set; }

        public Attribute attackDamage { get; private set; }
        public Attribute defence { get; private set; }
        public Attribute critChance { get; private set; }
        public Attribute critDamage { get; private set; }
        public Attribute healthPoints { get; private set; }
        public int currentGold { get; private set; }
        //public int currentXp {get; private set; }
        public List<Item> items { get; private set; }

        public Player(string playerName, IBonusType classType, IBonusType raceType)
        {
            name = playerName;
            this.classType = classType;
            this.raceType = raceType;
            //this.attackDamage.Add(raceType.attackDamage);

            attackDamage = new Attribute(60);
            attackDamage.AddAttributeBonuses(classType.attackDamage);
            attackDamage.AddAttributeBonuses(raceType.attackDamage);

            defence = new Attribute(30);
            defence.AddAttributeBonuses(classType.defence);
            defence.AddAttributeBonuses(raceType.defence);

            critChance = new Attribute(0.1);
            critChance.AddAttributeBonuses(classType.critChance);
            critChance.AddAttributeBonuses(raceType.critChance);

            critDamage = new Attribute(0.1);
            critDamage.AddAttributeBonuses(classType.critDamage);
            critDamage.AddAttributeBonuses(raceType.critDamage);

            healthPoints = new Attribute(900);
            healthPoints.AddAttributeBonuses(classType.healthPoints);
            healthPoints.AddAttributeBonuses(raceType.healthPoints);

            //currentGold = 0;

            items = new List<Item>();

        }

        public static void AddGold(Player player, int bounty)
        {
            player.currentGold += bounty;
        }

        public static void UpdatePlayerHealth(Player player)
        {
            player.healthPoints = new Attribute(player.healthPoints.baseValue);
            player.healthPoints.AddAttributeBonuses(player.classType.healthPoints);
            player.healthPoints.AddAttributeBonuses(player.raceType.healthPoints);


        }
        public static void AddItem(Player player, Item item)
        {
            player.items.Add(item);

        }
        public static void HealPlayer(Player player, int value)
        {
            player.healthPoints.AddToCurrentHealth(player, value);
        }
        public static void DeleteGold(Player player, int value)
        {
            player.currentGold -= value;
        }

        public static void UseConsumable(Player player, Item item)
        {
            if (item.type == "Heal")
            {
                HealPlayer(player, item.value);
            }

            player.RemoveItem(player, item);

        }

        public void RemoveItem(Player player, Item item)
        {
            player.items.Remove(item);


        }

    }
}
