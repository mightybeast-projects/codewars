namespace ArrayStats;

public class ArrayStats
{
    private int[] array;

    public ArrayStats(int[] array) => this.array = array;

    public int GetMin()
    {
        int minElement = array[0];

        for (int i = 0; i < array.Count(); i++)
            if (array[i] < minElement)
                minElement = array[i];

        return minElement;
    }

    public int GetMax()
    {
        int maxElement = array[0];

        for (int i = 0; i < array.Count(); i++)
            if (array[i] > maxElement)
                maxElement = array[i];

        return maxElement;
    }

    public string OddOrEvenSum()
    {
        if (GetSum() % 2 == 0)
            return "even";
        else
            return "odd";
    }

    public int GetSize() => array.Count();

    public int GetAverage() => GetSum() / array.Count();

    private int GetSum()
    {
        int sum = 0;

        for (int i = 0; i < array.Count(); i++)
            sum += array[i];

        return sum;
    }
}