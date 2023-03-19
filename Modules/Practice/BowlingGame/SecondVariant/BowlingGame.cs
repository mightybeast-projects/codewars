namespace codewars.Modules.Practice.BowlingGame.SecondVariant;

public class BowlingGame
{
    private int[] rolls = new int[21];
    private int downedPins;
    private int currentIndex;
    private int frameScore;
    private int totalScore = 0;
    private int frameIndex = 0;

    public void Roll(int pins)
    {
        downedPins = pins;
        try { AddPinsToArray(); }
        catch (Exception) { return; }
    }

    public int Score()
    {
        for (int frame = 0; frame < 10; frame++)
            CalculateFrameScore();

        return totalScore;
    }

    private void CalculateFrameScore()
    {
        frameScore = rolls[frameIndex] + rolls[frameIndex + 1];

        if (rolls[frameIndex] == 10)
            HandleStrikeRoll();
        else if (frameScore == 10)
            HandleSpareFrame();
        else
            HandleSimpleFrame();

        frameScore = 0;
    }

    private void HandleSimpleFrame()
    {
        totalScore += frameScore;
        frameIndex += 2;
    }

    private void HandleSpareFrame()
    {
        totalScore += 10 + rolls[frameIndex + 2];
        frameIndex += 2;
    }

    private void HandleStrikeRoll()
    {
        totalScore += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
        frameIndex++;
    }

    private void AddPinsToArray()
    {
        rolls[currentIndex] = downedPins;
        currentIndex++;
    }
}