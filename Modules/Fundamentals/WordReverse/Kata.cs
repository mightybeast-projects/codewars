using NUnit.Framework;

namespace WordReverse;

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

    private static IEnumerable<TestCaseData> cases
    {
        get
        {
            yield return new TestCaseData("This").Returns("sihT");
            yield return new TestCaseData("This is").Returns("sihT si");
            yield return new TestCaseData("This is an example!")
                .Returns("sihT si na !elpmaxe");
        }
    }
}