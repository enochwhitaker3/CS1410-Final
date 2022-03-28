using System;
using ConsoleTables;
using static main.Program;
namespace clothes
{
    public class clothingUI
    {
        public static void clothingMenu()
        {
            Console.Clear();
            var table = new ConsoleTable("Clothing Categories");
            table.AddRow("1: Check Hats Stock");
            table.AddRow("2: Check Tops Stock");
            table.AddRow("3: Check Bottoms Stock");
            table.AddRow("4: Check Socks Stock");
            table.AddRow("5: Check Shoes Stock");
            table.Write(Format.Alternative);
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 2)
            {
                Console.Clear();
                TopsStock();

            }
            else
            {

            }

        }
        static async void TopsStock()
        {
            Clothing placeHolderTop = new Clothing("Uniqlo", 17.99, "X-Large", "White", "Mens");
            Clothing placeHolderTop2 = new Clothing("Empyre", 19.99, "Small", "Yellow", "Women's");
            Console.Clear();
            Console.WriteLine("                 [Tops Stock]       ");
            var table = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender");
            table.AddRow(placeHolderTop._brand, placeHolderTop._price, placeHolderTop._size, placeHolderTop._color, placeHolderTop._gender)
            .AddRow(placeHolderTop2._brand, placeHolderTop2._price, placeHolderTop2._size, placeHolderTop2._color, placeHolderTop2._gender);
            table.Write(Format.Alternative);
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    
                    break;
                case 2:
                    Console.WriteLine("Please Enter The Brand: "); string _brand = Console.ReadLine(); 
                    Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                    Console.WriteLine("Please Enter The Color: "); string _color = Console.ReadLine();
                    Console.WriteLine("Please Enter The Gender: "); string _gender = Console.ReadLine();
                    Console.WriteLine(_brand);
                    break;
                default:

                    break;
            }

            


        }
    }
}








