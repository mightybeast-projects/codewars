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
        new TestCaseData(new int[,] { }, 1).Returns(new int[,] { }),
        new TestCaseData(new int[,] {
                { 1, 1 },
                { 1, 1 } }, 1)
            .Returns(new int[,] {
                { 1, 1 },
                { 1, 1 }
            })/*,
        new TestCaseData(new int[,] {
            { 1, 1, 1 } }, 1)
            .Returns(new int[,] {
                { 1 },
                { 1 },
                { 1 }
            }),*/
    };
}