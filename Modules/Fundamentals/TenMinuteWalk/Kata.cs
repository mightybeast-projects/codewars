namespace codewars.Modules.Fundamentals.TenMinuteWalk;

public class Kata
{
    public static bool IsValidWalk(string[] arr)
    {
        return arr.Length == 10 &&
            arr.Count(x => x == "n") == arr.Count(x => x == "s") && 
            arr.Count(x => x == "w") == arr.Count(x => x == "e");
    }
}