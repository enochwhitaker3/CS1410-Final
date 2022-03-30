
using ConsoleTables;
using static skateboarding.Program;
namespace skateboarding
{
    public class skateboardingUI
    {
        public static void skateboardingMenu()
        {
            Console.Clear();
            var table = new ConsoleTable("Skateboarding Categories");
            table.AddRow("1: Check Grip Tape Stock");
            table.AddRow("2: Check Decks Stock");
            table.AddRow("3: Check Trucks Stock");
            table.AddRow("4: Check Bearings Stock");
            table.AddRow("5: Check Wheel Stock");
            table.Write(Format.Alternative);
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                GriptapeStock();

            }
            else
            {

            }

        }
        static void GriptapeStock()
        {
                Skateboarding placeHolderGripTape = new Skateboarding("Thrasher", 14.99, "X-Large");
                Skateboarding placeHolderGripTape2 = new Skateboarding("Mob", 5.99, "Small");
                Console.Clear();
                Console.WriteLine("       [Grip Tape Stock]       ");
                var table = new ConsoleTable("Brand", "Price", "Size");
                table.AddRow(placeHolderGripTape._brand, placeHolderGripTape._price, placeHolderGripTape._size)
                .AddRow(placeHolderGripTape2._brand, placeHolderGripTape2._price, placeHolderGripTape2._size);
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
                        Console.WriteLine("Please Enter The Size: "); string _size = Console.ReadLine();
                        table.AddRow(_brand, _price, _size);
                        Console.Clear();
                        table.Write(Format.MarkDown);
                        break;
                    case 3:
                        skateboardingMenu();
                        break;
                }
                
            }
        }
    }
}