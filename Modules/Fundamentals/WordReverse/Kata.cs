using NUnit.Framework;

namespace codewars.Modules.Fundamentals.WordReverse;

public static class Kata
{
    public static string ReverseWords(string str)
    {
        string[] words = str.Split(" ");
        for (int i = 0; i < words.Length; i++)
            words[i] = ReverseWord(words[i]);

        return string.Join(" ", words);
    }

    private static string ReverseWord(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);

        return new string(chars);
    }
}

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public string WordReverseTest(string input) =>
        Kata.ReverseWords(input);

    private static TestCaseData[] cases =
    {
        new TestCaseData("This").Returns("sihT"),
        new TestCaseData("This is").Returns("sihT si"),
        new TestCaseData("This is an example!")
            .Returns("sihT si na !elpmaxe")
    };
}