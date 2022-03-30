namespace skateboarding
{
    class Program
    {
        public class Skateboarding : IMerchandise
        {
            public string _brand; public double _price; public string _size;
            public string Brand { get; set; }
            public double Price { get; set; }
            public Skateboarding(string Brand, double Price, string Size)
            {
                this._brand = Brand;
                this._price = Price;
                this._size = Size;
            }
        }
    }
}


