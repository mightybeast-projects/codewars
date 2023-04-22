namespace codewars.Modules.Practice.LastDigit;

public class Kata
{
    public static int LastDigit(int a, int b)
    {
        if (a == 0 && b == 0) return 1;

        int baseN = a % 10;
        int exponent = b;

        List<int> pattern = new List<int>();

        for (int j = 1; j < 10; j++)
        {
            int newNumber = (int) Math.Pow(baseN, j) % 10;
            if (pattern.Contains(newNumber))
                break;
            else
                pattern.Add(newNumber);
        }

        int index = exponent - (exponent / pattern.Count) * pattern.Count;

        if (index == 0)
            return pattern.Last();
        
        return pattern[index - 1];
    }
}