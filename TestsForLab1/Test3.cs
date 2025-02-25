namespace _1_3;

[TestClass]
public sealed class Test3
{
    [TestMethod]
    public void LetterPercentage0()
    {
        var logic = new Logic("");
        Assert.AreEqual(0, logic.LetterPercentage());
    }
    [TestMethod]
    public void LetterPercentage50()
    {
        var logic = new Logic("1j");
        Assert.AreEqual(50, logic.LetterPercentage());
    }
    [TestMethod]
    public void LetterPercentage25()
    {
        var logic = new Logic("1j11");
        Assert.AreEqual(25, logic.LetterPercentage());
    }
    [TestMethod]
    public void LetterPercentage75()
    {
        var logic = new Logic("lek1");
        Assert.AreEqual(75, logic.LetterPercentage());
    }
    [TestMethod]
    public void LetterPercentage100()
    {
        var logic = new Logic("jwenfcrlwjkn");
        Assert.AreEqual(100, logic.LetterPercentage());
    }
    [TestMethod]
    public void LetterPercentage00()
    {
        var logic = new Logic("1872634");
        Assert.AreEqual(0, logic.LetterPercentage());
    }
}

