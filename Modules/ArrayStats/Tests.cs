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

    [Test]
    public void GetMinElement() =>
        Assert.AreEqual(-5, arrayStats.GetMin());

    [Test]
    public void GetMaxElement() =>
        Assert.AreEqual(40, arrayStats.GetMax());

    [Test]
    public void GetArraySize() =>
        Assert.AreEqual(5, arrayStats.GetSize());

    [Test]
    public void GetAverage() =>
        Assert.AreEqual(8, arrayStats.GetAverage());

    [Test]
    public void OddOrEven() =>
        Assert.AreEqual("even", arrayStats.OddOrEvenSum());
}