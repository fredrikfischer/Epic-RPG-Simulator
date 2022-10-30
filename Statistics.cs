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
        //delegate void SampleDelIn<in T>(T t); //Tar emot T som input, returnerar void
        public delegate void ExportToFile<in T>(T t, string filename);


        public Statistics()
        {
            matches = new List<Match>();
        }

        public void UpdatePostMatch(Match match)
        {
            /* SampleDelIn<Object> objectIn = (Object o) => Console.WriteLine("objectIn"); //Void
            SampleDelIn<String> stringIn = objectIn;
            stringIn(new String("a")); //Output: objectIn */

            /* ExportToFile<Match> ExportMatch = async (Match m, string filename) =>
            {
                string json = JsonConvert.SerializeObject(m);
                await File.AppendAllTextAsync(filename, json);
            };

             */

            //ExportPlayer = ExportMatch;




            /* IExport<Object> exportObject = new Export<Object>();
            exportObject.ExportToFileInJson(match.enemy, "HistoryMatch.md");
            exportObject.ExportToFileInJson(match.player, "HistoryMatch.md");
            exportObject.ExportToFileInJson(DateTime.Now, "HistoryMatch.md");

            IExport<Match> exportMatch = exportObject; */





            /*
            exportMatch = exportObject;
            exportMatch.ExportToFileInJson(DateTime.Now, "HistoryMatch.md"); */



            /* ExportToFile<Object> exportToFileObject = async (Object o, string filename) =>
            {
                string json = JsonConvert.SerializeObject(o);
                await File.AppendAllTextAsync(filename, json);
            };

            ExportToFile<Player> exportPlayer = async (Player m, string filename) =>
            {
                string json = JsonConvert.SerializeObject(m);
                await File.AppendAllTextAsync(filename, json);
            };

            exportPlayer = exportToFileObject;
            exportPlayer(match.player, "HistoryMatch.md"); */



            ExportToFile<IEnumerable<Item>> exportItem = async (IEnumerable<Item> i, string filename) =>
            {
                string json = JsonConvert.SerializeObject(i);
                await File.AppendAllTextAsync(filename, json);
            };

            ExportToFile<IEnumerable<HealingSalve>> exportHealingSalve = async (IEnumerable<HealingSalve> h, string filename) =>
            {
                string json = JsonConvert.SerializeObject(h);
                await File.AppendAllTextAsync(filename, json);
            };

            exportHealingSalve = exportItem;
            exportHealingSalve(match.player.items.OfType<HealingSalve>(), "History.md");
            //exportHealingSalve(match.player.items.OfType<Item>(), "History.md"); varför funkar inte?


            



            /* 
                        matches.Add(match);
                        IExport<List<Match>> exportMatchList = new Export<List<Match>>();
                        exportMatchList.ExportToFileInJson(matches, "HistoryMatch.md");
                        IExport<string> exportPlayer = new Export<string>();
                        exportPlayer.ExportToFileInJson($"{match.player.classType.name} {match.player.classType.description}", "HistoryBonusType.md");
                         */
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
            //Console.WriteLine(ImportStatistics<T>("HistoryMatch.md")); 
        }



        /*public T ImportStatistics<T>(string file)
        {
            string inputJson = File.ReadAllText(file);
            return JsonConvert.DeserializeAnonymousType(inputJson);
        }*/
    }
}