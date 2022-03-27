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
            Console.WriteLine("|| 1: Check Hats Stock          ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 2: Check Tops Stock          ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 3: Check Bottoms Stock       ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 4: Check Socks Stock         ||");
            Console.WriteLine("||------------------------------||");
            Console.WriteLine("|| 5: Check Shoes Stock         ||");
            Console.WriteLine("||------------------------------||\n");
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
        static void TopsStock()
        {
            Clothing placeHolderTop = new Clothing("Uniqlo", 17.99, "X-Large", "White", "Mens");
            Clothing placeHolderTop2 = new Clothing("Empyre", 19.99, "Small", "Yellow", "Women's");
            Console.Clear();
            Console.WriteLine("                        -[Tops Stock]-              ");
            Console.WriteLine("||===============================================================||");
            Console.WriteLine("|| Brand     || Price     || Size      || Color     || Gender    ||");
            Console.WriteLine("||===============================================================||");
            Console.WriteLine(String.Format("|| {0,-10}|| {1,-10}|| {2,-10}|| {3,-10}|| {4,-10}||", $"{placeHolderTop._brand}", $"{placeHolderTop._price}", $"{placeHolderTop._size}", $"{placeHolderTop._color}", $"{placeHolderTop._gender}"));
            Console.WriteLine("||-----------||-----------||-----------||-----------||-----------||");
            Console.WriteLine(String.Format("|| {0,-10}|| {1,-10}|| {2,-10}|| {3,-10}|| {4,-10}||", $"{placeHolderTop2._brand}", $"{placeHolderTop2._price}", $"{placeHolderTop2._size}", $"{placeHolderTop2._color}", $"{placeHolderTop2._gender}"));
            Console.WriteLine("||-----------||-----------||-----------||-----------||-----------||\n");
            Console.WriteLine("(1) Would You Like To Add To Pre-exsisting Stock, (2) Or Add A New Item?");
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








