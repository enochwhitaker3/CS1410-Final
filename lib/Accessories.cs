namespace accessories
{
    public class Program
    {
        public class Accessories : Merchandise
        {
            public string _brand; public double _price; public string _material; public string _gender;
            public string Brand { get; set; }
            public double Price { get; set; }
            public Accessories(string Brand, double Price, string Material, string Gender)
            {
                this._brand = Brand;
                this._price = Price;
                this._material = Material;
                this._gender = Gender;
            }
        }
    }
}



