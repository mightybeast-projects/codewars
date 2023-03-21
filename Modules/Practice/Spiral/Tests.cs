using NUnit.Framework;

namespace codewars.Modules.Practice.Spiral;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public int[,] TestSpiral(int size) => Kata.Spiralize(size);

    private static TestCaseData[] cases =
    {
        new TestCaseData(5).Returns(new int[,] {
            { 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 1 },
            { 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1 },
        }),
        new TestCaseData(6).Returns(new int[,] {
            { 1, 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1 },
        }),
        new TestCaseData(7).Returns(new int[,] {
            { 1, 1, 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 1, 0, 1 },
            { 1, 0, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
        }),
        new TestCaseData(8).Returns(new int[,] {
            { 1, 1, 1, 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 1, 0, 1 },
            { 1, 0, 1, 0, 0, 1, 0, 1 },
            { 1, 0, 1, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1 },
        }),
    };
}