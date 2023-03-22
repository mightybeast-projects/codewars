using NUnit.Framework;

namespace codewars.Modules.Fundamentals.ArrayDiff;

public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b) => 
        a.Where(x => !b.Contains(x)).ToArray();
}

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public int[] TestArrayDiff(int[] a, int[] b) => Kata.ArrayDiff(a, b);

    private static TestCaseData[] cases =
    {
        new TestCaseData(new int[] { }, new int[] { })
            .Returns(new int[] { }),
        new TestCaseData(new int[] { }, new int[] { 1, 2 })
            .Returns(new int[] { }),
        new TestCaseData(new int[] { 1, 2 }, new int[] {  })
            .Returns(new int[] { 1, 2 }),
        new TestCaseData(new int[] { 1, 2 }, new int[] { 1 })
            .Returns(new int[] { 2 }),
        new TestCaseData(new int[] { 1, 2, 2, 2, 3 }, new int[] { 2 })
            .Returns(new int[] { 1, 3 }),
        new TestCaseData(new int[] { 1, 2, 2 }, new int[] { 1 })
            .Returns(new int[] { 2, 2 })
    };
}