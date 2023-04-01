using NUnit.Framework;

namespace codewars.Modules.Fundamentals.TenMinuteWalk;

public class Kata
{
    public static bool IsValidWalk(string[] arr)
    {
        return arr.Length == 10 &&
            arr.Count(x => x == "n") == arr.Count(x => x == "s") && 
            arr.Count(x => x == "w") == arr.Count(x => x == "e");
    }
}

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