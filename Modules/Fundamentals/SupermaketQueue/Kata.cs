namespace codewars.Modules.Fundamentals.SupermaketQueue;

public class Kata
{
    public static int QueueTime(int[] arr, int n)
    {
        int[] tills = new int[n];

        for (int i = 0; i < arr.Length; i++)
            tills[tills.ToList().IndexOf(tills.Min())] += arr[i];

        return tills.Max();
    }
}