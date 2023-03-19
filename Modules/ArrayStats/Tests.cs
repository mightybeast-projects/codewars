using NUnit.Framework;

namespace ArrayStats;

[TestFixture]
public class Tests
{
    private ArrayStats arrayStats;

    [SetUp]
    public void SetUp() =>
        arrayStats = new ArrayStats(new int[5] { 2, -5, 40, 2, 1 });

    [Test]
    public void Initialization() => Assert.IsNotNull(arrayStats);

    [TestCase(ExpectedResult = -5)]
    public int GetMinElement() => arrayStats.GetMin();

    [TestCase(ExpectedResult = 40)]
    public int GetMaxElement() => arrayStats.GetMax();

    [TestCase(ExpectedResult = 5)]
    public int GetArraySize() => arrayStats.GetSize();

    [TestCase(ExpectedResult = 8)]
    public int GetAverage() => arrayStats.GetAverage();

    [TestCase(ExpectedResult = "even")]
    public string OddOrEven() => arrayStats.OddOrEvenSum();
}