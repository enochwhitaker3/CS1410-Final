namespace clothing
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

        public string Brand { get; set; }
        public double Price { get; set; }
        public string Size { get; }
        public string Color { get; }
        public string Gender { get; }
        public int Quantity { get; set; }
        public ClothingType Type { get; }

        public Clothing(string Brand, double Price, string Size, string Color, string Gender, int Quantity, ClothingType Type)
        {
            this.Brand = Brand;
            this.Price = Price;
            this.Size = Size;
            this.Color = Color;
            this.Gender = Gender;
            this.Quantity = Quantity;
            this.Type = Type;
        }


    }

}







