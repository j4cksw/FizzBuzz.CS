using NUnit.Framework;

[TestFixture]
public class FizzBuzzTest()
{
    FizzBuzz f;

    [SetUp]
    public void SetUp()
    {
        f = new FizzBuzz();
    }

    [Test]
    public void Test_1_Return_1()
    {
        Assert.AreEqual("1", f.Say(1));
    }

    [Test]
    public void Test_2_Return_2()
    {
        Assert.AreEqual("2", f.Say(2));
    }

    [Test]
    public void Test_15_Return_fizzbuzz()
    {
        Assert.AreEqual("fizzbuzz", f.Say(15));
    }
}
