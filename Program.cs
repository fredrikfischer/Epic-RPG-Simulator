using System;


namespace OOP2{

    class Program{
        static void Main(string[] args){

        string p1_name = "P1";
        //string p2_name = "P2";

        //Player player_1 = new Player(p1_name);
        // Player player_2 = new Player(p2_name);

        Console.WriteLine("Choose your class! \n1. Warrior \n2. Mage");
        string user_input = Console.ReadLine();

        
        Player player_1 = new Player();
    

        Console.WriteLine(player_1.classtype.name);
        
       


        



        //Scoreboard.print(player_1.name, player_2.name);

        //Console.WriteLine($"{player_1.score.one} {player_1.score.two}");         
        }
    }
}







