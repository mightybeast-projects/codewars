namespace codewars.Modules.Fundamentals.ExpandedForm;

public class Kata
{
    public static string ExpandedForm(long num) 
    {
        List<long> form = new List<long>();

        long divisor = 10;

        while ((float) num / divisor > 1)
        {
            long mod = num % divisor;
            if (mod != 0)
                form.Add(mod);
            num -= (mod);
            divisor *= 10;
        }

        form.Add(num);
        System.Console.WriteLine(string.Join(" + ", form.ToArray().Reverse()));

        return string.Join(" + ", form.ToArray().Reverse());
    }
}