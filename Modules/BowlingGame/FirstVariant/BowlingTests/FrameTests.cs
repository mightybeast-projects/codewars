using NUnit.Framework;
using FirstVariant;

namespace BowlingTests;

[TestFixture]
public class FrameTests
{
    [Test]
    public void FreshGameStartsAtFirstFrame()
    {
        Game game = new Game();

        Assert.AreEqual(1, game.currentFrame);
    }

    [Test]
    public void AfterOneNonStrikeRollCurrentFrameIsOne()
    {
        Game game = new Game();
        game.Roll(0);

        Assert.AreEqual(1, game.currentFrame);
    }

    [Test]
    public void AfterTwoNonSpareRollsCurrentFrameIsTwo()
    {
        Game game = new Game();
        game.Roll(2);
        game.Roll(5);

        Assert.AreEqual(2, game.currentFrame);
    }

    [Test]
    public void CurrentFrameEqualsTwoAfterStrikeFrame()
    {
        Game game = new Game();

        game.Roll(10);

        Assert.AreEqual(2, game.currentFrame);
    }
}