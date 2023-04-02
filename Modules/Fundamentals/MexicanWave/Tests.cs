using NUnit.Framework;

namespace codewars.Modules.Fundamentals.MexicanWave;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public List<string> TestWave(string str) => Kata.Wave(str);

    private static TestCaseData[] cases =
    {
        new TestCaseData("").Returns(new List<string>()),
        new TestCaseData(" ").Returns(new List<string>()),
        new TestCaseData("a").Returns(new List<string>() { "A" }),
        new TestCaseData(" gap ")
            .Returns(new List<string>() { " Gap ", " gAp ", " gaP " }),
        new TestCaseData("hello")
            .Returns(new List<string>() { "Hello", "hEllo", "heLlo", "helLo", "hellO" }),
        new TestCaseData("two words")
            .Returns(new List<string>() { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" }),
    };
}