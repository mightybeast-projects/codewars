using NUnit.Framework;

namespace AverageScore;

public class Kata
{
    public static bool BetterThanAverage(int[] classPoints, int yourPoints)
    {
        int totalClasspoints = classPoints.Sum() + yourPoints;
        int average = totalClasspoints / (classPoints.Length + 1);
        return yourPoints > average;
    }
}

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public bool TestAverageScore(int[] classPoints, int yourPoints) =>
        Kata.BetterThanAverage(classPoints, yourPoints);

    private static TestCaseData[] cases =
    {
        new TestCaseData(new int[] { 2, 3 }, 5)
            .Returns(true),
        new TestCaseData(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75)
            .Returns(true),
        new TestCaseData(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69)
            .Returns(true),
    };
}