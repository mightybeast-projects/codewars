using NUnit.Framework;

namespace codewars.Modules.Practice.BowlingGame.FirstVariant.BowlingTests;

[TestFixture]
public class BowlingTests
{
    private BowlingGame game;

    [SetUp]
    public void SetUp() => game = new BowlingGame();

    [Test]
    public void StrikeNonSpareNonSpareCheck()
    {
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
        for (int i = 0; i < 20; i++)
            game.Roll(1);

        Assert.AreEqual(20, game.score);
    }

    [Test]
    public void StrikeStrikeStrikeNonSpareNonSpareCheck()
    {
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
        for (int i = 0; i < 9; i++)
            game.Roll(10);

        game.Roll(10);
        game.Roll(10);
        game.Roll(10);

        Assert.AreEqual(300, game.score);
    }

    [Test]
    public void MoreThanTenFrames()
    {
        for (int i = 0; i < 20; i++)
            game.Roll(1);

        game.Roll(1);
        game.Roll(1);

        game.Roll(1);

        game.Roll(1);

        Assert.AreEqual(20, game.score);
    }

    [Test]
    public void DoubleStrikeAtTenthFrame()
    {
        for (int i = 0; i < 9; i++)
            game.Roll(10);

        game.Roll(10);
        game.Roll(1);
        game.Roll(1);

        Assert.AreEqual(273, game.score);
    }

    [Test]
    public void RandomTest()
    {
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