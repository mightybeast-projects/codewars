using NUnit.Framework;

namespace LeapYear;

[TestFixture]
public class Tests
{
    private LeapYear leapYear;

    [SetUp]
    public void SetUp() => leapYear = new LeapYear();

    [Test]
    [TestCase(1996)]
    [TestCase(2000)]
    public void TestLeapYear(int year) =>
        Assert.IsTrue(leapYear.IsLeap(year));

    [Test]
    [TestCase(1900)]
    [TestCase(2001)]
    public void TestNonLeapYear(int year) =>
        Assert.IsFalse(leapYear.IsLeap(year));
}