namespace RankingSystem;

public class User
{
    internal int rank = -8;
    internal int progress;

    private int activityRank;

    public void incProgress(int activityRank)
    {
        this.activityRank = activityRank;

        if (RankIsOutOfRange())
            throw new ArgumentException();

        if (rank == 8) return;
        else if (this.activityRank == rank - NegativeZeroRankOffset())
            progress += 1;
        else if (this.activityRank == rank)
            progress += 3;
        else if (this.activityRank > rank)
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