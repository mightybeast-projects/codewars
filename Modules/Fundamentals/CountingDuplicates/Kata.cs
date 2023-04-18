namespace codewars.Modules.Fundamentals.CountingDuplicates;

public class Kata
{
    public static int DuplicateCount(string str) =>
        str.ToLower().GroupBy(x => x).Count(x => x.Count() > 1);
}