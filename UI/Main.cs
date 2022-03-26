using System;
using static clothes.clothingUI;
using static skateboarding.skateboardingUI;
using static accessories.accessoriesUI;
namespace main
{
    public class Program
    {

        interface IMerchandise
        {
            string Brand { get; set; }
            double Price { get; set; }

        }

        public class Clothing : IMerchandise
        {
            public string _brand; public double _price; public string _size; public string _color; public string _gender;
            public string Brand { get; set; }
            public double Price { get; set; }
            public Clothing(string Brand, double Price, string Size, string Color, string Gender)
            {
                this._brand = Brand;
                this._price = Price;
                this._size = Size;
                this._color = Color;
                this._gender = Gender;
            }
        }
        public class Skating : IMerchandise
        {
            public string _brand; public double _price; public string _size;
            public string Brand { get; set; }
            public double Price { get; set; }
            public Skating(string Brand, double Price, string Size)
            {
                this._brand = Brand;
                this._price = Price;
                this._size = Size;
            }
        }
        public class Accessories : IMerchandise
        {
            public string _brand; public double _price; public string _material; public string _gender;
            public string Brand { get; set; }
            public double Price { get; set; }
            public Accessories(string Brand, double Price, string Material, string Gender)
            {
                this._brand = Brand;
                this._price = Price;
                this._material = Material;
                this._gender = Gender;
            }
        }
        public static void mainUI()
        {
            /*Clothing newClothing = new Clothing("adidas", 3.99, "small", "blue", "male");
            newClothing._price = 4.99;
            Console.WriteLine(newClothing._price);*/

            Console.Clear();
            Console.WriteLine("Please Enter Your Name");
            string user = Console.ReadLine();
        Start:
            Console.Clear();
            Console.WriteLine($"Welcome Back Manager {user} to ACME Skate Shop's Inventory!");
            Console.WriteLine("\nWhich Stock Would You Like To Check Today?");
            Console.WriteLine("\n||------------------------------||");
            Console.WriteLine("|| 1: Clothing Merchandise      ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 2: Skateboarding Merchandise ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 3: Accessorized Merchandise  ||");
            Console.WriteLine("||------------------------------||\n");
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                Console.WriteLine("Loading Clothing Merchandise Stock.");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading Clothing Merchandise Stock..");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading Clothing Merchandise Stock...");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading Clothing Merchandise Stock....\n");
                Thread.Sleep(500);
                clothingMenu();
                
            }
            else if (userInput == 2)
            {
                Console.Clear();
                Console.WriteLine("Loading Skateboarding Merchandise Stock.");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading Skateboarding Merchandise Stock..");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading Skateboarding Merchandise Stock...");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading Skateboarding Merchandise Stock....\n");
                Thread.Sleep(500);
                skateboardingMenu();
            }
            else if (userInput == 3)
            {
                Console.Clear();
                Console.WriteLine("Loading Accessorized Merchandise Stock.");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading Accessorized Merchandise Stock..");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading Accessorized Merchandise Stock...");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading Accessorized Merchandise Stock....\n");
                Thread.Sleep(500);
                accessoriesMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("invalid input!\n");
                Thread.Sleep(1000);
                goto Start;
            }
        }
        public static void Main()
        {
            mainUI();

        }
    }
}
