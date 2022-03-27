using System;
using static main.Program;
namespace skateboarding
{
    public class skateboardingUI
    {
        public static void skateboardingMenu()
        {
            Console.Clear();
            Console.WriteLine("           Clothing Merchandise Categories                  ");
            Console.WriteLine("\nPlease Pick An Option");
            Console.WriteLine("\n||------------------------------||");
            Console.WriteLine("|| 1: Check Grip Tape Stock     ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 2: Check Decks Stock         ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 3: Check Trucks Stock        ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 4: Check Bearings Stock      ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 5: Check Wheel Stock         ||");
            Console.WriteLine("||------------------------------||\n");
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