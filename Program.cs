using System;


namespace OOP2
{

    class Program
    {
        static void Main(string[] args)
        {

            
            PrintToFile();
            GUI.displayWelcome();
            Game game = new Game();
            game.Play();
        }

        async static void PrintToFile()
        {
        await File.WriteAllTextAsync("History.md", "test");
        }
    }
}








