using NUnit.Framework;

namespace codewars.Modules.Practice.BowlingGame.SecondVariant;

[TestFixture]
public class Tests
{
    private BowlingGame game;

    [SetUp]
    public void SetUp() => game = new BowlingGame();

    [Test(ExpectedResult = 0)]
    public int ScoreEqualsZeroOnFirstCreate() => game.Score();

    [Test]
    public void AfterOneRollScoreEqualsOne()
    {
        game.Roll(1);

        Assert.AreEqual(1, game.Score());
    }

    [Test]
    public void AfterTwoRollsScoreEqualsToSum()
    {
        game.Roll(1);
        game.Roll(2);

        Assert.AreEqual(3, game.Score());
    }

    [Test]
    public void StopGameAfter21Roll()
    {
        for (int i = 0; i < 22; i++)
            game.Roll(1);

        Assert.AreEqual(20, game.Score());
    }

    [Test]
    public void TestSpareFrame()
    {
        game.Roll(5);
        game.Roll(5);

        game.Roll(3);

        Assert.AreEqual(16, game.Score());
    }

    [Test]
    public void TestStrikeFrame()
    {
        game.Roll(10);

        game.Roll(2);
        game.Roll(2);

        Assert.AreEqual(18, game.Score());
    }

    [Test]
    public void GutterGame()
    {
        for (int i = 0; i < 20; i++)
            game.Roll(0);

        Assert.AreEqual(0, game.Score());
    }

    [Test]
    public void PerfectGame()
    {
        for (int i = 0; i < 12; i++)
            game.Roll(10);

        Assert.AreEqual(300, game.Score());
    }
}