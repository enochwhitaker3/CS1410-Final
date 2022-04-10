namespace clothing
{
    public class Program
    {
        public class Clothing : Merchandise
        {
            public enum ClothingType
            {
                Hats,
                Tops,
                Bottoms,
                Socks,
                Shoes
            } 
            
            public string _brand; public double _price;  public string _size; public string _color; public string _gender; public int _quantity; public ClothingType _type;
            public string Brand { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public ClothingType Type {get; set;}

            public Clothing(string Brand, double Price, string Size, string Color, string Gender, int Quantity, ClothingType Type)
            {
                this._brand = Brand;
                this._price = Price;
                this._size = Size;
                this._color = Color;
                this._gender = Gender;
                this._quantity = Quantity;
                this._type = Type;

            }
            
            
        }
        
    }

}





