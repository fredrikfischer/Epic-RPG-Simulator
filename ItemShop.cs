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

                    AddItem(player, new HealingSalve("Healing Salve", 50, 250));
                    break;
                case "2":
                    AddItem(player, new Weapon("Sword", 50, 100));
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
        private void AddItem(Player player, Item item)
        {
            if (player.currentGold > item.cost)
            {
                player.AddItem(item);
                player.DeleteGold(item.cost);
            }
            else
            {
                Console.WriteLine("You dont have enough gold");
                Console.ReadLine();
            }

        }

    }

}