namespace RankingSystem;

public class User
{
    public int rank = -8;
    public int progress;

    private int activityRank;

    public void incProgress(int currentActivityRank)
    {
        activityRank = currentActivityRank;

        if (RankIsOutOfRange())
            throw new ArgumentException();

        if (rank == 8) return;
        else if (activityRank == rank - NegativeZeroRankOffset())
            progress += 1;
        else if (activityRank == rank)
            progress += 3;
        else if (activityRank > rank)
            CalculateAndApplyProgress();
    }

    private void CalculateAndApplyProgress()
    {
        int d = activityRank - rank - PositiveZeroRankOffset();
        progress += 10 * (int)Math.Pow(d, 2);

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

    private int PositiveZeroRankOffset() =>
        activityRank >= 1 && rank < 0 ? 1 : 0;

    private int NegativeZeroRankOffset() =>
        activityRank < rank && activityRank < 0 ? 2 : 1;

    private bool RankIsOutOfRange() =>
        activityRank < -8 || activityRank == 0 || activityRank > 8;
}