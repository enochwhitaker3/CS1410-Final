namespace skateboarding
{
    public class Program
    {
        public class Skateboarding : Merchandise
        {
            public enum SkateboardType
            {
                GripTape,
                Decks,
                Trucks,
                Bearings,
                Wheels
            }

            public string _brand; public double _price; public string _size; public int _quantity; public SkateboardType _type;
            public string Brand { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public Skateboarding(string Brand, double Price, string Size, int Quantity, SkateboardType Type)
            {
                this._brand = Brand;
                this._price = Price;
                this._size = Size;
                this._quantity = Quantity;
                this._type = Type;
            }
        }
    }
}


