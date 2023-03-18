using NUnit.Framework;

namespace Bus;

public static class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        int totalCount = 0;
        foreach (int[] stop in peopleListInOut)
        {
            totalCount += stop[0];
            totalCount -= stop[1];
        }
        return totalCount;
    }
}

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(new [] { 10, 0 }, ExpectedResult = 10)]
    [TestCase(new [] { 10, 0 }, new [] { 5, 5 }, ExpectedResult = 10)]
    [TestCase(new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 },
        ExpectedResult = 5)]
    [TestCase(new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 },
        ExpectedResult = 17)]
    [TestCase(new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 },
        ExpectedResult = 21)]
    public int TestPassengersCount(params int[][] stops)
    {
        List<int[]> stopsList = new List<int[]>();
        foreach (int[] stop in stops)
            stopsList.Add(stop);
        return Kata.Number(stopsList);
    }
}