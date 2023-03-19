using NUnit.Framework;

namespace GreetingKata;

[TestFixture]
public class Tests
{
    [Test(ExpectedResult = "Hello, my friend.")]
    public string TestNullGreet() => new GreetingModule().Greet(null);

    [TestCase("Bob", ExpectedResult = "Hello, Bob.")]
    [TestCase("BOB", ExpectedResult = "HELLO BOB!")]
    [TestCase("Bob", "Mike", ExpectedResult = "Hello, Bob and Mike.")]
    [TestCase("Bob", "Fred", "Mike", ExpectedResult = "Hello, Bob, Fred, and Mike.")]
    [TestCase("Bob", "FRED", "Mike", ExpectedResult = "Hello, Bob and Mike. AND HELLO FRED!")]
    [TestCase("Bob", "Fred, Mike", ExpectedResult = "Hello, Bob, Fred, and Mike.")]
    [TestCase("Bob", "\"Fred, Mike\"", ExpectedResult = "Hello, Bob and Fred, Mike.")]
    public string TestGreetingModule(params string[] names) =>
        new GreetingModule().Greet(names);
}