using NUnit.Framework;

namespace codewars.Modules.Fundamentals.CountingDuplicates;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public int TestDuplicates(string str) => Kata.DuplicateCount(str);

    private static TestCaseData[] cases =
    {
        new TestCaseData("").Returns(0),
        new TestCaseData("abcde").Returns(0),
        new TestCaseData("aabbcde").Returns(2),
        new TestCaseData("aabBcde").Returns(2),
        new TestCaseData("indivisibility").Returns(1),
        new TestCaseData("Indivisibilities").Returns(2),
        new TestCaseData("aA11").Returns(2),
        new TestCaseData("ABBA").Returns(2)
    };
}