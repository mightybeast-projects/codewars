using NUnit.Framework;

namespace Mumbling;

public class Kata
{
    public static string Mumble(string s)
    {
        string result = "";
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < i + 1; j++)
                result += j > 0 ? Char.ToLower(s[i]) : Char.ToUpper(s[i]);
            result += "-";
        }

        return result.TrimEnd('-');
    }
}

[TestFixture]
public class Tests
{
    [Test]
    [TestCase("a", ExpectedResult = "A")]
    [TestCase("ab", ExpectedResult = "A-Bb")]
    [TestCase("abc", ExpectedResult = "A-Bb-Ccc")]
    [TestCase("abcD", ExpectedResult = "A-Bb-Ccc-Dddd")]
    public string TestMumblingString(string s) => Kata.Mumble(s);
}