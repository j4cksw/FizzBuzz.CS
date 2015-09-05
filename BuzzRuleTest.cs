using NUnit.Framework;

[TestFixture]
public class BuzzRuleTest
{
    FizzBuzz f;

    [SetUp]
    public void SetUp()
    {
        f = new FizzBuzz();
    }

    [Test]
    public void Test_5_Return_buzz()
    {
        Assert.AreEqual("buzz", f.Say(5));
    }

    [Test]
    public void Test_10_Return_buzz()
    {
        Assert.AreEqual("buzz", f.Say(10));
    }
}
