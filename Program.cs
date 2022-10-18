using System;


namespace OOP2
{

    class Program
    {
        static void Main(string[] args)
        {
            GUI.displayWelcome();
            Player player = Starter.GetStarterChoises();
            ChooseAction(player);
        }

        public static void ChooseAction(Player player)
        {
            bool rightInput = false;
            while(!rightInput)
            {

                GUI.displayChooseAction();
                GUI.displayStats(player);
                
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        //Match match = new Match(player);
                        ChooseEnemy(player);
                        Console.Clear();

                        break;
                    case "2":
                        Console.Clear();
                        Itemshop itemShop = new Itemshop(player);
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        GUI.displayStats(player);
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;
                }                
            }
        }

        
        private static void ChooseEnemy(Player player)
        {
            GUI.displayChooseEnemy();
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    CreateMatch(player, 1);
                    break;
                case "2":
                    Console.Clear();
                    CreateMatch(player, 2);
                    break;
                case "3":
                    Console.Clear();
                    CreateMatch(player, 3);
                    break;
                case "4":
                    Console.Clear();
                    CreateMatch(player, 4);
                    break;
                case "5":
                    Console.Clear();
                    CreateMatch(player, 5);
                    break;
                case "6":
                    Console.Clear();
                    CreateMatch(player, 6);
                    break;
                case "7":
                    Console.Clear();
                    CreateMatch(player, 7);
                    break;
                default:
                    Console.Clear();
                    break;

            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }


        static void CreateMatch(Player player, int difficulty)
        {
            Match match = new Match(player, new Enemy(difficulty));
        }
    }
}








