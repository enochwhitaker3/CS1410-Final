using ConsoleTables;
using static accessories.Program;
namespace accessories
{
    public class accessoriesUI
    {
        public static void accessoriesMenu()
        {
            Console.Clear();
            var table = new ConsoleTable("Accessorized Categories");
            table.AddRow("1: Check Jewlery Stock");
            table.AddRow("2: Check Stickers Stock");
            table.AddRow("3: Check Backpack Stock");
            table.AddRow("4: Check Wallet Stock");
            table.AddRow("5: Check Belt Stock");
            table.Write(Format.Alternative);
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                JewleryStock();

            }
            else
            {

            }

        }
        static void JewleryStock()
        {
            Accessories placeHolderRing = new Accessories("False P", 8.99, "Silver", "Men's");
            Accessories placeHolderNecklace = new Accessories("Stark's", 24.99, "Gold", "Women's");
            Console.Clear();
            Console.WriteLine("            [Jewlery Stock]       ");
            var table = new ConsoleTable("Brand", "Price", "Material", "Gender");
            table.AddRow(placeHolderRing._brand, placeHolderRing._price, placeHolderRing._material, placeHolderRing._gender)
            .AddRow(placeHolderNecklace._brand, placeHolderNecklace._price, placeHolderNecklace._material, placeHolderNecklace._gender);
            table.Write(Format.MarkDown);
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
                        accessoriesMenu();
                        break;
                }

            }
        }

    }
}