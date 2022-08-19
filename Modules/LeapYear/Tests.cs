using NUnit.Framework;

namespace LeapYear;

[TestFixture]
public class Tests
{
    LeapYear leapYear;

    [SetUp]
    public void SetUp()
    {
        leapYear = new LeapYear();
    }

    [Test]
    public void Year2001IsNotLeap()
    {
        Assert.IsFalse(YearIsLeap(2001));
    }

    [Test]
    public void Year1996IsLeap()
    {
        Assert.IsTrue(YearIsLeap(1996));
    }

    [Test]
    public void Year1900IsNotLeap()
    {
        Assert.IsFalse(YearIsLeap(1900));
    }

    [Test]
    public void Year2000IsLeap()
    {
        Assert.IsTrue(YearIsLeap(2000));
    }

    private bool YearIsLeap(int year)
    {
        return leapYear.IsLeap(year);
    }
}