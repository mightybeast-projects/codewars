using NUnit.Framework;

namespace GreetingKata;

[TestFixture]
public class Tests
{
    private GreetingModule module;

    [SetUp]
    public void SetUp() => module = new GreetingModule();

    [Test]
    public void NullGreet() =>
        Assert.AreEqual("Hello, my friend.", module.Greet(null));

    [Test]
    [TestCase("Hello, Bob.", "Bob")]
    [TestCase("HELLO BOB!", "BOB")]
    [TestCase("Hello, Bob and Mike.", "Bob", "Mike")]
    [TestCase("Hello, Bob, Fred, and Mike.", "Bob", "Fred", "Mike")]
    [TestCase("Hello, Bob and Mike. AND HELLO FRED!", "Bob", "FRED", "Mike")]
    [TestCase("Hello, Bob, Fred, and Mike.", "Bob", "Fred, Mike")]
    [TestCase("Hello, Bob and Fred, Mike.", "Bob", "\"Fred, Mike\"")]
    public void TestGreetingModule(string result, params string[] names) =>
        Assert.AreEqual(result, module.Greet(names));
}