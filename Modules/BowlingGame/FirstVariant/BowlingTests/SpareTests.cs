using NUnit.Framework;

namespace BowlingGame.FirstVariant;

[TestFixture]
public class SpareTests
{
    [Test]
    public void CheckForSpareFrame()
    {
        BowlingGame game = new BowlingGame();
        game.Roll(5);
        game.Roll(5);

        Assert.AreEqual(true, game.hadSpareFrame);
    }

    [Test]
    public void CheckForNotSpareFrameAfterNotSpareFrame()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(5);
        game.Roll(5);

        game.Roll(0);
        game.Roll(0);

        Assert.AreEqual(false, game.hadSpareFrame);
    }

    [Test]
    public void AddSpareBonusAfterSpareFrame()
    {
        BowlingGame game = new BowlingGame();

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