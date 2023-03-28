namespace codewars.Modules.Practice.ConwayLife;

public class Kata
{
    private static int[,] original;
    private static int[,] universe;
    private static bool endDeletion;
    private static bool offset;

    public static int[,] GetGeneration(int[,] cells, int generation)
    {
        if (generation == 0) return cells;

        original = cells;

        InitializeUniverse();
        StepGeneration();
        TrimUniverse();

        return GetGeneration(universe, generation - 1);
    }

    private static void InitializeUniverse()
    {
        universe =
            new int[original.GetLength(0) + 2, original.GetLength(1) + 2];

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

    private static void HandleAliveCell(int i, int j, int neighboursCount)
    {
        if (neighboursCount < 2 || neighboursCount > 3)
            universe[i, j] = 0;
        else if (neighboursCount == 2 || neighboursCount == 3)
            universe[i, j] = 1;
    }

    private static void TrimUniverse()
    {
        for (int i = 0; i < universe.GetLength(0); i++)
        {
            HandleRowDeletion(i);
            if (!endDeletion) i--;
        }

        endDeletion = false;

        for (int i = universe.GetLength(0) - 1; i >= 0; i--)
            HandleRowDeletion(i);

        endDeletion = false;

        for (int j = 0; j < universe.GetLength(1); j++)
        {
            HandleColDeletion(j);
            if (!endDeletion) j--;
        }

        endDeletion = false;

        for (int j = universe.GetLength(1) - 1; j >= 0; j--)
            HandleColDeletion(j);

        endDeletion = false;
    }

    private static void HandleRowDeletion(int i)
    {
        if (endDeletion) return;

        if (UniverseRowIsEmpty(i))
            DeleteRow(i);
        else endDeletion = true;
    }

    private static void HandleColDeletion(int j)
    {
        if (endDeletion) return;

        if (UniverseColIsEmpty(j))
            DeleteCol(j);
        else endDeletion = true;
    }

    private static int GetNeighboursCount(int k, int l)
    {
        int count = 0;
        for (int i = k - 1; i < k + 2; i++)
        {
            for (int j = l - 1; j < l + 2; j++)
            {
                if (i == k && j == l) continue;
                try { if (original[i, j] == 1) count++; }
                catch (Exception) { continue; }
            }
        }

        return count;
    }

    private static void DeleteRow(int index)
    {
        original = universe;
        universe =
            new int[original.GetLength(0) - 1, original.GetLength(1)];
        offset = false;

        for (int i = 0; i < original.GetLength(0); i++)
            if (i != index)
                for (int j = 0; j < original.GetLength(1); j++)
                    universe[i - Convert.ToInt32(offset), j] = original[i, j];
            else
                offset = true;
    }

    private static void DeleteCol(int index)
    {
        original = universe;
        universe =
            new int[original.GetLength(0), original.GetLength(1) - 1];
        offset = false;

        for (int i = 0; i < original.GetLength(0); i++, offset = false)
            for (int j = 0; j < original.GetLength(1); j++)
                if (j == index)
                    offset = true;
                else
                    universe[i, j - Convert.ToInt32(offset)] = original[i, j];
    }

    private static bool UniverseRowIsEmpty(int i)
    {
        for (int j = 0; j < universe.GetLength(1); j++)
            if (universe[i, j] == 1) return false;
        return true;
    }

    private static bool UniverseColIsEmpty(int j)
    {
        for (int i = 0; i < universe.GetLength(0); i++)
            if (universe[i, j] == 1) return false;
        return true;
    }
}