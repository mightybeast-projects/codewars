using NUnit.Framework;

namespace codewars.Modules.Fundamentals.Pangram;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public bool TestPangram(string str) => Kata.IsPangram(str);

    private static TestCaseData[] cases =
    {
        new TestCaseData("The quick brown fox jumps over the lazy dog.")
            .Returns(true),
        new TestCaseData("The five boxing wizards jump quickly.")
            .Returns(true)
    };
}