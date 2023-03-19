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
    [Test, TestCaseSource(nameof(cases))]
    public string TestMumblingString(string s) => Kata.Mumble(s);

    private static TestCaseData[] cases =
    {
        new TestCaseData("a").Returns("A"),
        new TestCaseData("ab").Returns("A-Bb"),
        new TestCaseData("abc").Returns("A-Bb-Ccc"),
        new TestCaseData("abcD").Returns("A-Bb-Ccc-Dddd")
    };
}