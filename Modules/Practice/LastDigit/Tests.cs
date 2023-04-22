using NUnit.Framework;

namespace codewars.Modules.Practice.LastDigit;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public int TestLastDigitOfABigNumber(int a, int b)
        => Kata.LastDigit(a, b);

    private static TestCaseData[] cases =
    {
        new TestCaseData(0, 0).Returns(1),
        new TestCaseData(1, 2).Returns(1),
        new TestCaseData(2, 2).Returns(4),
        new TestCaseData(12, 12).Returns(6),
        new TestCaseData(99, 99).Returns(9),
        new TestCaseData(643, 152).Returns(1),
        new TestCaseData(645, 152).Returns(5),
        new TestCaseData(2022, 2023).Returns(8)
    };
}