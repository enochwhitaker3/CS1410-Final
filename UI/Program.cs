using ConsoleTables;
using clothing;
using static skateboarding.Program;
using static accessories.Program;
namespace main
{
    public class Program
    {
        public static void Main()
        {
            List<Clothing> clothingMemory = new List<Clothing>();
            List<Skateboarding> skateMemory = new List<Skateboarding>();
            List<Accessories> accessoriesMemory = new List<Accessories>();
            Clothing placeHolderTop = new Clothing("False P", 17.99, "X-Large", "White", "Mens", 5, Clothing.ClothingType.Tops);
            Clothing placeHolderHat = new Clothing("Angel", 10.99, "One-Size", "Black", "unisex", 3, Clothing.ClothingType.Hats);
            Clothing placeHolderBottom = new Clothing("Empyre", 45.50, "medium", "Blue", "Womens", 2, Clothing.ClothingType.Bottoms);
            Clothing placeHolderSock = new Clothing("Cali-Wear", 5.99, "One-Size", "White", "Womens", 20, Clothing.ClothingType.Socks);
            Clothing placeHolderShoe = new Clothing("Nike", 65.99, "12 US", "White", "Mens", 4, Clothing.ClothingType.Shoes);


            clothingMemory.Add(placeHolderTop);
            clothingMemory.Add(placeHolderHat);
            clothingMemory.Add(placeHolderBottom);
            clothingMemory.Add(placeHolderSock);
            clothingMemory.Add(placeHolderShoe);

            Console.Clear();
            Console.WriteLine("Please Enter Your Name");
            string user = Console.ReadLine();

        Start:

            Console.Clear();
            Console.WriteLine($"Welcome Back Manager {user} to ACME Skate Shop's Inventory!");
            Console.WriteLine("\nWhich Stock Would You Like To Check Today?\n");
            var table = new ConsoleTable("Categories");
            table.AddRow("1: Clothing Merchandise");
            table.AddRow("2: Skateboarding Merchandise");
            table.AddRow("3: Accessorized Merchandise");
            table.Write(Format.Alternative);
            var userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1) // Clothing Merchandise Page
            {
            clothingStart:
                Console.Clear();
                var clothingTable = new ConsoleTable("Clothing Categories");
                clothingTable.AddRow("1: Check Hats Stock");
                clothingTable.AddRow("2: Check Tops Stock");
                clothingTable.AddRow("3: Check Bottoms Stock");
                clothingTable.AddRow("4: Check Socks Stock");
                clothingTable.AddRow("5: Check Shoes Stock");
                clothingTable.AddRow("6: Exit To Main Menu");
                clothingTable.Write(Format.Alternative);
                var clothingInput = Convert.ToInt32(Console.ReadLine());
                switch (clothingInput)
                {
                    case 1: // Hats : Clothimg
                        {

                            Console.Clear();
                            Console.WriteLine("                     [Hats Stock]       ");
                            var hatsTable = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender", "Quantity");


                            string hatsMemory = null;
                            foreach (var item in clothingMemory.Where(c => c._type == Clothing.ClothingType.Hats))
                            {
                                hatsTable.AddRow(item._brand, item._price, item._size, item._color, item._gender, item._quantity);
                                hatsMemory = item._brand;

                            }

                            hatsTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int hatInput = Convert.ToInt32(Console.ReadLine());
                                switch (hatInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        hatsTable.Write(Format.MarkDown);
                                        Console.WriteLine("\nEditing In Process...");
                                        
                                        /*string input = Console.ReadLine();
                                        for (int i = 0; i < clothingMemory.Count; i++)
                                        {
                                            Console.WriteLine(hatsMemory[i]);
                                            if (input == hatsMemory)
                                            {
                                                Console.WriteLine("Ya Ya");
                                            }
                                            else
                                            {
                                                i++;
                                            }

                                        }



                                        string attempt = Convert.ToString(clothingMemory.Where(c => c._type == Clothing.ClothingType.Hats));
                                        if (attempt.Contains(input))
                                        {
                                            Console.WriteLine("Ya Ya");
                                        }*/



                                        break;

                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Color: "); string _color = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Gender: "); string _gender = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Clothing.ClothingType _type = Clothing.ClothingType.Hats;
                                        Clothing newHat = new Clothing(_brand, _price, _size, _color, _gender, _quantity, _type);
                                        clothingMemory.Add(newHat);
                                        hatsTable.AddRow(newHat._brand, newHat._price, newHat._size, newHat._color, newHat._gender, newHat._quantity);
                                        Console.Clear();
                                        hatsTable.Write(Format.MarkDown);
                                        break;

                                    case 3: // Exit
                                        goto clothingStart;
                                }

                            }


                        }
                    case 2: // Tops : Clothing
                        {
                            Console.Clear();
                            Console.WriteLine("                     [Tops Stock]       ");
                            var topsTable = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender", "Quantity");
                            foreach (var item in clothingMemory.Where(c => c._type == Clothing.ClothingType.Tops))
                            {
                                topsTable.AddRow(item._brand, item._price, item._size, item._color, item._gender, item._quantity);
                            }

                            topsTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int topInput = Convert.ToInt32(Console.ReadLine());
                                switch (topInput)
                                {
                                    case 1: // Add Quantity
                                        Console.WriteLine("editing in progress.....");

                                        break;
                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Color: "); string _color = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Gender: "); string _gender = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Clothing.ClothingType _type = Clothing.ClothingType.Tops;
                                        Clothing newTop = new Clothing(_brand, _price, _size, _color, _gender, _quantity, _type);
                                        clothingMemory.Add(newTop);
                                        topsTable.AddRow(newTop._brand, newTop._price, newTop._size, newTop._color, newTop._gender, newTop._quantity);
                                        Console.Clear();
                                        topsTable.Write(Format.MarkDown);

                                        break;
                                    case 3: // Exit
                                        goto clothingStart;
                                }

                            }
                        }
                    case 3: // Bottoms : Clothing
                        {
                            Console.Clear();
                            Console.WriteLine("                     [Bottoms Stock]       ");
                            var bottomsTable = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender", "Quantity");
                            foreach (var item in clothingMemory.Where(c => c._type == Clothing.ClothingType.Bottoms))
                            {
                                bottomsTable.AddRow(item._brand, item._price, item._size, item._color, item._gender, item._quantity);
                            }

                            bottomsTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int bottomsInput = Convert.ToInt32(Console.ReadLine());
                                switch (bottomsInput)
                                {
                                    case 1: // Add Quantity
                                        Console.WriteLine("editing in progress.....");

                                        break;
                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Color: "); string _color = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Gender: "); string _gender = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Clothing.ClothingType _type = Clothing.ClothingType.Bottoms;
                                        Clothing newBottom = new Clothing(_brand, _price, _size, _color, _gender, _quantity, _type);
                                        clothingMemory.Add(newBottom);
                                        bottomsTable.AddRow(newBottom._brand, newBottom._price, newBottom._size, newBottom._color, newBottom._gender, newBottom._quantity);
                                        Console.Clear();
                                        bottomsTable.Write(Format.MarkDown);

                                        break;
                                    case 3: // Exit
                                        goto clothingStart;
                                }

                            }
                        }

                    case 4: // Socks : Clothing
                        {
                            Console.Clear();
                            Console.WriteLine("                     [Socks Stock]       ");
                            var socksTable = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender", "Quantity");
                            foreach (var item in clothingMemory.Where(c => c._type == Clothing.ClothingType.Socks))
                            {
                                socksTable.AddRow(item._brand, item._price, item._size, item._color, item._gender, item._quantity);
                            }

                            socksTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int socksInput = Convert.ToInt32(Console.ReadLine());
                                switch (socksInput)
                                {
                                    case 1: // Add Quantity
                                        Console.WriteLine("editing in progress.....");

                                        break;
                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Color: "); string _color = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Gender: "); string _gender = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Clothing.ClothingType _type = Clothing.ClothingType.Socks;
                                        Clothing newSock = new Clothing(_brand, _price, _size, _color, _gender, _quantity, _type);
                                        clothingMemory.Add(newSock);
                                        socksTable.AddRow(newSock._brand, newSock._price, newSock._size, newSock._color, newSock._gender, newSock._quantity);
                                        Console.Clear();
                                        socksTable.Write(Format.MarkDown);

                                        break;
                                    case 3: // Exit
                                        goto clothingStart;
                                }

                            }
                        }
                    case 5: // Shoes : Clothing
                        {
                            Console.Clear();
                            Console.WriteLine("                     [Shoes Stock]       ");
                            var shoesTable = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender", "Quantity");
                            foreach (var item in clothingMemory.Where(c => c._type == Clothing.ClothingType.Shoes))
                            {
                                shoesTable.AddRow(item._brand, item._price, item._size, item._color, item._gender, item._quantity);
                            }

                            shoesTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int shoesInput = Convert.ToInt32(Console.ReadLine());
                                switch (shoesInput)
                                {
                                    case 1: // Add Quantity
                                        Console.WriteLine("editing in progress.....");

                                        break;
                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Color: "); string _color = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Gender: "); string _gender = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Clothing.ClothingType _type = Clothing.ClothingType.Shoes;
                                        Clothing newShoe = new Clothing(_brand, _price, _size, _color, _gender, _quantity, _type);
                                        clothingMemory.Add(newShoe);
                                        shoesTable.AddRow(newShoe._brand, newShoe._price, newShoe._size, newShoe._color, newShoe._gender, newShoe._quantity);
                                        Console.Clear();
                                        shoesTable.Write(Format.MarkDown);

                                        break;
                                    case 3: // Exit
                                        goto clothingStart;
                                }

                            }
                        }
                    case 6: // Exit
                        {
                            goto Start;
                        }
                }

            }
            else if (userInput == 2) // Skateboarding Merchandise Page
            {
            skateboardingStart:
                Console.Clear();
                var skateTable = new ConsoleTable("Skateboarding Categories");
                skateTable.AddRow("1: Check Grip Tape Stock");
                skateTable.AddRow("2: Check Decks Stock");
                skateTable.AddRow("3: Check Trucks Stock");
                skateTable.AddRow("4: Check Bearings Stock");
                skateTable.AddRow("5: Check Wheel Stock");
                skateTable.AddRow("6: Exit To Main Menu");
                skateTable.Write(Format.Alternative);
                var skateInput = Convert.ToInt32(Console.ReadLine());
                switch (skateInput)
                {
                    case 1: // Grip Tape : Skateboarding
                        {
                            Console.Clear();
                            Console.WriteLine("        [Grip Tape Stock]");
                            var gripTable = new ConsoleTable("Brand", "Price", "Size", "Quantity");
                            foreach (var item in skateMemory.Where(c => c._type == Skateboarding.SkateboardType.GripTape))
                            {
                                gripTable.AddRow(item._brand, item._price, item._size, item._quantity);
                            }

                            gripTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int gripInput = Convert.ToInt32(Console.ReadLine());
                                switch (gripInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        string input = Console.ReadLine();
                                        gripTable.Write(Format.MarkDown);
                                        break;

                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Skateboarding.SkateboardType _type = Skateboarding.SkateboardType.GripTape;
                                        Skateboarding newGripTape = new Skateboarding(_brand, _price, _size, _quantity, _type);
                                        skateMemory.Add(newGripTape);
                                        gripTable.AddRow(newGripTape._brand, newGripTape._price, newGripTape._size, newGripTape._quantity);
                                        Console.Clear();
                                        gripTable.Write(Format.MarkDown);
                                        break;

                                    case 3: // Exit
                                        goto skateboardingStart;
                                }

                            }


                        }
                    case 2: // Decks : Skateboarding
                        {
                            Console.Clear();
                            Console.WriteLine("          [Deck Stock]");
                            var deckTable = new ConsoleTable("Brand", "Price", "Size", "Quantity");
                            foreach (var item in skateMemory.Where(c => c._type == Skateboarding.SkateboardType.Decks))
                            {
                                deckTable.AddRow(item._brand, item._price, item._size, item._quantity);
                            }

                            deckTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int deckInput = Convert.ToInt32(Console.ReadLine());
                                switch (deckInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        string input = Console.ReadLine();
                                        deckTable.Write(Format.MarkDown);
                                        break;

                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Skateboarding.SkateboardType _type = Skateboarding.SkateboardType.Decks;
                                        Skateboarding newDeck = new Skateboarding(_brand, _price, _size, _quantity, _type);
                                        skateMemory.Add(newDeck);
                                        deckTable.AddRow(newDeck._brand, newDeck._price, newDeck._size, newDeck._quantity);
                                        Console.Clear();
                                        deckTable.Write(Format.MarkDown);
                                        break;

                                    case 3: // Exit
                                        goto skateboardingStart;
                                }

                            }
                        }
                    case 3: // Trucks : Skateboarding
                        {
                            Console.Clear();
                            Console.WriteLine("          [Truck Stock]");
                            var truckTable = new ConsoleTable("Brand", "Price", "Size", "Quantity");
                            foreach (var item in skateMemory.Where(c => c._type == Skateboarding.SkateboardType.Trucks))
                            {
                                truckTable.AddRow(item._brand, item._price, item._size, item._quantity);
                            }

                            truckTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int truckInput = Convert.ToInt32(Console.ReadLine());
                                switch (truckInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        string input = Console.ReadLine();
                                        truckTable.Write(Format.MarkDown);
                                        break;

                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Skateboarding.SkateboardType _type = Skateboarding.SkateboardType.Trucks;
                                        Skateboarding newTruck = new Skateboarding(_brand, _price, _size, _quantity, _type);
                                        skateMemory.Add(newTruck);
                                        truckTable.AddRow(newTruck._brand, newTruck._price, newTruck._size, newTruck._quantity);
                                        Console.Clear();
                                        truckTable.Write(Format.MarkDown);
                                        break;

                                    case 3: // Exit
                                        goto skateboardingStart;
                                }

                            }
                        }

                    case 4: // Bearings : Skateboarding
                        {
                            Console.Clear();
                            Console.WriteLine("        [Bearings Stock]");
                            var bearingTable = new ConsoleTable("Brand", "Price", "Size", "Quantity");
                            foreach (var item in skateMemory.Where(c => c._type == Skateboarding.SkateboardType.Bearings))
                            {
                                bearingTable.AddRow(item._brand, item._price, item._size, item._quantity);
                            }

                            bearingTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int bearingInput = Convert.ToInt32(Console.ReadLine());
                                switch (bearingInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        string input = Console.ReadLine();
                                        bearingTable.Write(Format.MarkDown);
                                        break;

                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Skateboarding.SkateboardType _type = Skateboarding.SkateboardType.Bearings;
                                        Skateboarding newBearing = new Skateboarding(_brand, _price, _size, _quantity, _type);
                                        skateMemory.Add(newBearing);
                                        bearingTable.AddRow(newBearing._brand, newBearing._price, newBearing._size, newBearing._quantity);
                                        Console.Clear();
                                        bearingTable.Write(Format.MarkDown);
                                        break;

                                    case 3: // Exit
                                        goto skateboardingStart;
                                }

                            }
                        }
                    case 5: // Wheels : Skateboarding
                        {
                            Console.Clear();
                            Console.WriteLine("         [Wheels Stock]");
                            var wheelTable = new ConsoleTable("Brand", "Price", "Size", "Quantity");
                            foreach (var item in skateMemory.Where(c => c._type == Skateboarding.SkateboardType.Wheels))
                            {
                                wheelTable.AddRow(item._brand, item._price, item._size, item._quantity);
                            }

                            wheelTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int wheelInput = Convert.ToInt32(Console.ReadLine());
                                switch (wheelInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        string input = Console.ReadLine();
                                        wheelTable.Write(Format.MarkDown);
                                        break;

                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Skateboarding.SkateboardType _type = Skateboarding.SkateboardType.Wheels;
                                        Skateboarding newWheel = new Skateboarding(_brand, _price, _size, _quantity, _type);
                                        skateMemory.Add(newWheel);
                                        wheelTable.AddRow(newWheel._brand, newWheel._price, newWheel._size, newWheel._quantity);
                                        Console.Clear();
                                        wheelTable.Write(Format.MarkDown);
                                        break;

                                    case 3: // Exit
                                        goto skateboardingStart;
                                }

                            }
                        }
                    case 6: // Exit
                        {
                            goto Start;
                        }
                }

            }
            else if (userInput == 3) // Accessorized Merchandise Page
            {
            accessoriesStart:
                Console.Clear();
                var accessoriesTable = new ConsoleTable("Accessorized Categories");
                accessoriesTable.AddRow("1: Check Jewlery Stock");
                accessoriesTable.AddRow("2: Check Stickers Stock");
                accessoriesTable.AddRow("3: Check Backpack Stock");
                accessoriesTable.AddRow("4: Check Wallet Stock");
                accessoriesTable.AddRow("5: Check Belt Stock");
                accessoriesTable.AddRow("6: Exit To Main Menu");
                accessoriesTable.Write(Format.Alternative);
                var accessoriesInput = Convert.ToInt32(Console.ReadLine());
                switch (accessoriesInput)
                {
                    case 1: // Jewlery : Accessories
                        {
                            Console.Clear();
                            Console.WriteLine("           [Jewlery Stock]");
                            var jewleryTable = new ConsoleTable("Brand", "Price", "Material", "Quantity");
                            foreach (var item in accessoriesMemory.Where(c => c._type == Accessories.AccessoriesType.Jewlery))
                            {
                                jewleryTable.AddRow(item._brand, item._price, item._material, item._quantity);
                            }

                            jewleryTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int jewleryInput = Convert.ToInt32(Console.ReadLine());
                                switch (jewleryInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        string input = Console.ReadLine();
                                        jewleryTable.Write(Format.MarkDown);
                                        break;

                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Material: "); string _material = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Accessories.AccessoriesType _type = Accessories.AccessoriesType.Jewlery;
                                        Accessories newJewlery = new Accessories(_brand, _price, _material, _quantity, _type);
                                        accessoriesMemory.Add(newJewlery);
                                        jewleryTable.AddRow(newJewlery._brand, newJewlery._price, newJewlery._material, newJewlery._quantity);
                                        Console.Clear();
                                        jewleryTable.Write(Format.MarkDown);
                                        break;

                                    case 3: // Exit
                                        goto accessoriesStart;
                                }

                            }

                        }
                    case 2: // Stickers : Accessories
                        {
                            Console.Clear();
                            Console.WriteLine("          [Stickers Stock]");
                            var stickerTable = new ConsoleTable("Brand", "Price", "Material", "Quantity");
                            foreach (var item in accessoriesMemory.Where(c => c._type == Accessories.AccessoriesType.Stickers))
                            {
                                stickerTable.AddRow(item._brand, item._price, item._material, item._quantity);
                            }

                            stickerTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int stickerInput = Convert.ToInt32(Console.ReadLine());
                                switch (stickerInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        string input = Console.ReadLine();
                                        stickerTable.Write(Format.MarkDown);
                                        break;

                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Material: "); string _material = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Accessories.AccessoriesType _type = Accessories.AccessoriesType.Stickers;
                                        Accessories newSticker = new Accessories(_brand, _price, _material, _quantity, _type);
                                        accessoriesMemory.Add(newSticker);
                                        stickerTable.AddRow(newSticker._brand, newSticker._price, newSticker._material, newSticker._quantity);
                                        Console.Clear();
                                        stickerTable.Write(Format.MarkDown);
                                        break;

                                    case 3: // Exit
                                        goto accessoriesStart;
                                }

                            }
                        }
                    case 3: // Backpacks : Accessories
                        {
                            Console.Clear();
                            Console.WriteLine("          [Backpack Stock]");
                            var backpackTable = new ConsoleTable("Brand", "Price", "Material", "Quantity");
                            foreach (var item in accessoriesMemory.Where(c => c._type == Accessories.AccessoriesType.Backpack))
                            {
                                backpackTable.AddRow(item._brand, item._price, item._material, item._quantity);
                            }

                            backpackTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int backpackInput = Convert.ToInt32(Console.ReadLine());
                                switch (backpackInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        string input = Console.ReadLine();
                                        backpackTable.Write(Format.MarkDown);
                                        break;

                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Material: "); string _material = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Accessories.AccessoriesType _type = Accessories.AccessoriesType.Backpack;
                                        Accessories newBackPack = new Accessories(_brand, _price, _material, _quantity, _type);
                                        accessoriesMemory.Add(newBackPack);
                                        backpackTable.AddRow(newBackPack._brand, newBackPack._price, newBackPack._material, newBackPack._quantity);
                                        Console.Clear();
                                        backpackTable.Write(Format.MarkDown);
                                        break;

                                    case 3: // Exit
                                        goto accessoriesStart;
                                }

                            }
                        }

                    case 4: // Wallet : Accessories
                        {
                            Console.Clear();
                            Console.WriteLine("           [Wallet Stock]");
                            var walletTable = new ConsoleTable("Brand", "Price", "Material", "Quantity");
                            foreach (var item in accessoriesMemory.Where(c => c._type == Accessories.AccessoriesType.Wallet))
                            {
                                walletTable.AddRow(item._brand, item._price, item._material, item._quantity);
                            }

                            walletTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int walletInput = Convert.ToInt32(Console.ReadLine());
                                switch (walletInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        string input = Console.ReadLine();
                                        walletTable.Write(Format.MarkDown);
                                        break;

                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Material: "); string _material = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Accessories.AccessoriesType _type = Accessories.AccessoriesType.Wallet;
                                        Accessories newWallet = new Accessories(_brand, _price, _material, _quantity, _type);
                                        accessoriesMemory.Add(newWallet);
                                        walletTable.AddRow(newWallet._brand, newWallet._price, newWallet._material, newWallet._quantity);
                                        Console.Clear();
                                        walletTable.Write(Format.MarkDown);
                                        break;

                                    case 3: // Exit
                                        goto accessoriesStart;
                                }

                            }
                        }
                    case 5: // Belt : Accessories
                        {
                            Console.Clear();
                            Console.WriteLine("            [Belt Stock]");
                            var beltTable = new ConsoleTable("Brand", "Price", "Material", "Quantity");
                            foreach (var item in accessoriesMemory.Where(c => c._type == Accessories.AccessoriesType.Belt))
                            {
                                beltTable.AddRow(item._brand, item._price, item._material, item._quantity);
                            }

                            beltTable.Write(Format.MarkDown);
                            while (true)
                            {
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int beltInput = Convert.ToInt32(Console.ReadLine());
                                switch (beltInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        string input = Console.ReadLine();
                                        beltTable.Write(Format.MarkDown);
                                        break;

                                    case 2: // Add new item
                                        Console.Clear();
                                        Console.WriteLine("\nPlease Enter The Brand: "); string _brand = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Price: "); double _price = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Please Enter The Material: "); string _material = Console.ReadLine();
                                        Console.WriteLine("Please Enter The Desired Quantity"); int _quantity = Convert.ToInt32(Console.ReadLine());
                                        Accessories.AccessoriesType _type = Accessories.AccessoriesType.Belt;
                                        Accessories newBelt = new Accessories(_brand, _price, _material, _quantity, _type);
                                        accessoriesMemory.Add(newBelt);
                                        beltTable.AddRow(newBelt._brand, newBelt._price, newBelt._material, newBelt._quantity);
                                        Console.Clear();
                                        beltTable.Write(Format.MarkDown);
                                        break;

                                    case 3: // Exit
                                        goto accessoriesStart;
                                }

                            }
                        }
                    case 6: // Exit
                        {
                            goto Start;

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
