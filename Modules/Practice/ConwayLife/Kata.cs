namespace codewars.Modules.Practice.ConwayLife;

public class Kata
{
    private static int[,] matrix;

    public static int[,] GetGeneration(int[,] cells, int generation)
    {
        if (cells.GetLength(0) == 0) return cells;

        int matrixSize = Math.Max(cells.GetLength(0), cells.GetLength(1));
        matrix = new int[matrixSize + 2, matrixSize + 2];

        //PrintMatrix(matrix);

        for (int i = 1; i < cells.GetLength(0) + 1; i++)
            for (int j = 1; j < cells.GetLength(1) + 1; j++)
                matrix[i, j] = cells[i - 1, j - 1];

        //PrintMatrix(matrix);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int cell = matrix[i, j];
                int cellNeighbours = GetNeighboursCount(i, j);
                
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

        //PrintMatrix(matrix);

        /*System.Console.WriteLine(MatrixRowIsEmpty(0));
        System.Console.WriteLine(MatrixRowIsEmpty(matrix.GetLength(0) - 1));
        System.Console.WriteLine(MatrixColIsEmpty(0));
        System.Console.WriteLine(MatrixColIsEmpty(matrix.GetLength(1) - 1));*/

        matrix.T

        PrintMatrix(matrix);

        return matrix;
    }

    private static int GetNeighboursCount(int k, int l)
    {
        int count = 0;
        for (int i = k - 1; i < k + 2; i++)
        {
            for (int j = l - 1; j < l + 2; j++)
            {
                if (i == k && j == l) continue;
                try { if (matrix[i, j] == 1) count++; }
                catch (Exception) { continue; }
            }
        }

        return count;
    }

    private static bool MatrixRowIsEmpty(int i)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i, j] == 1) return false;
        return true;
    }

    private static bool MatrixColIsEmpty(int j)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
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