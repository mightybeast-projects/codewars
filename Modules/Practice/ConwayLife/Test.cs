using NUnit.Framework;

namespace codewars.Modules.Practice.ConwayLife;

[TestFixture]
public class Test
{
    [Test, TestCaseSource(nameof(cases))]
    public int[,] TestConwayLife(int[,] cells, int generation)
        => Kata.GetGeneration(cells, generation);

    private static TestCaseData[] cases =
    {
        new TestCaseData(new int[,] { }, 1)
            .Returns(new int[,] { })
            .SetName("0x0, 1"),

        new TestCaseData(new int[,] {
                { 1, 1 },
                { 1, 1 } }, 0)
            .Returns(new int[,] {
                { 1, 1 },
                { 1, 1 }
            })
            .SetName("2x2, 0"),

        new TestCaseData(new int[,] {
                { 1, 1 },
                { 1, 1 } }, 1)
            .Returns(new int[,] {
                { 1, 1 },
                { 1, 1 }
            })
            .SetName("2x2, 1"),

        new TestCaseData(new int[,] {
            { 1, 1, 1 } }, 1)
            .Returns(new int[,] {
                { 1 },
                { 1 },
                { 1 }
            })
            .SetName("3x1, 1"),

        new TestCaseData(new int[,] {
                { 1 },
                { 1 },
                { 1 } }, 1)
            .Returns(new int[,] {
                { 1, 1, 1 }
            })
            .SetName("1x3, 1"),

        new TestCaseData(new int[,] { { 1, 1, 1 } }, 2)
            .Returns(new int[,] { { 1, 1, 1 } })
            .SetName("3x1, 2"),

        new TestCaseData(new int[,] {
                { 1, 0, 0 },
                { 0, 1, 1 },
                { 1, 1, 0 } }, 1)
            .Returns(new int[,] {
                { 0, 1, 0 },
                { 0, 0, 1 },
                { 1, 1, 1 }
            })
            .SetName("3x3, 1"),
            
        new TestCaseData(new int[,] {
                { 1, 0, 0 },
                { 0, 1, 1 },
                { 1, 1, 0 } }, 2)
            .Returns(new int[,] {
                { 1, 0, 1 },
                { 0, 1, 1 },
                { 0, 1, 0 }
            })
            .SetName("3x3, 2")
    };
}