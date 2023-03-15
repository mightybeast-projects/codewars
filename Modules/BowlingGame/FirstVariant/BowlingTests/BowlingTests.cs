using NUnit.Framework;

namespace BowlingGame.FirstVariant;

[TestFixture]
public class BowlingTests
{
    [Test]
    public void StrikeNonSpareNonSpareCheck()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(10);

        game.Roll(1);
        game.Roll(1);

        game.Roll(2);
        game.Roll(2);

        Assert.AreEqual(18, game.score);
    }

    [Test]
    public void StrikeNonSpareSpareNonSpareCheck()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(10);

        game.Roll(1);
        game.Roll(1);

        game.Roll(2);
        game.Roll(8);

        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(27, game.score);
    }

    [Test]
    public void StrikeSpareNonSpareCheck()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(10);

        game.Roll(2);
        game.Roll(8);

        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(33, game.score);
    }

    [Test]
    public void NonSpareSpareStrikeNonSpareCheck()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(1);
        game.Roll(1);

        game.Roll(2);
        game.Roll(8);

        game.Roll(10);

        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(36, game.score);
    }

    [Test]
    public void AllOnesCheck()
    {
        BowlingGame game = new BowlingGame();

        for (int i = 0; i < 10; i++)
        {
            game.Roll(1);
            game.Roll(1);
        }

        Assert.AreEqual(20, game.score);
    }

    [Test]
    public void StrikeStrikeStrikeNonSpareNonSpareCheck()
    {
        BowlingGame game = new BowlingGame();

        for (int i = 0; i < 3; i++)
            game.Roll(10);

        game.Roll(1);
        game.Roll(1);

        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(67, game.score);
    }

    [Test]
    public void AllStrikesCheck()
    {
        BowlingGame game = new BowlingGame();

        for (int i = 0; i < 9; i++)
        {
            game.Roll(10);
        }

        game.Roll(10);
        game.Roll(10);
        game.Roll(10);

        Assert.AreEqual(300, game.score);
    }

    [Test]
    public void MoreThanTenFrames()
    {
        BowlingGame game = new BowlingGame();

        for (int i = 0; i < 10; i++)
        {
            game.Roll(1);
            game.Roll(1);
        }

        game.Roll(1);
        game.Roll(1);

        game.Roll(1);

        game.Roll(1);

        Assert.AreEqual(20, game.score);
    }

    [Test]
    public void DoubleStrikeAtTenthFrame()
    {
        BowlingGame game = new BowlingGame();

        for (int i = 0; i < 9; i++)
        {
            game.Roll(10);
        }

        game.Roll(10);
        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(273, game.score);
    }

    [Test]
    public void RandomTest()
    {
        BowlingGame game = new BowlingGame();

        game.Roll(1);
        game.Roll(4);

        game.Roll(4);
        game.Roll(5);

        game.Roll(6);
        game.Roll(4);

        game.Roll(5);
        game.Roll(5);

        game.Roll(10);

        game.Roll(0);
        game.Roll(1);
        Assert.AreEqual(61, game.score);

        game.Roll(7);
        game.Roll(3);

        game.Roll(6);
        game.Roll(4);

        game.Roll(10);
        Assert.AreEqual(107, game.score);

        game.Roll(2);
        game.Roll(8);
        game.Roll(6);

        Assert.AreEqual(133, game.score);
    }
}