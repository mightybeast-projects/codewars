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
    [TestCase(1996, ExpectedResult = true)]
    [TestCase(2000, ExpectedResult = true)]
    [TestCase(1900, ExpectedResult = false)]
    [TestCase(2001, ExpectedResult = false)]
    public bool TestLeapYear(int year) => LeapYear.IsLeap(year);
}