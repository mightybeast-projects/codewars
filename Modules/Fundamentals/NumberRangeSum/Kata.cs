using NUnit.Framework;

namespace NumberRangeSum;

public class Kata
{
    public static int GetSum(int a, int b)
    {
        if (a == b) return a;

        int result = 0;

        for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            result += i;

        return result;
    }
}

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public int TestRangeSum(int a, int b) => Kata.GetSum(a, b);

    private static IEnumerable<TestCaseData> cases
    {
        get
        {
            yield return new TestCaseData(0, 0).Returns(0);
            yield return new TestCaseData(1, 1).Returns(1);
            yield return new TestCaseData(0, 1).Returns(1);
            yield return new TestCaseData(0, 2).Returns(3);
            yield return new TestCaseData(2, 0).Returns(3);
            yield return new TestCaseData(-1, 2).Returns(2);
        }
    }
}