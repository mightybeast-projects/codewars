using NUnit.Framework;

namespace codewars.Modules.Fundamentals.EnoughIsEnough;

public class Kata
{
    public static int[] EnoughIsEnough(int[] arr, int n)
    {
        List<int> result = new List<int>();

        foreach (int e in arr)
            if (result.Count(a => a == e) < n)
                result.Add(e);

        return result.ToArray();
    }
}

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public int[] TestEnoughIsEnough(int[] arr, int n)
        => Kata.EnoughIsEnough(arr, n);

    private static TestCaseData[] cases =
    {
        new TestCaseData(new[] { 0 }, 1).Returns(new[] { 0 }),
        new TestCaseData(new[] { 0, 1 }, 1).Returns(new[] { 0, 1 }),
        new TestCaseData(new[] { 0, 1, 1 }, 1).Returns(new[] { 0, 1 }),
        new TestCaseData(new[] {20, 37, 20, 21}, 1)
            .Returns(new int[] {20, 37, 21}),
        new TestCaseData(new[] { 1, 2, 3, 1, 2, 1, 2, 3 }, 2)
            .Returns(new[] { 1, 2, 3, 1, 2, 3 }),
    };
}