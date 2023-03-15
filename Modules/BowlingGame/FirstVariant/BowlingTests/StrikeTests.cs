using NUnit.Framework;

namespace BowlingGame.FirstVariant;

[TestFixture]
public class StrikeTests
{
    private BowlingGame game;

    [SetUp]
    public void SetUp() => game = new BowlingGame();

    [Test]
    public void CheckForStrikeFrame()
    {
        game.Roll(10);

        Assert.AreEqual(true, game.hadStrikeLastFrame);
    }

    [Test]
    public void CheckForStrikeCounterAfterDoubleStrike()
    {
        game.Roll(10);
        game.Roll(10);

        Assert.AreEqual(true, game.hadStrikeLastFrame);
    }

    [Test]
    public void CheckForNotStrikeFrameAfterNonStrikeFrame()
    {
        game.Roll(10);

        game.Roll(3);
        game.Roll(7);

        Assert.AreEqual(false, game.hadStrikeLastFrame);
    }

    [Test]
    public void AddStrikeFrameBonus()
    {
        game.Roll(10);

        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(14, game.score);
    }

    [Test]
    public void StrikeStrikeNonSpareCheck()
    {
        game.Roll(10);
        game.Roll(10);

        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(35, game.score);
    }
}