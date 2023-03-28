namespace codewars.Modules.Practice.ConwayLife;

public class Trimmer
{
    private int[,] original;
    private int[,] universe;
    private bool offset;

    public Trimmer(int[,] universe) => this.universe = universe;

    public int[,] TrimUniverse()
    {
        TrimRows();
        TrimCols();

        return universe;
    }

    private void TrimRows()
    {
        while (UniverseRowIsEmpty(0))
            DeleteUniverseRow(0);
        while (UniverseRowIsEmpty(universe.GetLength(0) - 1))
            DeleteUniverseRow(universe.GetLength(0) - 1);
    }

    private void TrimCols()
    {
        while (UniverseColIsEmpty(0))
            DeleteUniverseCol(0);
        while (UniverseColIsEmpty(universe.GetLength(1) - 1))
            DeleteUniverseCol(universe.GetLength(1) - 1);
    }

    private void DeleteUniverseRow(int index)
    {
        original = universe;
        offset = false;
        universe =
            new int[original.GetLength(0) - 1, original.GetLength(1)];

        for (int i = 0; i < original.GetLength(0); i++)
            if (i != index)
                for (int j = 0; j < original.GetLength(1); j++)
                    universe[i - Convert.ToInt32(offset), j] = original[i, j];
            else
                offset = true;
    }

    private void DeleteUniverseCol(int index)
    {
        original = universe;
        offset = false;
        universe =
            new int[original.GetLength(0), original.GetLength(1) - 1];
        

        for (int i = 0; i < original.GetLength(0); i++, offset = false)
            for (int j = 0; j < original.GetLength(1); j++)
                if (j == index)
                    offset = true;
                else
                    universe[i, j - Convert.ToInt32(offset)] = original[i, j];
    }

    private bool UniverseRowIsEmpty(int i)
    {
        for (int j = 0; j < universe.GetLength(1); j++)
            if (universe[i, j] == 1) return false;
        return true;
    }

    private bool UniverseColIsEmpty(int j)
    {
        for (int i = 0; i < universe.GetLength(0); i++)
            if (universe[i, j] == 1) return false;
        return true;
    }
}