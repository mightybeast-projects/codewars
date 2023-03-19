using NUnit.Framework;

namespace codewars.Modules.Practice.BowlingGame.FirstVariant.BowlingTests;

[TestFixture]
public class FrameTests
{
    private BowlingGame game;

    [SetUp]
    public void SetUp() => game = new BowlingGame();

    [Test(ExpectedResult = 1)]
    public int FreshGameStartsAtFirstFrame() => game.currentFrame;

    [Test]
    public void AfterOneNonStrikeRollCurrentFrameIsOne()
    {
        game.Roll(0);

        Assert.AreEqual(1, game.currentFrame);
    }

    [Test]
    public void AfterTwoNonSpareRollsCurrentFrameIsTwo()
    {
        game.Roll(2);
        game.Roll(5);

        Assert.AreEqual(2, game.currentFrame);
    }

    [Test]
    public void CurrentFrameEqualsTwoAfterStrikeFrame()
    {
        game.Roll(10);

        Assert.AreEqual(2, game.currentFrame);
    }
}