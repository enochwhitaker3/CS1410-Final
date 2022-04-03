using System.Collections.Generic;
namespace clothing
{
    public class Program
    {
        public class Clothing : Merchandise
        {
            public string _brand; public double _price; public string _size; public string _color; public string _gender;
            public string Brand { get; set; }
            public double Price { get; set; }
            public Clothing(string Brand, double Price, string Size, string Color, string Gender)
            {
                this._brand = Brand;
                this._price = Price;
                this._size = Size;
                this._color = Color;
                this._gender = Gender;
            }
        }
        // method in Clothing.cs called "public string DisplayItems()"
    }
}





