using NUnit.Framework;
using static clothing.Program;

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
        Clothing cottonTop = new Clothing("Thrasher", 25.99, "XL", "Black", "Men's");
        Assert.AreEqual(25.99, cottonTop._price);
    }
    [Test]
    public void Test2()
    {
        Clothing cottonTop = new Clothing("Thrasher", 25.99, "XL", "Black", "Men's");
        Assert.AreEqual("Thrasher", cottonTop._brand);
    }

    [Test]
    public void Test3()
    {
        Clothing cottonTop = new Clothing("Thrasher", 25.99, "XL", "Black", "Men's");
        Assert.AreEqual("XL", cottonTop._size);
    }
    [Test]
    public void Test4()
    {
        Clothing cottonTop = new Clothing("Thrasher", 25.99, "XL", "Black", "Men's");
        Assert.AreEqual("Black", cottonTop._color);
    }
    [Test]
    public void Test5()
    {
        Clothing cottonTop = new Clothing("Thrasher", 25.99, "XL", "Black", "Men's");
        Assert.AreEqual("Men's", cottonTop._gender);
    }
}