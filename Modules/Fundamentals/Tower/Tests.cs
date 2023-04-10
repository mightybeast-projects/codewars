using NUnit.Framework;

namespace codewars.Modules.Fundamentals.Tower;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public string TestTower(int n)
        => string.Join(",", Kata.TowerBuilder(n));

    private static TestCaseData[] cases =
    {
        new TestCaseData(1).Returns("*"),
        new TestCaseData(2)
            .Returns(string.Join(",", new[] { " * ", "***" })),
        new TestCaseData(3)
            .Returns(string.Join(",", new[] { "  *  ", " *** ", "*****" }))
    };
}