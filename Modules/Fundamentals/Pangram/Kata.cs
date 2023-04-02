namespace codewars.Modules.Fundamentals.Pangram;

public class Kata
{
    public static bool IsPangram(string str) =>
        str.ToLower().Where(Char.IsLetter).Distinct().Count() >= 26;
}