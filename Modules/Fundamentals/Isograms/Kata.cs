using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Isograms;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        foreach (char ch in str)
            if (Regex.Matches(str, ch.ToString(), RegexOptions.IgnoreCase).Count > 1)
                return false;

        return true;
    }
}

[TestFixture]
public class Tests
{
    [Test]
    [TestCase("", ExpectedResult = true)]
    [TestCase("a", ExpectedResult = true)]
    [TestCase("aa", ExpectedResult = false)]
    [TestCase("Dermatoglyphics", ExpectedResult = true)]
    [TestCase("isIsogram", ExpectedResult = false)]
    [TestCase("moOse", ExpectedResult = false)]
    public bool TestIsogram(string s) => Kata.IsIsogram(s);
}