using NUnit.Framework;

namespace codewars.Modules.Fundamentals.ArrayStats;

[TestFixture]
public class Tests
{
    private ArrayStats arrayStats;

    [SetUp]
    public void SetUp() =>
        arrayStats = new ArrayStats(new int[5] { 2, -5, 40, 2, 1 });

    [Test]
    public void Initialization() => Assert.IsNotNull(arrayStats);

    [Test(ExpectedResult = -5)]
    public int GetMinElement() => arrayStats.GetMin();

    [Test(ExpectedResult = 40)]
    public int GetMaxElement() => arrayStats.GetMax();

    [Test(ExpectedResult = 5)]
    public int GetArraySize() => arrayStats.GetSize();

    [Test(ExpectedResult = 8)]
    public int GetAverage() => arrayStats.GetAverage();

    [Test(ExpectedResult = "even")]
    public string OddOrEven() => arrayStats.OddOrEvenSum();
}