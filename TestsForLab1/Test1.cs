using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace T1_1.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void Rub1()
    {
        var logic = new Logic(100);
        Assert.AreEqual("рубль", logic.RubStr());
    }
    [TestMethod]
    public void Rub234()
    {
        var logic = new Logic(300);
        Assert.AreEqual("рубля", logic.RubStr());
    }
    [TestMethod]
    public void Rub()
    {
        var logic = new Logic(10000);
        Assert.AreEqual("рублей", logic.RubStr());
    }
    [TestMethod]
    public void Kop1()
    {
        var logic = new Logic(1);
        Assert.AreEqual("копейка", logic.KopStr());
    }
    [TestMethod]
    public void Kop234()
    {
        var logic = new Logic(3);
        Assert.AreEqual("копейки", logic.KopStr());
    }
    [TestMethod]
    public void Kop()
    {
        var logic = new Logic(10);
        Assert.AreEqual("копеек", logic.KopStr());
    }
    [TestMethod]
    public void RubKop100r5k()
    {
        var logic = new Logic(10005);
        Assert.AreEqual("100 рублей 5 копеек", logic.Output());
    }
    [TestMethod]
    public void RubKop0r1k()
    {
        var logic = new Logic(1);
        Assert.AreEqual("1 копейка", logic.Output());
    }
    [TestMethod]
    public void RubKop4r0k()
    {
        var logic = new Logic(400);
        Assert.AreEqual("4 рубля", logic.Output());
    }
}
