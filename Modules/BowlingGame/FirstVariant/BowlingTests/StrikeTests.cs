using NUnit.Framework;
using FirstVariant;

namespace BowlingTests;

[TestFixture]
public class StrikeTests
{
    [Test]
    public void CheckForStrikeFrame()
    {
        Game game = new Game();

        game.Roll(10);

        Assert.AreEqual(true, game.hadStrikeLastFrame);
    }

    [Test]
    public void CheckForStrikeCounterAfterDoubleStrike()
    {
        Game game = new Game();

        game.Roll(10);
        game.Roll(10);

        Assert.AreEqual(true, game.hadStrikeLastFrame);
    }

    [Test]
    public void CheckForNotStrikeFrameAfterNonStrikeFrame()
    {
        Game game = new Game();

        game.Roll(10);

        game.Roll(3);
        game.Roll(7);

        Assert.AreEqual(false, game.hadStrikeLastFrame);
    }

    [Test]
    public void AddStrikeFrameBonus()
    {
        Game game = new Game();

        game.Roll(10);

        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(14, game.score);
    }

    [Test]
    public void StrikeStrikeNonSpareCheck()
    {
        Game game = new Game();

        game.Roll(10);
        game.Roll(10);

        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(35, game.score);
    }
}