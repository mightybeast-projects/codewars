namespace codewars.Modules.Fundamentals.TenMinuteWalk;

public class Kata
{
    public static bool IsValidWalk(string[] arr)
    {
        if (arr.Length != 10) return false;

        int[] position = new[] { 0, 0 };

        foreach (string s in arr)
        {
            if (s == "n") position[1]++;
            if (s == "s") position[1]--;
            if (s == "e") position[0]++;
            if (s == "w") position[0]--;
        }

        return position[0] == 0 && position[1] == 0;
    }
}