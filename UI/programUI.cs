using ConsoleTables;
using clothing;
using skateboarding;
using accessories;
using storage;
using error;
namespace main
{
    public class Program
    {
        public static void Main()
        {
            StorageService service = new StorageService();
            Error error = new Error();

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
            table.AddRow("4: Exit");
            table.Write(Format.Alternative);
            int userInput;

            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput > 4) // Execption Handling: If not at string, or if Input is greater than 3
            {
                error.invalidinput();
                goto Start;
            }
            
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
                int clothingInput;

                while (!int.TryParse(Console.ReadLine(), out clothingInput) || clothingInput > 6)
                {
                    error.invalidinput();
                    goto clothingStart;
                }

                switch (clothingInput)
                {
                    case 1: // Hats : Clothimg
                        {
                            Console.Clear();
                            var hatsTable = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender", "Quantity");
                            service.clothingload();
                            var hatsMemory = service.clothingMemory.Where(c => c.Type == Clothing.ClothingType.Hats);
                            foreach (var item in hatsMemory)
                            {
                                hatsTable.AddRow(item.Brand, item.Price, item.Size, item.Color, item.Gender, item.Quantity);
                            }

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Hats Stock]\n");
                                hatsTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int hatInput;
                                while (!int.TryParse(Console.ReadLine(), out hatInput) || hatInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }

                                switch (hatInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        hatsTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = hatsMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
                                        hatsTable.Write(Format.MarkDown);
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
                                        service.clothingMemory.Add(newHat);
                                        service.clothingwrite();
                                        hatsTable.AddRow(newHat.Brand, newHat.Price, newHat.Size, newHat.Color, newHat.Gender, newHat.Quantity);
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
                            var topsTable = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender", "Quantity");
                            service.clothingload();
                            var topsMemory = service.clothingMemory.Where(c => c.Type == Clothing.ClothingType.Tops);
                            foreach (var item in topsMemory)
                            {
                                topsTable.AddRow(item.Brand, item.Price, item.Size, item.Color, item.Gender, item.Quantity);
                            }


                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Tops Stock]\n");
                                topsTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int topInput;
                                while (!int.TryParse(Console.ReadLine(), out topInput) || topInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (topInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        topsTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = topsMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
                                        topsTable.Write(Format.MarkDown);
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
                                        service.clothingMemory.Add(newTop);
                                        service.clothingwrite();
                                        topsTable.AddRow(newTop.Brand, newTop.Price, newTop.Size, newTop.Color, newTop.Gender, newTop.Quantity);
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
                            var bottomsTable = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender", "Quantity");
                            service.clothingload();
                            var bottomMemory = service.clothingMemory.Where(c => c.Type == Clothing.ClothingType.Bottoms);
                            foreach (var item in bottomMemory)
                            {
                                bottomsTable.AddRow(item.Brand, item.Price, item.Size, item.Color, item.Gender, item.Quantity);
                            }

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Bottoms Stock]\n");
                                bottomsTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int bottomsInput;
                                while (!int.TryParse(Console.ReadLine(), out bottomsInput) || bottomsInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (bottomsInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        bottomsTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = bottomMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
                                        bottomsTable.Write(Format.MarkDown);
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
                                        service.clothingMemory.Add(newBottom);
                                        service.clothingwrite();
                                        bottomsTable.AddRow(newBottom.Brand, newBottom.Price, newBottom.Size, newBottom.Color, newBottom.Gender, newBottom.Quantity);
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
                            var socksTable = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender", "Quantity");
                            service.clothingload();
                            var socksMemory = service.clothingMemory.Where(c => c.Type == Clothing.ClothingType.Socks);
                            foreach (var item in socksMemory)
                            {
                                socksTable.AddRow(item.Brand, item.Price, item.Size, item.Color, item.Gender, item.Quantity);
                            }
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Socks Stock]\n");
                                socksTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int socksInput;
                                while (!int.TryParse(Console.ReadLine(), out socksInput) || socksInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (socksInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        socksTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = socksMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
                                        socksTable.Write(Format.MarkDown);
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
                                        service.clothingMemory.Add(newSock);
                                        service.clothingwrite();
                                        socksTable.AddRow(newSock.Brand, newSock.Price, newSock.Size, newSock.Color, newSock.Gender, newSock.Quantity);
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

                            var shoesTable = new ConsoleTable("Brand", "Price", "Size", "Color", "Gender", "Quantity");
                            service.clothingload();
                            var shoesMemory = service.clothingMemory.Where(c => c.Type == Clothing.ClothingType.Shoes);
                            foreach (var item in shoesMemory)
                            {
                                shoesTable.AddRow(item.Brand, item.Price, item.Size, item.Color, item.Gender, item.Quantity);
                            }

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Shoes Stock]\n");
                                shoesTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int shoesInput;
                                while (!int.TryParse(Console.ReadLine(), out shoesInput) || shoesInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (shoesInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        shoesTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = shoesMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
                                        shoesTable.Write(Format.MarkDown);
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
                                        service.clothingMemory.Add(newShoe);
                                        service.clothingwrite();
                                        shoesTable.AddRow(newShoe.Brand, newShoe.Price, newShoe.Size, newShoe.Color, newShoe.Gender, newShoe.Quantity);
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
                int skateInput;
                while (!int.TryParse(Console.ReadLine(), out skateInput) || skateInput > 6)
                {
                    error.invalidinput();
                    goto skateboardingStart;
                }

                switch (skateInput)
                {
                    case 1: // Grip Tape : Skateboarding
                        {
                            Console.Clear();
                            var gripTable = new ConsoleTable("Brand", "Price", "Size", "Quantity");
                            service.skateload();
                            var gripMemory = service.skateMemory.Where(c => c.Type == Skateboarding.SkateboardType.GripTape);
                            foreach (var item in gripMemory)
                            {
                                gripTable.AddRow(item.Brand, item.Price, item.Size, item.Quantity);
                            }

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Grip Tape Stock]\n");
                                gripTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int gripInput;
                                while (!int.TryParse(Console.ReadLine(), out gripInput) || gripInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (gripInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        gripTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = gripMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
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
                                        service.skateMemory.Add(newGripTape);
                                        service.skatewrite();
                                        gripTable.AddRow(newGripTape.Brand, newGripTape.Price, newGripTape.Size, newGripTape.Quantity);
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
                            var deckTable = new ConsoleTable("Brand", "Price", "Size", "Quantity");
                            service.skateload();
                            var deckMemory = service.skateMemory.Where(c => c.Type == Skateboarding.SkateboardType.Decks);
                            foreach (var item in deckMemory)
                            {
                                deckTable.AddRow(item.Brand, item.Price, item.Size, item.Quantity);
                            }

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Deck Stock]\n");
                                deckTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int deckInput;
                                while (!int.TryParse(Console.ReadLine(), out deckInput) || deckInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }

                                switch (deckInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        deckTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = deckMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
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
                                        service.skateMemory.Add(newDeck);
                                        service.skatewrite();
                                        deckTable.AddRow(newDeck.Brand, newDeck.Price, newDeck.Size, newDeck.Quantity);
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

                            var truckTable = new ConsoleTable("Brand", "Price", "Size", "Quantity");
                            service.skateload();
                            var truckMemory = service.skateMemory.Where(c => c.Type == Skateboarding.SkateboardType.Trucks);
                            foreach (var item in truckMemory)
                            {
                                truckTable.AddRow(item.Brand, item.Price, item.Size, item.Quantity);
                            }


                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Truck Stock]\n");
                                truckTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int truckInput;
                                while (!int.TryParse(Console.ReadLine(), out truckInput) || truckInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (truckInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        truckTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = truckMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
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
                                        service.skateMemory.Add(newTruck);
                                        service.skatewrite();
                                        truckTable.AddRow(newTruck.Brand, newTruck.Price, newTruck.Size, newTruck.Quantity);
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

                            var bearingTable = new ConsoleTable("Brand", "Price", "Size", "Quantity");
                            service.skateload();
                            var bearingMemory = service.skateMemory.Where(c => c.Type == Skateboarding.SkateboardType.Bearings);
                            foreach (var item in bearingMemory)
                            {
                                bearingTable.AddRow(item.Brand, item.Price, item.Size, item.Quantity);
                            }


                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Bearings Stock]\n");
                                bearingTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int bearingInput;
                                while (!int.TryParse(Console.ReadLine(), out bearingInput) || bearingInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (bearingInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        bearingTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = bearingMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
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
                                        service.skateMemory.Add(newBearing);
                                        service.skatewrite();
                                        bearingTable.AddRow(newBearing.Brand, newBearing.Price, newBearing.Size, newBearing.Quantity);
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

                            var wheelTable = new ConsoleTable("Brand", "Price", "Size", "Quantity");
                            service.skateload();
                            var wheelMemory = service.skateMemory.Where(c => c.Type == Skateboarding.SkateboardType.Wheels);
                            foreach (var item in wheelMemory)
                            {
                                wheelTable.AddRow(item.Brand, item.Price, item.Size, item.Quantity);
                            }


                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Wheels Stock]\n");
                                wheelTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int wheelInput;
                                while (!int.TryParse(Console.ReadLine(), out wheelInput) || wheelInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (wheelInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        wheelTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = wheelMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
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
                                        service.skateMemory.Add(newWheel);
                                        service.skatewrite();
                                        wheelTable.AddRow(newWheel.Brand, newWheel.Price, newWheel.Size, newWheel.Quantity);
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
                int accessoriesInput;
                while (!int.TryParse(Console.ReadLine(), out accessoriesInput) || accessoriesInput > 6)
                {
                    error.invalidinput();
                    goto accessoriesStart;
                }
                switch (accessoriesInput)
                {
                    case 1: // Jewlery : Accessories
                        {
                            Console.Clear();
                            service.accessoriesload();
                            var jewleryTable = new ConsoleTable("Brand", "Price", "Material", "Quantity");
                            var jewleryMemory = service.accessoriesMemory.Where(c => c.Type == Accessories.AccessoriesType.Jewlery);
                            foreach (var item in jewleryMemory)
                            {
                                jewleryTable.AddRow(item.Brand, item.Price, item.Material, item.Quantity);
                            }
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Jewlery Stock]\n");
                                jewleryTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int jewleryInput;
                                while (!int.TryParse(Console.ReadLine(), out jewleryInput) || jewleryInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }

                                switch (jewleryInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        jewleryTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = jewleryMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
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
                                        service.accessoriesMemory.Add(newJewlery);
                                        service.accessorieswrite();
                                        jewleryTable.AddRow(newJewlery.Brand, newJewlery.Price, newJewlery.Material, newJewlery.Quantity);
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
                            service.accessoriesload();
                            var stickerTable = new ConsoleTable("Brand", "Price", "Material", "Quantity");
                            var stickerMemory = service.accessoriesMemory.Where(c => c.Type == Accessories.AccessoriesType.Stickers);
                            foreach (var item in stickerMemory)
                            {
                                stickerTable.AddRow(item.Brand, item.Price, item.Material, item.Quantity);
                            }
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Stickers Stock]\n");
                                stickerTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int stickerInput;
                                while (!int.TryParse(Console.ReadLine(), out stickerInput) || stickerInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (stickerInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        stickerTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = stickerMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
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
                                        service.accessoriesMemory.Add(newSticker);
                                        service.accessorieswrite();
                                        stickerTable.AddRow(newSticker.Brand, newSticker.Price, newSticker.Material, newSticker.Quantity);
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
                            var backpackTable = new ConsoleTable("Brand", "Price", "Material", "Quantity");
                            service.accessoriesload();
                            var backpackMemory = service.accessoriesMemory.Where(c => c.Type == Accessories.AccessoriesType.Backpack);
                            foreach (var item in backpackMemory)
                            {
                                backpackTable.AddRow(item.Brand, item.Price, item.Material, item.Quantity);
                            }
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Backpack Stock]\n");
                                backpackTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int backpackInput;
                                while (!int.TryParse(Console.ReadLine(), out backpackInput) || backpackInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (backpackInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        backpackTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = backpackMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
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
                                        service.accessoriesMemory.Add(newBackPack);
                                        service.accessorieswrite();
                                        backpackTable.AddRow(newBackPack.Brand, newBackPack.Price, newBackPack.Material, newBackPack.Quantity);
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
                            var walletTable = new ConsoleTable("Brand", "Price", "Material", "Quantity");
                            service.accessoriesload();
                            var walletMemory = service.accessoriesMemory.Where(c => c.Type == Accessories.AccessoriesType.Wallet);
                            foreach (var item in walletMemory)
                            {
                                walletTable.AddRow(item.Brand, item.Price, item.Material, item.Quantity);
                            }
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Wallet Stock]\n");
                                walletTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int walletInput;
                                while (!int.TryParse(Console.ReadLine(), out walletInput) || walletInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (walletInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        walletTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = walletMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
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
                                        service.accessoriesMemory.Add(newWallet);
                                        service.accessorieswrite();
                                        walletTable.AddRow(newWallet.Brand, newWallet.Price, newWallet.Material, newWallet.Quantity);
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
                            var beltTable = new ConsoleTable("Brand", "Price", "Material", "Quantity");
                            service.accessoriesload();
                            var beltMemory = service.accessoriesMemory.Where(c => c.Type == Accessories.AccessoriesType.Belt);
                            foreach (var item in beltMemory)
                            {
                                beltTable.AddRow(item.Brand, item.Price, item.Material, item.Quantity);
                            }

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("[Belt Stock]\n");
                                beltTable.Write(Format.MarkDown);
                                Console.WriteLine("[1]Add Quantity\n[2]Add New Item\n[3]Exit\n");
                                int beltInput;
                                while (!int.TryParse(Console.ReadLine(), out beltInput) || beltInput > 3)
                                {
                                    error.invalidinput();
                                    break;
                                }
                                switch (beltInput)
                                {
                                    case 1: // Add Quantity
                                        Console.Clear();
                                        Console.WriteLine("Which Item Would You Like To Add Too?\n");
                                        beltTable.Write(Format.MarkDown);

                                        string input = Console.ReadLine();

                                        var match = beltMemory.FirstOrDefault(h => h.Brand == input);
                                        if (match == null)
                                        {
                                            Console.WriteLine("No Match Was Found");
                                            continue;
                                        }

                                        match.Quantity++;
                                        Console.Clear();
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
                                        service.accessoriesMemory.Add(newBelt);
                                        service.accessorieswrite();
                                        beltTable.AddRow(newBelt.Brand, newBelt.Price, newBelt.Material, newBelt.Quantity);
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
            else if (userInput == 4) // Exit the program
            {
                System.Environment.Exit(0);
            }
        }
    }
}
