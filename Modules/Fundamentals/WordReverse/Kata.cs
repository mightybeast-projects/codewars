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
    [TestCase("This", ExpectedResult = "sihT")]
    [TestCase("This  is", ExpectedResult = "sihT  si")]
    [TestCase("This is an example!", ExpectedResult = "sihT si na !elpmaxe")]
    public string WordReverseTest(string input) =>
        Kata.ReverseWords(input);
}