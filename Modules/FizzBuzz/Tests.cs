using NUnit.Framework;

namespace FizzBuzz;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase("1", 0)]
    [TestCase("Fizz", 2)]
    [TestCase("Buzz", 4)]
    [TestCase("FizzBuzz", 14)]
    public void ElementAtPositionEqualsTo(string element, int index)
    {
        FizzBuzz game = new FizzBuzz();

        Assert.AreEqual(element, game.ElementAt(index));
    }
}