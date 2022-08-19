using NUnit.Framework;

namespace RankingSystem;

[TestFixture]
public class Tests
{
    private User _user;

    [SetUp]
    public void SetUp()
    {
        _user = new User();
    }

    [Test]
    public void CreateUser()
    {
        Assert.AreEqual(-8, _user.rank);
        Assert.AreEqual(0, _user.progress);
    }

    [Test]
    public void OutOfRangeRank()
    {
        Assert.Throws<ArgumentException>(() => _user.incProgress(-9));
        Assert.Throws<ArgumentException>(() => _user.incProgress(0));
        Assert.Throws<ArgumentException>(() => _user.incProgress(9));
    }

    [Test]
    public void SameRankProgressIncrease()
    {
        _user.incProgress(-8);

        Assert.AreEqual(3, _user.progress);
    }

    [Test]
    public void LowerRankProgressIncrease()
    {
        _user.incProgress(2);
        _user.incProgress(-1);

        Assert.AreEqual(11, _user.progress);
    }

    [Test]
    public void TooLowRankprogressIncrease()
    {
        _user.incProgress(2);
        _user.incProgress(-2);

        Assert.AreEqual(10, _user.progress);
    }

    [Test]
    public void HigherRankProgressIncrease()
    {
        _user.incProgress(-5);

        Assert.AreEqual(90, _user.progress);
    }

    [Test]
    public void HigherRankProgressIncreaseLevelUp()
    {
        _user.incProgress(-4);

        Assert.AreEqual(60, _user.progress);
        Assert.AreEqual(-7, _user.rank);
    }

    [Test]
    public void ExampleTest()
    {
        Assert.AreEqual(-8, _user.rank);
        Assert.AreEqual(0, _user.progress);

        _user.incProgress(-7);

        Assert.AreEqual(10, _user.progress);

        _user.incProgress(-5);

        Assert.AreEqual(0, _user.progress);
        Assert.AreEqual(-7, _user.rank);
    }

    [Test]
    public void DoubleLevelUp()
    {
        _user.incProgress(-1);

        Assert.AreEqual(-4, _user.rank);
        Assert.AreEqual(90, _user.progress);
    }

    [Test]
    public void ZeroRankLevelUp()
    {
        _user.incProgress(2);

        Assert.AreEqual(1, _user.rank);
        Assert.AreEqual(10, _user.progress);
    }

    [Test]
    public void Rank8Progression()
    {
        _user.incProgress(8);
        _user.incProgress(8);
        _user.incProgress(8);

        Assert.AreEqual(8, _user.rank);
        Assert.AreEqual(0, _user.progress);
    }

    [Test]
    public void Rank1Activity()
    {
        _user.incProgress(1);

        Assert.AreEqual(-2, _user.rank);
        Assert.AreEqual(40, _user.progress);
    }
}