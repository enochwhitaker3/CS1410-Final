using NUnit.Framework;
using clothing;
using skateboarding;
using accessories;

namespace tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Clothing cottonTop = new Clothing("Thrasher", 25.99, "XL", "Black", "Men's", 5, Clothing.ClothingType.Tops);
        Assert.AreEqual(45.99, cottonTop.Price);
    }
    [Test]
    public void Test2()
    {
        Skateboarding newBearing = new Skateboarding("Bones", 19.99, "Regulation", 1, Skateboarding.SkateboardType.Bearings);
        Assert.AreEqual("Reds", newBearing.Brand);
    }

    [Test]
    public void Test3()
    {
        Accessories newSticker = new Accessories("StickerCO", 4.99, "Plastic", 7, Accessories.AccessoriesType.Stickers);
        Assert.AreEqual(10, newSticker.Quantity);
    }
    [Test]
    public void Test4()
    {
        Clothing pants = new Clothing("Imper", 46.99, "XL", "Black", "Women's", 3, Clothing.ClothingType.Bottoms);
        Assert.AreEqual("Blue", pants.Color);
    }
    [Test]
    public void Test5()
    {
        Accessories newWallet = new Accessories("ACME", 30.99, "Faux-Leather", 2, Accessories.AccessoriesType.Wallet);
        Assert.AreEqual(Accessories.AccessoriesType.Backpack, newWallet.Type);
    }
}