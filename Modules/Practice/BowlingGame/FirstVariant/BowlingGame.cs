namespace BowlingGame.FirstVariant;

internal class BowlingGame
{
    public int currentFrame { get; private set; } = 1;
    public int score { get; private set; }
    public bool hadSpareLastFrame { get; private set; }
    public bool hadStrikeLastFrame { get; private set; }
    
    private bool frameStart = true;
    private int currentDownedPins;
    private int frameScore;
    private bool hadDoubleStrike;
    private bool isBonusRoll;

    public void Roll(int pins)
    {
        if (PlayerTripleStrikedOnTenthFrame()) return;

        if (currentFrame > 10 && !isBonusRoll) return;

        currentDownedPins = pins;
        frameScore += currentDownedPins;
        score += currentDownedPins;

        if (frameStart)
            HandleFirstHalfFrame();
        else
            HandleSecondHalfFrame();

        if (PlayerRolledLastBonusStrikeRoll())
            score += currentDownedPins;

        frameStart = !frameStart;
    }

    private void HandleFirstHalfFrame()
    {
        if (hadDoubleStrike)
            HandleDoubleStrikeRoll();

        if (PlayerStrikedOnNonTenthFrame())
            score += currentDownedPins;

        if (PlayerSparedOnNonTenthFrame())
        {
            score += currentDownedPins;
            hadSpareLastFrame = false;
        }

        if (currentDownedPins == 10)
            HandleStrikeRoll();
    }

    private void HandleSecondHalfFrame()
    {
        if (PlayerStrikedOnNonTenthFrame())
            score += currentDownedPins;

        if (frameScore == 10)
            HandleSpareRoll();

        currentFrame++;
        hadStrikeLastFrame = false;
        frameScore = 0;
    }

    private void HandleStrikeRoll()
    {
        if (hadStrikeLastFrame)
            hadDoubleStrike = true;
        if (currentFrame >= 10)
            isBonusRoll = true;
        hadStrikeLastFrame = true;

        frameStart = !frameStart;
        currentFrame++;
        frameScore = 0;
    }

    private void HandleDoubleStrikeRoll()
    {
        score += currentDownedPins;
        hadDoubleStrike = false;
    }

    private void HandleSpareRoll()
    {
        if (currentFrame >= 10)
            isBonusRoll = true;
        hadSpareLastFrame = true;
    }

    private bool PlayerTripleStrikedOnTenthFrame() => currentFrame == 12;

    private bool PlayerRolledLastBonusStrikeRoll() => 
        currentFrame == 12 && hadStrikeLastFrame;

    private bool PlayerStrikedOnNonTenthFrame() => 
        hadStrikeLastFrame && !isBonusRoll;

    private bool PlayerSparedOnNonTenthFrame() =>
        hadSpareLastFrame && !isBonusRoll;
}