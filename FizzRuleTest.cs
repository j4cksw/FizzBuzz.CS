using NUnit.Framework;

[TestFixture]
public class FizzRuleTest
{
    FizzBuzz f;

    [SetUp]
    public void SetUp()
    {
        f = new FizzBuzz();
    }

    [Test]
    public void Test_3_Return_fizz()
    {
        Assert.AreEqual("fizz", f.Say(3));
    }

    [Test]
    public void Test_6_Return_fizz()
    {
        Assert.AreEqual("fizz", f.Say(6));
    }

    [Test]
    public void Test_9_Return_fizz()
    {
        Assert.AreEqual("fizz", f.Say(9));
    }

}
