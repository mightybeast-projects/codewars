namespace ArrayStats;

public class ArrayStats
{
    public int[] array => _array;

    private int[] _array;

    public ArrayStats(int[] array)
    {
        _array = array;
    }

    internal int GetMin()
    {
        int minElement = _array[0];

        for (int i = 0; i < _array.Count(); i++)
            if (_array[i] < minElement)
                minElement = _array[i];

        return minElement;
    }

    internal int GetMax()
    {
        int maxElement = _array[0];

        for (int i = 0; i < _array.Count(); i++)
            if (_array[i] > maxElement)
                maxElement = _array[i];

        return maxElement;
    }

    internal int GetSize()
    {
        return _array.Count();
    }

    internal int GetAverage()
    {
        return GetSum() / _array.Count();
    }

    internal string OddOrEvenSum()
    {
        if (GetSum() % 2 == 0)
            return "even";
        else
            return "odd";
    }

    private int GetSum()
    {
        int sum = 0;

        for (int i = 0; i < _array.Count(); i++)
            sum += _array[i];

        return sum;
    }
}