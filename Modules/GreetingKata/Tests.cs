using NUnit.Framework;

namespace GreetingKata;

[TestFixture]
public class Tests
{
    private GreetingModule module;

    [Test]
    public void SimpleGreet()
    {
        module = new GreetingModule();

        Assert.AreEqual("Hello, Bob.", module.Greet("Bob"));
    }

    [Test]
    public void NullGreet()
    {
        module = new GreetingModule();

        Assert.AreEqual("Hello, my friend.", module.Greet(null));
    }

    [Test]
    public void ShoutGreet()
    {
        module = new GreetingModule();

        Assert.AreEqual("HELLO BOB!", module.Greet("BOB"));
    }

    [Test]
    public void TwoPeopleGreet()
    {
        module = new GreetingModule();

        Assert.AreEqual("Hello, Bob and Mike.", module.Greet("Bob", "Mike"));
    }

    [Test]
    public void ThreePeopleGreet()
    {
        module = new GreetingModule();

        Assert.AreEqual("Hello, Bob, Fred, and Mike.", module.Greet("Bob", "Fred", "Mike"));
    }

    [Test]
    public void MixedGreet()
    {
        module = new GreetingModule();

        Assert.AreEqual("Hello, Bob and Mike. AND HELLO FRED!",
                        module.Greet("Bob", "FRED", "Mike"));
    }

    [Test]
    public void NameContainsCommaGreet()
    {
        module = new GreetingModule();

        Assert.AreEqual("Hello, Bob, Fred, and Mike.",
                        module.Greet("Bob", "Fred, Mike"));
    }

    [Test]
    public void IntentionalCommasGreet()
    {
        module = new GreetingModule();

        Assert.AreEqual("Hello, Bob and Fred, Mike.",
                        module.Greet("Bob", "\"Fred, Mike\""));
    }
}