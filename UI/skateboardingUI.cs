using System;
using ConsoleTables;
using static main.Program;
namespace skateboarding
{
    public class skateboardingUI
    {
        public static void skateboardingMenu()
        {
            Console.Clear();
            var table = new ConsoleTable("Skateboarding Categories");
            table.AddRow("1: Check Grip Tape Stock");
            table.AddRow("2: Check Decks Stock");
            table.AddRow("3: Check Trucks Stock");
            table.AddRow("4: Check Bearings Stock");
            table.AddRow("5: Check Wheel Stock");
            table.Write(Format.Alternative);
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                GriptapeStock();

            }
            else
            {

            }

        }
        static void GriptapeStock()
        {

        }
    }
}