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
    [TestCase("This", "sihT")]
    [TestCase("This  is", "sihT  si")]
    [TestCase("This is an example!", "sihT si na !elpmaxe")]
    public void WordReverseTest(string input, string result) =>
        Assert.AreEqual(result, Kata.ReverseWords(input));
}