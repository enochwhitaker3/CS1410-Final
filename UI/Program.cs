using System;
class Program
{
    
    interface IMerchandise
    {
        string Brand();
        double Price();
    
    }
    
    public class Clothing : IMerchandise
    {
        public string _brand; public double _price; public string _size; public string _color; public string _gender;
        public string Brand(){
            return _brand;
        }
        public double Price(){
            return _price;
        }
        public Clothing(string Brand, double Price, string Size, string Color, string Gender) 
        {
            this._brand = Brand;
            this._price = Price;
            this._size = Size;
            this._color = Color;
            this._gender = Gender;
        }
    }
    public class Skating: IMerchandise
    {
        public string _brand; public double _price; public string _size;
        public string Brand(){
            return _brand;
        }
        public double Price(){
            return _price;
        }
        public Skating(string Brand, double Price, string Size)
        {
            this._brand = Brand;
            this._price = Price;
            this._size = Size;
        }
    }
    public class Accessories: IMerchandise
    {
        public string _brand; public double _price; public string _material; public string _gender;
        public string Brand(){
            return _brand;
        }
        public double Price(){
            return _price;
        }
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
    public static void clothingMenu()
    {
        Console.Clear();
        Console.WriteLine("           Clothing Merchandise Stock                  \n");
    }
    public static void skateboardingMenu()
    {
        Console.Clear();
        Console.WriteLine("           Skateboarding Merchandise Stock                  \n");
    }
    public static void accessoriesMenu()
    {
        Console.Clear();
        Console.WriteLine("           Accessorized Merchandise Stock                  \n");
    }
    public static void Main()
    {
        mainUI();
        
        //Clothing shirt = new Clothing("Empyre", 9.99, "XL", "Black", "Men's");
        //Console.WriteLine(shirt._brand + shirt._price + shirt._size + shirt._color + shirt._gender);
        
    }
}