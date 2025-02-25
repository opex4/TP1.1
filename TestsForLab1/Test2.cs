using T1_1;

namespace T1_2.Tests;

[TestClass]
public sealed class Test2
{
    [TestMethod]
    public void Changes0plus()
    {
        var logic = new Logic([1, 2, 3]);
        Assert.AreEqual(0, logic.CountSignChanges());
    }
    [TestMethod]
    public void Changes0minus()
    {
        var logic = new Logic([-1, -2, -3, -4, -3, -3]);
        Assert.AreEqual(0, logic.CountSignChanges());
    }
    [TestMethod]
    public void Changes4()
    {
        var logic = new Logic([1, -2, 3, -4, 3, 3]);
        Assert.AreEqual(4, logic.CountSignChanges());
    }
    [TestMethod]
    public void ChangesNull()
    {
        var logic = new Logic([]);
        Assert.AreEqual(0, logic.CountSignChanges());
    }
}
