using NUnit.Framework;

namespace ListComparator;

[TestFixture]
public class Tests
{
    private int[] _firstArray;
    private int[] _secondArray;
    private ListComparator _listComparator;

    [SetUp]
    public void Initialization()
    {
        _firstArray = new int[5];
        _secondArray = new int[5];
        _listComparator = new ListComparator();
    }

    [Test]
    public void CompareEmptyArrays()
    {
        Assert.AreEqual(25, CompareArrays());
    }

    [Test]
    public void CompareFilledArrays()
    {
        AddValuesToArrays();
        Assert.AreEqual(1, CompareArrays());
    }

    private void AddValuesToArrays()
    {
        _firstArray = new int[5] { 1, 2, 3, 4, 5 };
        _secondArray = new int[5] { 1, 21, 32, 43, 54 };
    }

    private int CompareArrays()
    {
        return _listComparator.Compare(_firstArray, _secondArray);
    }
}