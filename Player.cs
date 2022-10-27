using System;
using System.Reflection.PortableExecutable;

namespace OOP2
{
    public class Player : IMatchObserver, IAttributes
    {
        public string name { get; private set; }
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
            this.name = playerName;
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

        public void UpdatePlayerHealth(Player player)
        {
            healthPoints = new Attribute(player.healthPoints.baseValue);
            healthPoints.AddAttributeBonuses(player.classType.healthPoints);
            healthPoints.AddAttributeBonuses(player.raceType.healthPoints);
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void HealPlayer(int value)
        {
            healthPoints.AddToCurrentHealth(value);
        }

        public void DeleteGold(int value)
        {
            currentGold -= value;
        }

        public void UseConsumable(Item item)
        {
            if (item.type == "Heal")
            {
                HealPlayer(item.value);
            }

            RemoveItem(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public void UpdatePostMatch(Match match)
        {
            if(match.didWin)
            {
                //Adds Gold
                currentGold += match.enemy.bounty;
            }
        }
    }
}
