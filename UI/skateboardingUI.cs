using System;
using static main.Program;
namespace skateboarding
{
    public class skateboardingUI
    {
        public static void skateboardingMenu()
        {
            Console.Clear();
            Console.WriteLine("           Skating Merchandise Stock                  ");
            Console.WriteLine("\nPlease Pick An Option");
            Console.WriteLine("\n||------------------------------||");
            Console.WriteLine("|| 1: Check Tops Stock                ||");
            Console.WriteLine("||------------------------------||\n");
        /*Console.WriteLine("|| 2: Tops Stock                ||");
        Console.WriteLine("||------------------------------||");
        Console.WriteLine("|| 3: Bottoms Stock             ||");
        Console.WriteLine("||------------------------------||");
        Console.WriteLine("|| 4: Socks Stock               ||");
        Console.WriteLine("||------------------------------||");
        Console.WriteLine("|| 5: Shoes Stock               ||");
        Console.WriteLine("||------------------------------||\n");
        string _brand = Console.ReadLine();
        double _price = Convert.ToDouble(Console.ReadLine());
        string _size = Console.ReadLine();
        string _color = Console.ReadLine();
        string _gender = Console.ReadLine();
        Clothing shirt = new Clothing(_brand, _price, _size, _color, _gender);
        Console.WriteLine($"Merch: {shirt._brand}");*/
        Start:
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                TopsStock();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("invalid input!\n");
                Thread.Sleep(1000);
                goto Start;
            }
            static void TopsStock()
            {
                Console.WriteLine("hello");
            }
        }
    }
}