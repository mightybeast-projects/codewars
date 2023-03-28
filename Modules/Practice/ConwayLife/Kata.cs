namespace codewars.Modules.Practice.ConwayLife;

public class Kata
{
    private static int[,] matrix;
    private static bool endRowDeletion;
    private static bool endColDeletion;

    public static int[,] GetGeneration(int[,] cells, int generation)
    {
        if (cells.GetLength(0) == 0) return cells;

        int[,] original = cells;

        for (int i = 0; i < generation; i++)
        {
            matrix = new int[original.GetLength(0) + 2, original.GetLength(1) + 2];

            //PrintMatrix(matrix);

            WrapMatrix(original);

            //PrintMatrix(matrix);

            ApplyGameRules();

            //PrintMatrix(matrix);

            DeleteEmptyRowsAndCols();

            //PrintMatrix(matrix);

            original = matrix;
        }

        return matrix;
    }

    private static void WrapMatrix(int[,] cells)
    {
        for (int i = 1; i < cells.GetLength(0) + 1; i++)
            for (int j = 1; j < cells.GetLength(1) + 1; j++)
                matrix[i, j] = cells[i - 1, j - 1];
    }

    private static void ApplyGameRules()
    {
        int[,] original = matrix;
        matrix = new int[original.GetLength(0), original.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int cell = original[i, j];
                int cellNeighbours = GetNeighboursCount(original, i, j);

                if (cell == 1)
                {
                    if (cellNeighbours < 2 || cellNeighbours > 3)
                        matrix[i, j] = 0;
                    else if (cellNeighbours == 2 || cellNeighbours == 3)
                        matrix[i, j] = 1;
                }
                else if (cellNeighbours == 3) matrix[i, j] = 1;
                else matrix[i, j] = 0;
            }
        }
    }

    private static void DeleteEmptyRowsAndCols()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            HandleRowDeletion(i);
            if (!endRowDeletion) i--;
        }

        endRowDeletion = false;
        
        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            HandleRowDeletion(i);
        
        endRowDeletion = false;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            HandleColDeletion(j);
            if (!endColDeletion) j--;
        }

        endColDeletion = false;

        for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
            HandleColDeletion(j);
        
        endColDeletion = false;
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

    private static int GetNeighboursCount(int[,] arr, int k, int l)
    {
        int count = 0;
        for (int i = k - 1; i < k + 2; i++)
        {
            for (int j = l - 1; j < l + 2; j++)
            {
                if (i == k && j == l) continue;
                try { if (arr[i, j] == 1) count++; }
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

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                System.Console.Write(matrix[i, j]);
            System.Console.WriteLine("");
        }
    }
}