using NUnit.Framework;

namespace BowlingGame.SecondVariant;

[TestFixture]
public class Tests
{
    private BowlingGame game;
    [Test]
    public void ScoreEqualsZeroOnFirstCreate()
    {
        game = new BowlingGame();

        Assert.AreEqual(0, game.Score());
    }

    [Test]
    public void AfterOneRollScoreEqualsOne()
    {
        game = new BowlingGame();

        game.Roll(1);

        Assert.AreEqual(1, game.Score());
    }

    [Test]
    public void AfterTwoRollsScoreEqualsToSum()
    {
        game = new BowlingGame();

        game.Roll(1);
        game.Roll(2);

        Assert.AreEqual(3, game.Score());
    }

    [Test]
    public void StopGameAfter21Roll()
    {
        game = new BowlingGame();

        for (int i = 0; i < 22; i++)
        {
            game.Roll(1);
        }

        Assert.AreEqual(20, game.Score());
    }

    [Test]
    public void TestSpareFrame()
    {
        game = new BowlingGame();

        game.Roll(5);
        game.Roll(5);

        game.Roll(3);

        Assert.AreEqual(16, game.Score());
    }

    [Test]
    public void TestStrikeFrame()
    {
        game = new BowlingGame();

        game.Roll(10);

        game.Roll(2);
        game.Roll(2);

        Assert.AreEqual(18, game.Score());
    }

    [Test]
    public void GutterGame()
    {
        game = new BowlingGame();

        for (int i = 0; i < 20; i++)
            game.Roll(0);

        Assert.AreEqual(0, game.Score());
    }

    [Test]
    public void PerfectGame()
    {
        game = new BowlingGame();

        for (int i = 0; i < 12; i++)
            game.Roll(10);

        Assert.AreEqual(300, game.Score());
    }
}