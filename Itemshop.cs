using System;

namespace OOP2
{
    class Itemshop
    {
        public Itemshop(Player player)
        {
            Console.WriteLine("Welcome to the item shop /n/n here you can buy items to use in your fight");
            Console.WriteLine("Your balance is " + player.currentGold + " gold");

            Console.WriteLine("1. Healing salve 50 gold");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            Console.WriteLine("7. ");



            switch (Console.ReadLine())
            {
                case "1":
                    Item healingSalve = new Item("Healing Salve", 50, "Heal", 50);
                    player.AddItem(healingSalve);
                    player.DeleteGold(50);
                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":

                    break;
                case "7":

                    break;
                default:
                    Console.WriteLine("xD");
                    break;



            }
            Program.ChooseAction(player);


        }

    }

}