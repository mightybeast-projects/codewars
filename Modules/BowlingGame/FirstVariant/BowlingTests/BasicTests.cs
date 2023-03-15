using NUnit.Framework;

namespace BowlingGame.FirstVariant;

[TestFixture]
public class BasicTests
{
    private BowlingGame game;

    [SetUp]
    public void SetUp() => game = new BowlingGame();

    [Test]
    public void GameScoreEqualsZeroInNewGame() =>
        Assert.AreEqual(0, game.score);

    [Test]
    public void GameScoreEqualsToKnockedPinsAfterOneRoll()
    {
        game.Roll(3);

        Assert.AreEqual(3, game.score);
    }

    [Test]
    public void GameScoreEqualsToSumOfKnockedPinsAfterSeveralRolls()
    {
        game.Roll(2);
        game.Roll(4);
        game.Roll(5);

        Assert.AreEqual(11, game.score);
    }

    [Test]
    public void DoNotCountPinsAfterTenthFrame()
    {
        for (int i = 0; i < 22; i++)
            game.Roll(1);

        Assert.AreEqual(20, game.score);
    }

    [Test]
    public void CountSpareRollAfterTenthFrame()
    {
        for (int i = 0; i < 18; i++)
            game.Roll(1);

        game.Roll(5);
        game.Roll(5);
        game.Roll(3);

        Assert.AreEqual(31, game.score);
    }

    [Test]
    public void CountStrikeRollAfterTenthFrame()
    {
        for (int i = 0; i < 18; i++)
            game.Roll(1);

        game.Roll(10);
        game.Roll(3);
        game.Roll(4);

        Assert.AreEqual(35, game.score);
    }

    [Test]
    public void ThreeStrikesAtTenthFrame()
    {
        for (int i = 0; i < 18; i++)
            game.Roll(1);

        for (int i = 0; i < 3; i++)
            game.Roll(10);

        Assert.AreEqual(48, game.score);
    }

    [Test]
    public void ThreeStrikesAtTenthFrameEndsGame()
    {
        for (int i = 0; i < 18; i++)
            game.Roll(1);

        for (int i = 0; i < 3; i++)
            game.Roll(10);

        game.Roll(1);

        Assert.AreEqual(48, game.score);
    }
}