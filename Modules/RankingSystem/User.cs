namespace RankingSystem;

public class User
{
    internal int rank = -8;
    internal int progress;

    private int _activityRank;

    internal void incProgress(int activityRank)
    {
        _activityRank = activityRank;

        if (RankIsOutOfRange())
            throw new ArgumentException();

        if (rank == 8) return;
        else if (_activityRank == rank - NegativeZeroRankOffset())
            progress += 1;
        else if (_activityRank == rank)
            progress += 3;
        else if (_activityRank > rank)
            CalculateAndApplyProgress();
    }

    private void CalculateAndApplyProgress()
    {
        int d = _activityRank - rank - PositiveZeroRankOffset();
        progress += 10 * (int) Math.Pow(d, 2);

        while (progress >= 100)
        {
            if (++rank == 0) rank++;
            if (rank == 8)
            {
                progress = 0;
                return;
            }
            progress -= 100;
        }
    }

    private int PositiveZeroRankOffset()
    {
        return _activityRank >= 1 && rank < 0 ? 1 : 0;
    }

    private int NegativeZeroRankOffset()
    {
        return _activityRank < rank && _activityRank < 0 ? 2 : 1;
    }

    private bool RankIsOutOfRange()
    {
        return _activityRank < -8 || _activityRank == 0 || _activityRank > 8;
    }
}