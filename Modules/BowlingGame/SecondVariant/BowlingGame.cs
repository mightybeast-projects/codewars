namespace BowlingGame.SecondVariant;

public class BowlingGame
{
    private int[] _rolls = new int[21];
    private int _downedPins;
    private int _currentIndex;
    private int _frameScore;
    int _totalScore = 0;
    int _frameIndex = 0;

    internal void Roll(int pins)
    {
        _downedPins = pins;
        try { AddPinsToArray(); }
        catch (Exception) { return; }
    }

    internal int Score()
    {
        for (int frame = 0; frame < 10; frame++)
        {
            _frameScore = _rolls[_frameIndex] + _rolls[_frameIndex + 1];

            if (_rolls[_frameIndex] == 10)
                HandleStrikeRoll();
            else if (_frameScore == 10)
                HandleSpareFrame();
            else
                HandleSimpleFrame();

            _frameScore = 0;
        }

        return _totalScore;
    }

    private void HandleSimpleFrame()
    {
        _totalScore += _frameScore;
        _frameIndex += 2;
    }

    private void HandleSpareFrame()
    {
        _totalScore += 10 + _rolls[_frameIndex + 2];
        _frameIndex += 2;
    }

    private void HandleStrikeRoll()
    {
        _totalScore += 10 + _rolls[_frameIndex + 1] + _rolls[_frameIndex + 2];
        _frameIndex++;
    }

    private void AddPinsToArray()
    {
        _rolls[_currentIndex] = _downedPins;
        _currentIndex++;
    }
}