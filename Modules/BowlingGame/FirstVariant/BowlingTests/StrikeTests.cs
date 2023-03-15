using NUnit.Framework;

namespace BowlingGame.FirstVariant;

[TestFixture]
public class StrikeTests
{
    [Test]
    public void CheckForStrikeFrame()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(10);

        Assert.AreEqual(true, game.hadStrikeLastFrame);
    }

    [Test]
    public void CheckForStrikeCounterAfterDoubleStrike()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(10);
        game.Roll(10);

        Assert.AreEqual(true, game.hadStrikeLastFrame);
    }

    [Test]
    public void CheckForNotStrikeFrameAfterNonStrikeFrame()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(10);

        game.Roll(3);
        game.Roll(7);

        Assert.AreEqual(false, game.hadStrikeLastFrame);
    }

    [Test]
    public void AddStrikeFrameBonus()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(10);

        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(14, game.score);
    }

    [Test]
    public void StrikeStrikeNonSpareCheck()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(10);
        game.Roll(10);

        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(35, game.score);
    }
}