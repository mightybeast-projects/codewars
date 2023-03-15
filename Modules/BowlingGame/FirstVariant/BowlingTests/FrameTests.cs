using NUnit.Framework;

namespace BowlingGame.FirstVariant;

[TestFixture]
public class FrameTests
{
    [Test]
    public void FreshGameStartsAtFirstFrame()
    {
        BowlingGame game = new BowlingGame();

        Assert.AreEqual(1, game.currentFrame);
    }

    [Test]
    public void AfterOneNonStrikeRollCurrentFrameIsOne()
    {
        BowlingGame game = new BowlingGame();
        game.Roll(0);

        Assert.AreEqual(1, game.currentFrame);
    }

    [Test]
    public void AfterTwoNonSpareRollsCurrentFrameIsTwo()
    {
        BowlingGame game = new BowlingGame();
        game.Roll(2);
        game.Roll(5);

        Assert.AreEqual(2, game.currentFrame);
    }

    [Test]
    public void CurrentFrameEqualsTwoAfterStrikeFrame()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(10);

        Assert.AreEqual(2, game.currentFrame);
    }
}