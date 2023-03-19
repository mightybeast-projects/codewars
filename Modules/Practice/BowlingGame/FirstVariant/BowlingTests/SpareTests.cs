using NUnit.Framework;

namespace codewars.Modules.Practice.BowlingGame.FirstVariant.BowlingTests;

[TestFixture]
public class SpareTests
{
    private BowlingGame game;

    [SetUp]
    public void SetUp() => game = new BowlingGame();

    [Test]
    public void CheckForSpareFrame()
    {
        game.Roll(5);
        game.Roll(5);

        Assert.AreEqual(true, game.hadSpareLastFrame);
    }

    [Test]
    public void CheckForNotSpareFrameAfterNotSpareFrame()
    {
        game.Roll(5);
        game.Roll(5);

        game.Roll(0);
        game.Roll(0);

        Assert.AreEqual(false, game.hadSpareLastFrame);
    }

    [Test]
    public void AddSpareBonusAfterSpareFrame()
    {
        game.Roll(7);
        game.Roll(3);

        game.Roll(5);
        game.Roll(1);

        game.Roll(3);
        game.Roll(7);

        game.Roll(2);
        game.Roll(2);

        Assert.AreEqual(37, game.score);
    }
}