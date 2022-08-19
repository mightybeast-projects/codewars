using NUnit.Framework;

namespace FizzBuzz;

[TestFixture]
public class Tests
{
    private FizzBuzz _game;

    [SetUp]
    public void SetUp()
    {
        _game = new FizzBuzz();
    }

    [Test]
    public void InitializationTest()
    {
        Assert.AreEqual("1", _game.ElementAt(0));
    }

    [Test]
    public void DivisibleByThreeTest()
    {
        Assert.AreEqual("Fizz", _game.ElementAt(2));
    }

    [Test]
    public void DivisibleByFiveTest()
    {
        Assert.AreEqual("Buzz", _game.ElementAt(4));
    }

    [Test]
    public void DivisibleByThreeAndFiveTest()
    {
        Assert.AreEqual("FizzBuzz", _game.ElementAt(14));
    }
}