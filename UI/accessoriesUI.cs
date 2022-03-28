using System;
using ConsoleTables;
using static main.Program;
namespace accessories
{
    public class accessoriesUI
    {
        public static void accessoriesMenu()
        {
            Console.Clear();
            var table = new ConsoleTable("Accessorized Categories");
            table.AddRow("1: Check Jewlery Stock");
            table.AddRow("2: Check Stickers Stock");
            table.AddRow("3: Check Backpack Stock");
            table.AddRow("4: Check Wallet Stock");
            table.AddRow("5: Check Belt Stock");
            table.Write(Format.Alternative);
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                JewleryStock();

            }
            else
            {

            }

        }
        static void JewleryStock()
        {
            
        }

    }
}