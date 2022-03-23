using System;
class Program
{
    
    public abstract class Merchandise
    {
        public Merchandise(string Brand, double Price)
        {

        }
    
    }
    
    public class Clothing : Merchandise
    {
        public string _brand; public double _price; public string _size; public string _color; public string _gender;
        public Clothing(string Brand, double Price, string Size, string Color, string Gender) : base(Brand, Price)
        {
            this._brand = Brand;
            this._price = Price;
            this._size = Size;
            this._color = Color;
            this._gender = Gender;
        }
    }
    public class Skating: Merchandise
    {
        public string _brand; public double _price; public string _size;
        public Skating(string Brand, double Price, string Size) : base(Brand, Price)
        {
            this._brand = Brand;
            this._price = Price;
            this._size = Size;
        }
    }
    public class Accessories: Merchandise
    {
        public string _brand; public double _price; public string _material; public string _gender;
        public Accessories(string Brand, double Price, string Material, string Gender) : base(Brand, Price)
        {
            this._brand = Brand;
            this._price = Price;
            this._material = Material;
            this._gender = Gender;
        }
    }
    public static void menu()
    {
        
        Console.Clear();
        Console.WriteLine("Please Enter Your Name");
        string user = Console.ReadLine();
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
        
        
    }

    public static void Main()
    {
        menu();
        //Clothing shirt = new Clothing("Empyre", 9.99, "XL", "Black", "Men's");
        //Console.WriteLine($"The {shirt._brand} hat costs {shirt._price} ");
        
    }
}