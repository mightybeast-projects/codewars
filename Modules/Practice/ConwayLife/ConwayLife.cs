namespace codewars.Modules.Practice.ConwayLife;

public class ConwayLife
{
    private static int[,] original;
    private static int[,] universe;

    public static int[,] GetGeneration(int[,] cells, int generation)
    {
        if (generation == 0) return cells;

        original = cells;

        InitializeUniverse();
        StepGeneration();
        universe = new Trimmer(universe).TrimUniverse();

        return GetGeneration(universe, generation - 1);
    }

    private static void InitializeUniverse()
    {
        int width = original.GetLength(0) + 2;
        int height = original.GetLength(1) + 2;
        universe = new int[width, height];

        for (int i = 1; i < original.GetLength(0) + 1; i++)
            for (int j = 1; j < original.GetLength(1) + 1; j++)
                universe[i, j] = original[i - 1, j - 1];
    }

    private static void StepGeneration()
    {
        original = universe;
        universe = new int[original.GetLength(0), original.GetLength(1)];

        for (int i = 0; i < universe.GetLength(0); i++)
            for (int j = 0; j < universe.GetLength(1); j++)
                HandleCell(i, j);
    }

    private static void HandleCell(int i, int j)
    {
        int neighboursCount = GetNeighboursCount(i, j);

        if (original[i, j] == 1)
            HandleAliveCell(i, j, neighboursCount);
        else if (neighboursCount == 3) universe[i, j] = 1;
        else universe[i, j] = 0;
    }

    private static int GetNeighboursCount(int k, int l)
    {
        int count = 0;
        int maxRows = Math.Min(k + 2, original.GetLength(0));
        int maxCols = Math.Min(l + 2, original.GetLength(1));

        for (int i = Math.Max(k - 1, 0); i < maxRows; i++)
            for (int j = Math.Max(l - 1, 0); j < maxCols; j++)
                if ((i != k || j != l) && original[i, j] == 1)
                    count++;

        return count;
    }

    private static void HandleAliveCell(int i, int j, int neighboursCount)
    {
        if (neighboursCount < 2 || neighboursCount > 3)
            universe[i, j] = 0;
        else if (neighboursCount == 2 || neighboursCount == 3)
            universe[i, j] = 1;
    }
}