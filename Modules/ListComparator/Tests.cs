using NUnit.Framework;

namespace ListComparator;

[TestFixture]
public class Tests
{
    private int[] firstArray;
    private int[] secondArray;
    private ListComparator listComparator;

    [SetUp]
    public void SetUp()
    {
        firstArray = new int[5];
        secondArray = new int[5];
        listComparator = new ListComparator();
    }

    [Test]
    public void CompareEmptyArrays() =>
        Assert.AreEqual(25, CompareArrays());

    [Test]
    public void CompareFilledArrays()
    {
        AddValuesToArrays();

        Assert.AreEqual(1, CompareArrays());
    }

    private void AddValuesToArrays()
    {
        firstArray = new int[5] { 1, 2, 3, 4, 5 };
        secondArray = new int[5] { 1, 21, 32, 43, 54 };
    }

    private int CompareArrays() =>
        listComparator.Compare(firstArray, secondArray);
}