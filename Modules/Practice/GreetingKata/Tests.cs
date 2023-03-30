using NUnit.Framework;

namespace codewars.Modules.Practice.GreetingKata;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public void TestGreetingModule(string[] names, string result) =>
        Assert.AreEqual(result, new GreetingModule().Greet(names));

    private static object[] cases =
    {
        new object[] { null, "Hello, my friend." },
        new object[] { new[] { "Bob" }, "Hello, Bob." },
        new object[] { new[] { "BOB" }, "HELLO BOB!" },
        new object[] { new[] { "Bob", "Mike" }, "Hello, Bob and Mike." },
        new object[] { new[] { "Bob", "Fred", "Mike" },
            "Hello, Bob, Fred, and Mike." },
        new object[] { new[] { "Bob", "FRED", "Mike" },
            "Hello, Bob and Mike. AND HELLO FRED!" },
        new object[] { new[] { "Bob", "Fred, Mike" },
            "Hello, Bob, Fred, and Mike." },
        new object[] { new[] { "Bob", "\"Fred, Mike\"" },
            "Hello, Bob and Fred, Mike." },
    };
}