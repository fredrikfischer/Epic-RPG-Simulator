using System; 

namespace OOP2{
    class Scoreboard{

        public Scoreboard(){

        }

        public void print(string p1, string p2){
        Console.WriteLine($"Player 1: {p1}");
        Console.WriteLine($"Player 2: {p2}");

        Console.WriteLine(" ____________________");
        Console.WriteLine($"|Yatzy|{p1}|{p2}|  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|1    |  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|2    |  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|3    |  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|4    |  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|5    |  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|6    |  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|Bonus|  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|1 par|  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|2 par|  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|3-tal|  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|4-tal|  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|L-stg|  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|S-stg|  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|Kåk  |  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|Chans|  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|Yatzy|  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|Chans|  |  |  |  |  |");
        Console.WriteLine(" --------------------");
        Console.WriteLine("|Summa|  |  |  |  |  |");
        Console.WriteLine(" ‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾");
        }
    }
}