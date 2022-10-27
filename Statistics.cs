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

        public Statistics() 
        {
            matches = new List<Match>();
        }

        public void UpdatePostMatch(Match match)
        {
            matches.Add(match);
            ExportStatistics();
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
        
        private void UpdateMatchesPlayed()
        {
            int matchesPlayed = 0;
            matches.ForEach(x => matchesPlayed++);
        }
        public void ShowStats()
        {
            PrintStat($"Total matches played:", GetTotalMatches());
            PrintStat("Total wins:", GetTotalWins());
            PrintStat("Total rounds played:", GetTotalRounds());
            Console.ReadLine();
           /*  foreach (var match in matches)
            {
                if(match.didWin)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine(match);

                }
                Console.ForegroundColor = ConsoleColor.White;
                else
                {
                    System.Console.WriteLine(match);
                }
                
            } */
        }

        public void PrintStat<T>(string text, T input)
        {
            Console.ForegroundColor = ConsoleColor.Red;  
            Console.WriteLine($"{text} {input}");        
            Console.ForegroundColor = ConsoleColor.White;                  
        }

        async void ExportStatistics()
        {
        string json = JsonConvert.SerializeObject(matches);
        await File.WriteAllTextAsync("History.md", json);
        }
    }
}