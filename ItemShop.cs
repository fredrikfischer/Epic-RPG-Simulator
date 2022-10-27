using System;

namespace OOP2
{
    class ItemShop
    {
        public ItemShop()
        {
            
        }

        public void ChooseItem(Player player)
        {
            GUI.displayItemShop(player);

            switch (Console.ReadLine())
            {

                case "1":
                    Item healingSalve = new Item("Healing Salve", 50, "Heal", 50);
                    player.AddItem(healingSalve);
                    player.DeleteGold(50);
                    break;
                case "2":
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    break;
                case "4":
                    Console.Clear();
                    break;
                case "5":
                    Console.Clear();
                    break;
                case "6":
                    Console.Clear();    
                    break;
                case "7":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }

    }

}