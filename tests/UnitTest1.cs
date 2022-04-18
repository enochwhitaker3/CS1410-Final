using NUnit.Framework;
using clothing;

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
        Assert.AreEqual(25.99, cottonTop.Price);
    }
    [Test]
    public void Test2()
    {
        Clothing cottonTop = new Clothing("Thrasher", 25.99, "XL", "Black", "Men's", 1, Clothing.ClothingType.Tops);
        Assert.AreEqual("Thrasher", cottonTop.Brand);
    }

    [Test]
    public void Test3()
    {
        Clothing cottonTop = new Clothing("Thrasher", 25.99, "XL", "Black", "Men's", 7, Clothing.ClothingType.Tops);
        Assert.AreEqual("XL", cottonTop.Size);
    }
    [Test]
    public void Test4()
    {
        Clothing cottonTop = new Clothing("Thrasher", 25.99, "XL", "Black", "Men's", 3, Clothing.ClothingType.Tops);
        Assert.AreEqual("Black", cottonTop.Color);
    }
    [Test]
    public void Test5()
    {
        Clothing cottonTop = new Clothing("Thrasher", 25.99, "XL", "Black", "Men's", 9, Clothing.ClothingType.Tops);
        Assert.AreEqual("Men's", cottonTop.Gender);
    }
}