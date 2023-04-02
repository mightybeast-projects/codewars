using NUnit.Framework;

namespace codewars.Modules.Fundamentals.SupermaketQueue;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public int TestQueueTime(int[] arr, int n) => Kata.QueueTime(arr, n);

    private static TestCaseData[] cases =
    {
        new TestCaseData(new int[0], 1).Returns(0),
        new TestCaseData(new[] { 5, 3, 4 }, 1).Returns(12),
        new TestCaseData(new[] { 5, 3, 4 }, 2).Returns(7),
        new TestCaseData(new[] { 10, 2, 3, 3 }, 2).Returns(10),
        new TestCaseData(new[] { 2, 3, 10 }, 2).Returns(12),
        new TestCaseData(new[] { 1, 2, 3, 4, 5 }, 100).Returns(5)
    };
}