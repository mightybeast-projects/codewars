using NUnit.Framework;

namespace codewars.Modules.Fundamentals.TenMinuteWalk;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public void TestValidWalk(string[] arr, bool result)
        => Assert.AreEqual(result, Kata.IsValidWalk(arr));

    private static object[] cases =
    {
        new object[] { new[] { "n" }, false },
        new object[] { new[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s", }, true },
        new object[] { new[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s", "w" }, false },
        new object[] { new[] { "n", "s", "n", "s", "n", "s", "n", "s", "n" }, false },
    };
}