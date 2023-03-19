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
    [TestCase(0, 0, ExpectedResult = 0)]
    [TestCase(1, 1, ExpectedResult = 1)]
    [TestCase(0, 1, ExpectedResult = 1)]
    [TestCase(0, 2, ExpectedResult = 3)]
    [TestCase(2, 0, ExpectedResult = 3)]
    [TestCase(-1, 2, ExpectedResult = 2)]
    public int TestRangeSum(int a, int b) => Kata.GetSum(a, b);
}