namespace BowlingGame.FirstVariant;

internal class BowlingGame
{
    internal int score => _score;
    internal int currentFrame => _currentFrame;
    internal bool hadSpareFrame => _hadSpareLastFrame;
    internal bool hadStrikeLastFrame => _hadStrikeLastFrame;

    private int _currentFrame = 1;
    private bool _frameStart = true;
    private int _score;
    private int _currentDownedPins;
    private int _frameScore;

    private bool _hadSpareLastFrame;
    private bool _hadStrikeLastFrame;
    private bool _hadDoubleStrike;

    private bool _isBonusRoll;

    public void Roll(int pins)
    {
        if (PlayerTripleStrikedOnTenthFrame()) return;

        if (_currentFrame > 10 && !_isBonusRoll) return;

        _currentDownedPins = pins;
        _frameScore += _currentDownedPins;
        _score += _currentDownedPins;

        if (_frameStart)
            HandleFirstHalfFrame();
        else
            HandleSecondHalfFrame();

        if (PlayerRolledLastBonusStrikeRoll())
            _score += _currentDownedPins;

        _frameStart = !_frameStart;
    }

    private void HandleFirstHalfFrame()
    {
        if (_hadDoubleStrike)
            HandleDoubleStrikeRoll();

        if (PlayerStrikedOnNonTenthFrame())
            _score += _currentDownedPins;

        if (PlayerSparedOnNonTenthFrame())
        {
            _score += _currentDownedPins;
            _hadSpareLastFrame = false;
        }

        if (_currentDownedPins == 10)
            HandleStrikeRoll();
    }

    private void HandleSecondHalfFrame()
    {
        if (PlayerStrikedOnNonTenthFrame())
            _score += _currentDownedPins;

        if (_frameScore == 10)
            HandleSpareRoll();

        _currentFrame++;
        _hadStrikeLastFrame = false;
        _frameScore = 0;
    }

    private bool PlayerTripleStrikedOnTenthFrame()
    {
        return _currentFrame == 12;
    }

    private bool PlayerRolledLastBonusStrikeRoll()
    {
        return _currentFrame == 12 && _hadStrikeLastFrame;
    }

    private void HandleDoubleStrikeRoll()
    {
        _score += _currentDownedPins;
        _hadDoubleStrike = false;
    }

    private bool PlayerStrikedOnNonTenthFrame()
    {
        return _hadStrikeLastFrame && !_isBonusRoll;
    }

    private bool PlayerSparedOnNonTenthFrame()
    {
        return _hadSpareLastFrame && !_isBonusRoll;
    }

    private void HandleStrikeRoll()
    {
        if (_hadStrikeLastFrame)
            _hadDoubleStrike = true;
        if (_currentFrame >= 10)
            _isBonusRoll = true;
        _hadStrikeLastFrame = true;

        _frameStart = !_frameStart;
        _currentFrame++;
        _frameScore = 0;
    }

    private void HandleSpareRoll()
    {
        if (_currentFrame >= 10)
            _isBonusRoll = true;
        _hadSpareLastFrame = true;
    }
}