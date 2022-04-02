using System.Collections.Generic;
using ConsoleTables;
using static clothing.Program;
namespace clothes
{
    public class clothingUI
    {
        public static void clothingMenu()
        {
            Clothing placeHolderTop = new Clothing("False P", 17.99, "X-Large", "White", "Mens");
            Clothing placeHolderTop2 = new Clothing("Empyre", 19.99, "Small", "Yellow", "Women's");
            List<Clothing> Memory = new List<Clothing>();
            Memory.Add(placeHolderTop);
            Memory.Add(placeHolderTop2);

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
                Console.Clear();
                // method in Clothing.cs called "public string DisplayItems()"
                foreach (Clothing item in Memory)
                {
                    Console.WriteLine(item._brand);
                }
                /*Console.WriteLine("                 [Tops Stock]       ");
                var table = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender");
                table.AddRow(Memory[0]._brand, Memory[0]._price, Memory[0]._size, Memory[0]._color, Memory[0]._gender)
                .AddRow(Memory[1]._brand, Memory[1]._price, Memory[1]._size, Memory[1]._color, Memory[1]._gender);
                table.Write(Format.MarkDown);*/
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("editing in progress.....");
                            break;
                        case 2:
                        //could be in Program.cs 
                            Console.Clear();
                            Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                            Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                            Console.WriteLine("Please Enter The Color: "); string _color = Console.ReadLine();
                            Console.WriteLine("Please Enter The Gender: "); string _gender = Console.ReadLine();
                            Clothing newTop = new Clothing(_brand, _price, _size, _color, _gender);
                            Memory.Add(newTop);
                            //table.AddRow(newTop._brand, newTop._price, newTop._size, newTop._color, newTop._gender); Console.Clear();
                            //table.Write(Format.MarkDown);
                            break;
                        case 3:
                            clothingMenu();
                            break;
                    }

                }

            }
            else
            {

            }

        }
    }

}









