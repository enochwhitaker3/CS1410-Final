using ConsoleTables;
using static clothing.Program;
using static skateboarding.Program;
using static accessories.Program;
namespace main
{
    public class Program
    {
        public static void Main()
        {
            Clothing placeHolderTop = new Clothing("False P", 17.99, "X-Large", "White", "Mens", 5, Clothing.ClothingType.Tops);   
            Clothing placeHolderTop2 = new Clothing("Empyre", 19.99, "Small", "Yellow", "Women's", 3, Clothing.ClothingType.Tops);
            List<Clothing> Memory = new List<Clothing>();
            Memory.Add(placeHolderTop);
            Memory.Add(placeHolderTop2);
            int i = 0;
            Console.Clear();
            Console.WriteLine("Please Enter Your Name");
            string user = Console.ReadLine();
        Start:
            Console.Clear();
            Console.WriteLine($"Welcome Back Manager {user} to ACME Skate Shop's Inventory!");
            Console.WriteLine("\nWhich Stock Would You Like To Check Today?");
            var table = new ConsoleTable("Categories");
            table.AddRow("1: Clothing Merchandise");
            table.AddRow("2: Skateboarding Merchandise");
            table.AddRow("3: Accessorized Merchandise");
            table.Write(Format.Alternative);
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
            clothingStart:
                Console.Clear();
                var clothingTable = new ConsoleTable("Clothing Categories");
                clothingTable.AddRow("1: Check Hats Stock");
                clothingTable.AddRow("2: Check Tops Stock");
                clothingTable.AddRow("3: Check Bottoms Stock");
                clothingTable.AddRow("4: Check Socks Stock");
                clothingTable.AddRow("5: Check Shoes Stock");
                clothingTable.Write(Format.Alternative);
                var clothingInput = Convert.ToInt32(Console.ReadLine());
                switch (clothingInput)
                {
                    
                    case 2:
                        {  
                            i = 0;
                            Console.Clear();
                            Console.WriteLine("                     [Tops Stock]       ");
                            var topsTable = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender", "Quantity");
                            foreach (var item in Memory)
                            {
                                topsTable.AddRow(Memory[i]._brand, Memory[i]._price, Memory[i]._size, Memory[i]._color, Memory[i]._gender, Memory[i]._quantity);
                                i = i + 1;
                            }

                            topsTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int topInput = Convert.ToInt32(Console.ReadLine());
                                switch (topInput)
                                {
                                    case 1:
                                        Console.WriteLine("editing in progress.....");

                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Color: "); string _color = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Gender: "); string _gender = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Clothing.ClothingType _type = Clothing.ClothingType.Tops;
                                        Clothing newTop = new Clothing(_brand, _price, _size, _color, _gender, _quantity, _type);
                                        Memory.Add(newTop);
                                        topsTable.AddRow(Memory[i]._brand, Memory[i]._price, Memory[i]._size, Memory[i]._color, Memory[i]._gender, Memory[i]._quantity);
                                        Console.Clear();
                                        topsTable.Write(Format.MarkDown);

                                        break;
                                    case 3:
                                        goto clothingStart;
                                }

                            }

 
                        }
                        
                }

            }
            else if (userInput == 2)
            {
                Console.Clear();
                var skateTable = new ConsoleTable("Skateboarding Categories");
                skateTable.AddRow("1: Check Grip Tape Stock");
                skateTable.AddRow("2: Check Decks Stock");
                skateTable.AddRow("3: Check Trucks Stock");
                skateTable.AddRow("4: Check Bearings Stock");
                skateTable.AddRow("5: Check Wheel Stock");
                skateTable.Write(Format.Alternative);
                var skateInput = Convert.ToInt32(Console.ReadLine());
                if (skateInput == 1)
                {
                    Console.Clear();
                    Skateboarding placeHolderGripTape = new Skateboarding("Thrasher", 14.99, "X-Large");
                    Skateboarding placeHolderGripTape2 = new Skateboarding("Mob", 5.99, "Small");
                    Console.Clear();
                    Console.WriteLine("       [Grip Tape Stock]       ");
                    var griptapeTable = new ConsoleTable("Brand", "Price", "Size");
                    griptapeTable.AddRow(placeHolderGripTape._brand, placeHolderGripTape._price, placeHolderGripTape._size)
                    .AddRow(placeHolderGripTape2._brand, placeHolderGripTape2._price, placeHolderGripTape2._size);
                    table.Write(Format.MarkDown);
                    for (int j = 0; i < 100; j++)
                    {
                        Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                Console.WriteLine("editing in progress.....");
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                table.AddRow(_brand, _price, _size);
                                Console.Clear();
                                table.Write(Format.MarkDown);
                                break;
                            case 3:
                                Console.WriteLine("editing in progress.....");
                                break;
                        }

                    }
                }
            }
            else if (userInput == 3)
            {
                Console.Clear();
                var accessoriesTable = new ConsoleTable("Accessorized Categories");
                accessoriesTable.AddRow("1: Check Jewlery Stock");
                accessoriesTable.AddRow("2: Check Stickers Stock");
                accessoriesTable.AddRow("3: Check Backpack Stock");
                accessoriesTable.AddRow("4: Check Wallet Stock");
                accessoriesTable.AddRow("5: Check Belt Stock");
                accessoriesTable.Write(Format.Alternative);
                var accessoriesInput = Convert.ToInt32(Console.ReadLine());
                if (accessoriesInput == 1)
                {
                    Console.Clear();
                    Accessories placeHolderRing = new Accessories("False P", 8.99, "Silver", "Men's");
                    Accessories placeHolderNecklace = new Accessories("Stark's", 24.99, "Gold", "Women's");
                    Console.Clear();
                    Console.WriteLine("            [Jewlery Stock]       ");
                    var jewleryTable = new ConsoleTable("Brand", "Price", "Material", "Gender");
                    jewleryTable.AddRow(placeHolderRing._brand, placeHolderRing._price, placeHolderRing._material, placeHolderRing._gender)
                    .AddRow(placeHolderNecklace._brand, placeHolderNecklace._price, placeHolderNecklace._material, placeHolderNecklace._gender);
                    table.Write(Format.MarkDown);
                    for (int j = 0; i < 100; j++)
                    {
                        Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                Console.WriteLine("editing in progress.....");
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Please Enter The Material: "); string _material = Console.ReadLine();
                                Console.WriteLine("Please Enter The Gender: "); string _gender = Console.ReadLine();
                                table.AddRow(_brand, _price, _material, _gender);
                                Console.Clear();
                                table.Write(Format.MarkDown);
                                break;
                            case 3:
                                Console.WriteLine("editing in progress.....");
                                break;
                        }

                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("invalid input!\n");
                Thread.Sleep(1000);
                goto Start;
            }
        }
    }
}
