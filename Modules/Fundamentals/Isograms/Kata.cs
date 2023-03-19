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

    private static IEnumerable<TestCaseData> cases
    {
        get
        {
            yield return new TestCaseData("").Returns(true);
            yield return new TestCaseData("a").Returns(true);
            yield return new TestCaseData("aa").Returns(false);
            yield return new TestCaseData("Dermatoglyphics").Returns(true);
            yield return new TestCaseData("isIsogram").Returns(false);
            yield return new TestCaseData("moOse").Returns(false);
        }
    }
}