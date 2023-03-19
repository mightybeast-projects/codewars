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
    [Test, TestCaseSource(nameof(cases))]
    public string TestConsecutiveStrings(string[] strs, int k)
        => Kata.GetConsecutiveStrings(strs, k);

    private static IEnumerable<TestCaseData> cases
    {
        get
        {
            yield return new TestCaseData(new string[] { }, 2).Returns("");
            yield return new TestCaseData(new[] { "aaa" }, 2).Returns("");
            yield return new TestCaseData(new[] { "aaa" }, 0).Returns("");
            yield return new TestCaseData(new[] { "aaa" }, -1).Returns("");
            yield return new TestCaseData(new[] { "aaa" }, 1)
                .Returns("aaa");
            yield return new TestCaseData(new[] { "aaa", "bb", "c" }, 1)
                .Returns("aaa");
            yield return new TestCaseData(new[] { "aaa", "bb" }, 2)
                .Returns("aaabb");
            yield return new TestCaseData(new[] { "aaa", "bb", "c" }, 2)
                .Returns("aaabb");
            yield return new TestCaseData(new[] { "aaa", "bb", "c" }, 3)
                .Returns("aaabbc");
            yield return new TestCaseData(
                new[] { "aaa", "bb", "c", "dddd" }, 3).Returns("bbcdddd");
            yield return new TestCaseData(
                new[] {"zone", "abigail", "theta",
                "form", "libe", "zas", "theta", "abigail"}, 2)
                .Returns("abigailtheta");
        }
    }
}