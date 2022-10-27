using System;


namespace OOP2
{

    class Program
    {
        static void Main(string[] args)
        {
            GUI.displayWelcome();
            Game game = new Game();
            game.Play();
        }
    }
}








