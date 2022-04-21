namespace accessories
{
    public class Accessories : Merchandise
    {
        public enum AccessoriesType
        {
            Jewlery,
            Stickers,
            Backpack,
            Wallet,
            Belt
        }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Material { get; }
        public AccessoriesType Type { get; }

        public Accessories(string Brand, double Price, string Material, int Quantity, AccessoriesType Type)
        {
            this.Brand = Brand;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Material = Material;
            this.Type = Type;
        }
    }

}



