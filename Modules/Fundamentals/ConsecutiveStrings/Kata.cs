using NUnit.Framework;

namespace ConsecutiveStrings;

public class Kata
{
    public static string GetConsecutiveStrings(string[] strarr, int k)
    {
        string result = "";

        if (strarr.Length == 0 || k > strarr.Length || k <= 0)
            return result;

        for (int i = 0; i < strarr.Length; i++)
        {
            string str = strarr[i];
            
            if (i < strarr.Length - (k - 1))
                for (int j = 1; j < k; j++)
                    str += strarr[i + j];

            if (result.Length < str.Length)
                result = str;
        }
        
        return result;
    }
}

[TestFixture]
public class Tests
{
    [TestCase(new string[] { }, 2, ExpectedResult = "")]
    [TestCase(new[] { "aaa" }, 2, ExpectedResult = "")]
    [TestCase(new[] { "aaa" }, 0, ExpectedResult = "")]
    [TestCase(new[] { "aaa" }, -1, ExpectedResult = "")]
    [TestCase(new[] { "aaa" }, 1, ExpectedResult = "aaa")]
    [TestCase(new[] { "aaa", "bb", "c" }, 1, ExpectedResult = "aaa")]
    [TestCase(new[] { "aaa", "bb"}, 2, ExpectedResult = "aaabb")]
    [TestCase(new[] { "aaa", "bb", "c" }, 2, ExpectedResult = "aaabb")]
    [TestCase(new[] { "aaa", "bb", "c" }, 3, ExpectedResult = "aaabbc")]
    [TestCase(new[] { "aaa", "bb", "c", "dddd" }, 3, ExpectedResult = "bbcdddd")]
    [TestCase(new[] {"zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"}, 2,
        ExpectedResult = "abigailtheta")]
    public string TestConsecutiveStrings(string[] strs, int k)
        => Kata.GetConsecutiveStrings(strs, k);
}