using NUnit.Framework;

namespace LeapYear;

public static class LeapYear
{
    public static bool IsLeap(int year)
    {
        if (year % 400 == 0) return true;
        if (year % 100 == 0) return false;
        if (year % 4 == 0) return true;
        return false;
    }
}

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public bool TestLeapYear(int year) => LeapYear.IsLeap(year);

    private static TestCaseData[] cases =
    {
        new TestCaseData(1996).Returns(true),
        new TestCaseData(2000).Returns(true),
        new TestCaseData(1900).Returns(false),
        new TestCaseData(2001).Returns(false)
    };
}