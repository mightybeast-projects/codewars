namespace codewars.Modules.Fundamentals.SortTheOdd;

public class Kata
{
    public static int[] SortArray(int[] arr)
    {
        Queue<int> oddNumbers =
            new Queue<int>(arr
                .Where(x => NumberIsOdd(x))
                .OrderBy(x => x));

        return arr
            .Select(x => NumberIsOdd(x) ? oddNumbers.Dequeue() : x)
            .ToArray();
    }

    private static bool NumberIsOdd(int i) => i % 2 != 0;
}