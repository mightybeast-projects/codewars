using NUnit.Framework;
using FirstVariant;

namespace BowlingTests;

[TestFixture]
public class BowlingTests
{
    [Test]
    public void StrikeNonSpareNonSpareCheck()
    {
        Game game = new Game();

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
        Game game = new Game();

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
        Game game = new Game();

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
        Game game = new Game();

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
        Game game = new Game();

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
        Game game = new Game();

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
        Game game = new Game();

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
        Game game = new Game();

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
        Game game = new Game();

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
        Game game = new Game();

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