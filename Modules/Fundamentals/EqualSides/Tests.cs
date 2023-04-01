using NUnit.Framework;

namespace codewars.Modules.Fundamentals.EqualSides;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public int TestEqualSides(int[] arr) => Kata.GetEvenIndex(arr);

    private static TestCaseData[] cases =
    {
        new TestCaseData(new[] { 1 }).Returns(0),
        new TestCaseData(new[] { 0, 1 }).Returns(1),
        new TestCaseData(new[] { 1, 1 }).Returns(-1),
        new TestCaseData(new[] { 1, 2, 3, 4, 3, 2, 1}).Returns(3),
        new TestCaseData(new[] { 20, 10, -80, 10, 10, 15, 35}).Returns(0)
    };
}