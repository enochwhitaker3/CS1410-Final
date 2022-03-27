using System;
using static main.Program;
namespace accessories
{
    public class accessoriesUI
    {
        public static void accessoriesMenu()
        {
           Console.Clear();
            Console.WriteLine("           Accessorized Merchandise Categories                  ");
            Console.WriteLine("\nPlease Pick An Option");
            Console.WriteLine("\n||------------------------------||");
            Console.WriteLine("|| 1: Check Jewlery Stock       ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 2: Check Stickers Stock      ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 3: Check Backpack Stock      ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 4: Check Wallet Stock        ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 5: Check Belt Stock          ||");
            Console.WriteLine("||------------------------------||\n");
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