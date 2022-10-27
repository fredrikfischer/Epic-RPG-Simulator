using System;


namespace OOP2
{

    public class Game
    {
        Player player;
        Statistics Statistics;
        ItemShop itemShop;

        public Game()
        {
            this.player = StarterChoises.GetStarterChoises();
            this.Statistics = new Statistics();
            this.itemShop = new ItemShop();
        }

        public void Play()
        {
            bool repeat = false;
            while(!repeat)
            {
                ChooseAction();
            }
        }

        private void ChooseAction()
        {
                GUI.displayChooseAction();
                Console.WriteLine("");
                GUI.displayStats(player);
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        ChooseEnemy();
                        
                        break;
                    case "2":
                        Console.Clear();
                        itemShop.ChooseItem(player);
                        break;
                    case "3":
                        Console.Clear();
                        Statistics.ShowStats();
    
                        break;
                    default:
                        Console.Clear();
                        break;
                }         
                
                Console.Clear();       
        }
        
        private void ChooseEnemy()
        {
            GUI.displayChooseEnemy();
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    CreateMatch(1);
                    break;
                case "2":
                    Console.Clear();
                    CreateMatch(2);
                    break;
                case "3":
                    Console.Clear();
                    CreateMatch(3);
                    break;
                case "4":
                    Console.Clear();
                    CreateMatch(4);
                    break;
                case "5":
                    Console.Clear();
                    CreateMatch(5);
                    break;
                case "6":
                    Console.Clear();
                    CreateMatch(6);
                    break;
                case "7":
                    Console.Clear();
                    CreateMatch(7);
                    break;
                default:
                    Console.Clear();
                    break;

            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }

        private void CreateMatch(int difficulty)
        {
            Match match = new Match(player, new Enemy(difficulty));
            match.AddObserver(Statistics);
            match.AddObserver(player);
            match.Round();
            match.NotifyObservers();
        }
    }
}








