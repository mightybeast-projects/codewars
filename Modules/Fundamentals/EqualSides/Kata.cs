namespace codewars.Modules.Fundamentals.EqualSides;

public class Kata
{
    public static int GetEvenIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr.Take(i).Sum() == arr.TakeLast(arr.Length - 1 - i).Sum())
                return i;
        
        return -1;
    }
}