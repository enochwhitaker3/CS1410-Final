namespace skateboarding
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
        public string Brand { get; set; }
        public string Size { get; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public SkateboardType Type { get; }

        public Skateboarding(string Brand, double Price, string Size, int Quantity, SkateboardType Type)
        {
            this.Brand = Brand;
            this.Size = Size;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Type = Type;
        }
    }

}


