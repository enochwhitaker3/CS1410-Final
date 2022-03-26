using System;
using static main.Program;
namespace clothes
{
    public class clothingUI
    {
        public static void clothingMenu()
        {
            Console.Clear();
            Console.WriteLine("           Clothing Merchandise Categories                  ");
            Console.WriteLine("\nPlease Pick An Option");
            Console.WriteLine("\n||------------------------------||");
            Console.WriteLine("|| 1: Check Tops Stock          ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 2: Tops Stock                ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 3: Bottoms Stock             ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 4: Socks Stock               ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 5: Shoes Stock               ||");
            Console.WriteLine("||------------------------------||\n");
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
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
            Console.WriteLine("                        -[Tops Stock]-              ");
            Console.WriteLine("||===============================================================||");
            Console.WriteLine("|| Brand     || Price     || Size      || Color     || Gender    ||");
            Console.WriteLine("||===========||===========||===========||===========||===========||");
            Console.WriteLine(String.Format("|| {0,-10}|| {1,-10}|| {2,-10}|| {3,-10}|| {4,-10}||", $"{placeHolderTop._brand}", $"{placeHolderTop._price}", $"{placeHolderTop._size}", $"{placeHolderTop._color}", $"{placeHolderTop._gender}"));
            Console.WriteLine("||-----------||-----------||-----------||-----------||-----------||");
            Console.WriteLine(String.Format("|| {0,-10}|| {1,-10}|| {2,-10}|| {3,-10}|| {4,-10}||", $"{placeHolderTop2._brand}", $"{placeHolderTop2._price}", $"{placeHolderTop2._size}", $"{placeHolderTop2._color}", $"{placeHolderTop2._gender}"));
            Console.WriteLine("||-----------||-----------||-----------||-----------||-----------||\n");
            /*string _brand = Console.ReadLine();
            double _price = Convert.ToDouble(Console.ReadLine());
            string _size = Console.ReadLine();
            string _color = Console.ReadLine();
            string _gender = Console.ReadLine();*/
        }
    }
}








