using NUnit.Framework;

namespace codewars.Modules.Fundamentals.OddNumber;

public class Kata
{
    public static int FindOdd(int[] arr)
    {
        Dictionary<int, int> occurences = new Dictionary<int, int>();
        foreach (int element in arr)
        {
            if (occurences.ContainsKey(element))
                occurences[element]++;
            else
                occurences.Add(element, 1);
        }

        return occurences.Single(p => p.Value % 2 > 0).Key;
    }
}

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public int TestOddNumber(int[] arr) => Kata.FindOdd(arr);

    private static TestCaseData[] cases =
    {
        new TestCaseData(new[] { 0 }).Returns(0),
        new TestCaseData(new[] { 1 }).Returns(1),
        new TestCaseData(new[] { 2, 1, 2 }).Returns(1),
        new TestCaseData(new[] { 0, 1, 0, 1, 0 }).Returns(0)
    };
}