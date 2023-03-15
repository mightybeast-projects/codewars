using NUnit.Framework;

namespace BowlingGame.FirstVariant;

[TestFixture]
public class BasicTests
{
    [Test]
    public void GameScoreEqualsZeroInNewGame()
    {
        BowlingGame game = new BowlingGame();

        Assert.AreEqual(0, game.score);
    }

    [Test]
    public void GameScoreEqualsToKnockedPinsAfterOneRoll()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(3);

        Assert.AreEqual(3, game.score);
    }

    [Test]
    public void GameScoreEqualsToSumOfKnockedPinsAfterSeveralRolls()
    {
        BowlingGame game = new BowlingGame();
        game.Roll(2);
        game.Roll(4);
        game.Roll(5);

        Assert.AreEqual(11, game.score);
    }

    [Test]
    public void DoNotCountPinsAfterTenthFrame()
    {
        BowlingGame game = new BowlingGame();

        for (int i = 0; i < 22; i++)
            game.Roll(1);

        Assert.AreEqual(20, game.score);
    }

    [Test]
    public void CountSpareRollAfterTenthFrame()
    {
        BowlingGame game = new BowlingGame();

        for (int i = 0; i < 9; i++)
        {
            game.Roll(1);
            game.Roll(1);
        }

        game.Roll(5);
        game.Roll(5);
        game.Roll(3);

        Assert.AreEqual(31, game.score);
    }

    [Test]
    public void CountStrikeRollAfterTenthFrame()
    {
        BowlingGame game = new BowlingGame();

        for (int i = 0; i < 9; i++)
        {
            game.Roll(1);
            game.Roll(1);
        }

        game.Roll(10);
        game.Roll(3);
        game.Roll(4);

        Assert.AreEqual(35, game.score);
    }

    [Test]
    public void ThreeStrikesAtTenthFrame()
    {
        BowlingGame game = new BowlingGame();

        for (int i = 0; i < 9; i++)
        {
            game.Roll(1);
            game.Roll(1);
        }

        game.Roll(10);
        game.Roll(10);
        game.Roll(10);

        Assert.AreEqual(48, game.score);
    }

    [Test]
    public void ThreeStrikesAtTenthFrameEndsGame()
    {
        BowlingGame game = new BowlingGame();

        for (int i = 0; i < 9; i++)
        {
            game.Roll(1);
            game.Roll(1);
        }

        game.Roll(10);
        game.Roll(10);
        game.Roll(10);

        game.Roll(1);

        Assert.AreEqual(48, game.score);
    }
}