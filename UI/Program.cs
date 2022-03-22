using System;
class Program
{
    public class Merchandise
    {
        public string? Brand;
        public double Price;

    }
    public class Clothing : Merchandise
    {
        
    }
    public class Skating: Merchandise
    {

    }
    public class Accessories: Merchandise
    {

    }
    public static void Main()
    {
        Console.WriteLine("Welcome to ACME Skate Shop's Inventory");

        Clothing hat = new Clothing();
        hat.Brand = "Empyre";
        Console.WriteLine($"{hat.Brand}");
        
    }
}