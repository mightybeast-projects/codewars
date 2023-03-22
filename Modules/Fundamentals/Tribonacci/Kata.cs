using NUnit.Framework;

namespace codewars.Modules.Fundamentals.Tribonacci;

public class Kata
{
    public static double[] Tribonacci(double[] signature, int n)
    {
        double[] arr = new double[n];

        Array.Copy(signature, arr, Math.Min(3, n));

        for (int i = 3; i < arr.Length; i++)
            arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            
        return arr;
    }
}

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public double[] TestTribonacci(double[] signature, int n)
        => Kata.Tribonacci(signature, n);

    private static TestCaseData[] cases =
    {
        new TestCaseData(new double[] { 0, 0, 0 }, 0)
            .Returns(new double[] { }),
        new TestCaseData(new double[] { 0, 1, 1 }, 1)
            .Returns(new double[] { 0 }),
        new TestCaseData(new double[] { 1, 1, 1 }, 10)
            .Returns(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 })
    };
}