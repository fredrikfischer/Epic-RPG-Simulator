using System;


namespace OOP2
{

    class Program
    {
        static void Main(string[] args)
        {
            GUI.displayWelcome();
            Player player = StarterChoises();
            ChooseAction(player);
        }


        private static Player StarterChoises()
        {
            string playerName = ChoosePlayerName();
            
            Console.WriteLine("Choose your class! \n1. Warrior \n2. Mage");
            IBonusType playerClass = ChooseClass();
            Console.Clear();
            Console.WriteLine($"You chose the {playerClass.name} class, that's a good choice! Prepare for an epic adventure!!!");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Choose your race! \n1. Elf\n2. Orc");
            IBonusType playerRace = ChooseRace();
            Console.Clear();
            Console.WriteLine($"You chose the {playerRace.name} race! Prepare for an epic adventure!!");
            Console.ReadLine();
            Console.Clear();

            return new Player(playerName, playerClass, playerRace);
        }


        private static string ChoosePlayerName()
        {
            string playerName = "P1";
            return playerName;
        }


        private static IBonusType ChooseClass()
        {
            IBonusType playerClass = Console.ReadLine() switch
            {
                "1" => playerClass = new Warrior(),
                "2" => playerClass = new Mage(),
                _ => playerClass = new Warrior(),
            };

            return playerClass;
        }


        private static IBonusType ChooseRace()
        {     
            IBonusType playerRace = Console.ReadLine() switch
            {
                "1" => playerRace = new Elf(),
                "2" => playerRace = new Orc(),
                _ => playerRace = new Elf(),
            };
            return playerRace;
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








