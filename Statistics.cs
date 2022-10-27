using System;
using System.Collections.Generic;
using System.Linq;


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
        }

        public void ShowStats()
        {
            int totalWins = 0;
            matches.Where(x => x.didWin).ToList().ForEach(x => totalWins++);
            Console.WriteLine($"Total wins: {totalWins}");
            
            Console.ReadLine();
        }
    }
}