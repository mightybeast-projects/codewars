using NUnit.Framework;

namespace codewars.Modules.Fundamentals.ExpandedForm;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public string TestExpandedForm(long n) => Kata.ExpandedForm(n);

    private static TestCaseData[] cases =
    {
        new TestCaseData(1).Returns("1"),
        new TestCaseData(12).Returns("10 + 2"),
        new TestCaseData(342).Returns("300 + 40 + 2"),
        new TestCaseData(5342).Returns("5000 + 300 + 40 + 2"),
        new TestCaseData(402).Returns("400 + 2"),
        new TestCaseData(70304).Returns("70000 + 300 + 4"),
        new TestCaseData(9000000).Returns("9000000")
    };
}