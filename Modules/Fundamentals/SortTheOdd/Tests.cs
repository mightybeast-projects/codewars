using NUnit.Framework;

namespace codewars.Modules.Fundamentals.SortTheOdd;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public int[] TestOddSorting(int[] arr) => Kata.SortArray(arr);

    private static TestCaseData[] cases =
    {
        new TestCaseData(new int[0]).Returns(new int[0]),
        new TestCaseData(new[] { 7, 1 }).Returns(new[] { 1, 7 }),
        new TestCaseData(new[] { 5, 3, 2, 8, 1, 4 })
            .Returns(new[] { 1, 3, 2, 8, 5, 4 }),
        new TestCaseData(new[] { 5, 3, 1, 8, 0 })
            .Returns(new[] { 1, 3, 5, 8, 0 }),
    };
}