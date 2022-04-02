using ConsoleTables;
using static clothes.clothingUI;
using static skateboarding.skateboardingUI;
using static accessories.accessoriesUI;
namespace main
{
    public class Program
    {
        public static void Main()
        {
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
    }
}
