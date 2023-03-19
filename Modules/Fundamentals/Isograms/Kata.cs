using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Isograms;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        foreach (char ch in str)
            if (Regex.Matches(str.ToLower(), ch.ToString()).Count > 1)
                return false;

        return true;
    }
}

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public bool TestIsogram(string s) => Kata.IsIsogram(s);

    private static TestCaseData[] cases =
    {
        new TestCaseData("").Returns(true),
        new TestCaseData("a").Returns(true),
        new TestCaseData("aa").Returns(false),
        new TestCaseData("Dermatoglyphics").Returns(true),
        new TestCaseData("isIsogram").Returns(false),
        new TestCaseData("moOse").Returns(false)
    };
}