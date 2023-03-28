namespace codewars.Modules.Practice.ConwayLife;

public class Kata
{
    private static int[,] original;
    private static int[,] matrix;
    private static bool endRowDeletion;
    private static bool endColDeletion;

    public static int[,] GetGeneration(int[,] cells, int generation)
    {
        if (generation == 0) return cells;

        original = cells;

        for (int i = 0; i < generation; i++)
            HandleGeneration();

        return matrix;
    }

    private static void HandleGeneration()
    {
        InitializeAndWrapMatrix();
        ApplyGameRules();
        TrimMatrix();

        original = matrix;
    }

    private static void InitializeAndWrapMatrix()
    {
        matrix =
            new int[original.GetLength(0) + 2, original.GetLength(1) + 2];

        for (int i = 1; i < original.GetLength(0) + 1; i++)
            for (int j = 1; j < original.GetLength(1) + 1; j++)
                matrix[i, j] = original[i - 1, j - 1];
    }

    private static void ApplyGameRules()
    {
        original = matrix;
        matrix = new int[original.GetLength(0), original.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                HandleMatrixCell(i, j);
    }

    private static void HandleMatrixCell(int i, int j)
    {
        int cell = original[i, j];
        int neighboursCount = GetNeighboursCount(i, j);

        if (cell == 1)
            HandleAliveCell(i, j, neighboursCount);
        else if (neighboursCount == 3) matrix[i, j] = 1;
        else matrix[i, j] = 0;
    }

    private static void HandleAliveCell(int i, int j, int veighboursCount)
    {
        if (veighboursCount < 2 || veighboursCount > 3)
            matrix[i, j] = 0;
        else if (veighboursCount == 2 || veighboursCount == 3)
            matrix[i, j] = 1;
    }

    private static void TrimMatrix()
    {
        endRowDeletion = false;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            HandleRowDeletion(i);
            if (!endRowDeletion) i--;
        }

        endRowDeletion = false;

        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            HandleRowDeletion(i);

        endColDeletion = false;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            HandleColDeletion(j);
            if (!endColDeletion) j--;
        }

        endColDeletion = false;

        for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
            HandleColDeletion(j);
    }

    private static void HandleRowDeletion(int i)
    {
        if (endRowDeletion) return;

        if (MatrixRowIsEmpty(i))
            DeleteRow(i);
        else endRowDeletion = true;
    }

    private static void HandleColDeletion(int j)
    {
        if (endColDeletion) return;

        if (MatrixColIsEmpty(j))
            DeleteCol(j);
        else endColDeletion = true;
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
        int[,] original = matrix;
        matrix = new int[original.GetLength(0) - 1, original.GetLength(1)];
        bool rowOffset = false;

        for (int i = 0; i < original.GetLength(0); i++)
        {
            if (i == index)
            {
                rowOffset = true;
                continue;
            }

            for (int j = 0; j < original.GetLength(1); j++)
                matrix[i - Convert.ToInt32(rowOffset), j] = original[i, j];
        }
    }

    private static void DeleteCol(int index)
    {
        int[,] original = matrix;
        matrix = new int[original.GetLength(0), original.GetLength(1) - 1];
        bool colOffset = false;

        for (int i = 0; i < original.GetLength(0); i++)
        {
            for (int j = 0; j < original.GetLength(1); j++)
            {
                if (j == index)
                {
                    colOffset = true;
                    continue;
                }

                matrix[i, j - Convert.ToInt32(colOffset)] = original[i, j];
            }

            colOffset = false;
        }
    }

    private static bool MatrixRowIsEmpty(int i)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i, j] == 1) return false;
        return true;
    }

    private static bool MatrixColIsEmpty(int j)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
            if (matrix[i, j] == 1) return false;
        return true;
    }
}