using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Newtonsoft.Json;


namespace OOP2
{
    public class Statistics : IMatchObserver
    {

        List<Match> matches;
        public delegate void ExportToFile<in T>(T t, string filename);


        public Statistics()
        {
            matches = new List<Match>();
        }

        public void UpdatePostMatch(Match match)
        {
            matches.Add(match);
            ExportMatches();
            ExportItems(match);
        }

        private void ExportMatches()
        {
            //Exports the list of matches to a file.
            ExportToFile<List<Match>> exportMatches = async (List<Match> i, string filename) =>
            {
                string json = JsonConvert.SerializeObject(i);
                await File.WriteAllTextAsync(filename, json);
            };
            exportMatches(matches, "MatchesHistory.md");
        }
        private void ExportItems(Match match)
        {
            //Exports equipped items to a file.
            ExportToFile<IEnumerable<Item>> exportItem = async (IEnumerable<Item> i, string filename) =>
            {
                string json = JsonConvert.SerializeObject(i);
                await File.WriteAllTextAsync(filename, json);
            };
            exportItem(match.player.usedItems, "ItemsHistory.md");

            //Exports equiped comsumables to a file.
            ExportToFile<IEnumerable<Consumable>> exportConsumable = exportItem;
            exportConsumable(match.player.usedItems.OfType<Consumable>(), "ConsumableHistory.md");

            //Exports equiped weapons to a file.
            ExportToFile<IEnumerable<Weapon>> exportWeapon = exportItem;
            exportWeapon(match.player.usedItems.OfType<Weapon>(), "WeaponHistory.md");
        }

        private int GetTotalMatches()
        {
            int total = 0;
            matches.ForEach(x => total++);
            return total;
        }
        private int GetTotalRounds()
        {
            int total = 0;
            matches.ForEach(x => total += x.roundsPlayed);
            return total;
        }

        private int GetTotalWins()
        {
            int total = 0;
            matches.Where(x => x.didWin).ToList().ForEach(x => total++);
            return total;
        }

        public void ExportStats(Player player)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Share your weapons with the world!");

            if (Console.ReadLine() == "1")
            {
                ExportToFile<IEnumerable<Item>> exportItem = async (IEnumerable<Item> i, string filename) =>
                    {
                        string json = JsonConvert.SerializeObject(i);
                        await File.WriteAllTextAsync(filename, json);
                    };

                ExportToFile<IEnumerable<Weapon>> exportWeapon = exportItem;
                exportWeapon(player.usedItems.OfType<Weapon>(), "APIWeapons.md");
            }      
        }
        
        public void ShowMatchStats()
        {
            PrintStat($"Total matches played:", GetTotalMatches());
            PrintStat("Total wins:", GetTotalWins());
            PrintStat("Total rounds played:", GetTotalRounds());
            Console.ReadLine();
        }
        public void PrintStat<T>(string text, T input)
        {
            Console.WriteLine($"{text} {input}");
        }
    }
}