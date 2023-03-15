using NUnit.Framework;

namespace RankingSystem;

[TestFixture]
public class Tests
{
    private User user;

    [SetUp]
    public void SetUp() => user = new User();

    [Test]
    public void CreateUser()
    {
        Assert.AreEqual(-8, user.rank);
        Assert.AreEqual(0, user.progress);
    }

    [Test]
    public void OutOfRangeRank()
    {
        Assert.Throws<ArgumentException>(() => user.incProgress(-9));
        Assert.Throws<ArgumentException>(() => user.incProgress(0));
        Assert.Throws<ArgumentException>(() => user.incProgress(9));
    }

    [Test]
    public void SameRankProgressIncrease()
    {
        user.incProgress(-8);

        Assert.AreEqual(3, user.progress);
    }

    [Test]
    public void LowerRankProgressIncrease()
    {
        user.incProgress(2);
        user.incProgress(-1);

        Assert.AreEqual(11, user.progress);
    }

    [Test]
    public void TooLowRankProgressIncrease()
    {
        user.incProgress(2);
        user.incProgress(-2);

        Assert.AreEqual(10, user.progress);
    }

    [Test]
    public void HigherRankProgressIncrease()
    {
        user.incProgress(-5);

        Assert.AreEqual(90, user.progress);
    }

    [Test]
    public void HigherRankProgressIncreaseLevelUp()
    {
        user.incProgress(-4);

        Assert.AreEqual(60, user.progress);
        Assert.AreEqual(-7, user.rank);
    }

    [Test]
    public void ExampleTest()
    {
        Assert.AreEqual(-8, user.rank);
        Assert.AreEqual(0, user.progress);

        user.incProgress(-7);

        Assert.AreEqual(10, user.progress);

        user.incProgress(-5);

        Assert.AreEqual(0, user.progress);
        Assert.AreEqual(-7, user.rank);
    }

    [Test]
    public void DoubleLevelUp()
    {
        user.incProgress(-1);

        Assert.AreEqual(-4, user.rank);
        Assert.AreEqual(90, user.progress);
    }

    [Test]
    public void ZeroRankLevelUp()
    {
        user.incProgress(2);

        Assert.AreEqual(1, user.rank);
        Assert.AreEqual(10, user.progress);
    }

    [Test]
    public void Rank8Progression()
    {
        user.incProgress(8);
        user.incProgress(8);
        user.incProgress(8);

        Assert.AreEqual(8, user.rank);
        Assert.AreEqual(0, user.progress);
    }

    [Test]
    public void Rank1Activity()
    {
        user.incProgress(1);

        Assert.AreEqual(-2, user.rank);
        Assert.AreEqual(40, user.progress);
    }
}