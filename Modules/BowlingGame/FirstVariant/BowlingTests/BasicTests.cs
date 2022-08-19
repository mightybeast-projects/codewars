using FirstVariant;
using NUnit.Framework;

namespace BowlingTests;

[TestFixture]
public class BasicTests
{
    [Test]
    public void GameScoreEqualsZeroInNewGame()
    {
        Game game = new Game();

        Assert.AreEqual(0, game.score);
    }

    [Test]
    public void GameScoreEqualsToKnockedPinsAfterOneRoll()
    {
        Game game = new Game();

        game.Roll(3);

        Assert.AreEqual(3, game.score);
    }

    [Test]
    public void GameScoreEqualsToSumOfKnockedPinsAfterSeveralRolls()
    {
        Game game = new Game();
        game.Roll(2);
        game.Roll(4);
        game.Roll(5);

        Assert.AreEqual(11, game.score);
    }

    [Test]
    public void DoNotCountPinsAfterTenthFrame()
    {
        Game game = new Game();

        for (int i = 0; i < 22; i++)
            game.Roll(1);

        Assert.AreEqual(20, game.score);
    }

    [Test]
    public void CountSpareRollAfterTenthFrame()
    {
        Game game = new Game();

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
        Game game = new Game();

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
        Game game = new Game();

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
        Game game = new Game();

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