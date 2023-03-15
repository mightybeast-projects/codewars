using NUnit.Framework;

namespace ArrayStats;

[TestFixture]
public class Tests
{
    private ArrayStats _arrayStats;

    [Test]
    public void Initialization()
    {
        SimpleInitialization();

        Assert.IsNotNull(_arrayStats.array);
    }

    [Test]
    public void GetMinElement()
    {
        SimpleInitialization();

        Assert.AreEqual(-5, _arrayStats.GetMin());
    }

    [Test]
    public void GetMaxElement()
    {
        SimpleInitialization();

        Assert.AreEqual(40, _arrayStats.GetMax());
    }

    [Test]
    public void GetArraySize()
    {
        SimpleInitialization();

        Assert.AreEqual(5, _arrayStats.GetSize());
    }

    [Test]
    public void GetAverage()
    {
        SimpleInitialization();

        Assert.AreEqual(8, _arrayStats.GetAverage());
    }

    [Test]
    public void OddOrEven()
    {
        SimpleInitialization();

        Assert.AreEqual("even", _arrayStats.OddOrEvenSum());
    }

    private void SimpleInitialization()
    {
        int[] array = new int[5] { 2, -5, 40, 2, 1 };
        _arrayStats = new ArrayStats(array);
    }
}