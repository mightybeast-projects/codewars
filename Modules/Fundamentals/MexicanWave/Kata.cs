namespace codewars.Modules.Fundamentals.MexicanWave;

public class Kata
{
    public static List<string> Wave(string str)
    {
        List<string> result = new List<string>();

        for (int i = 0; i < str.Length; i++)
            if (!Char.IsWhiteSpace(str[i]))
                result.Add(
                    str.Remove(i, 1)
                    .Insert(i, Char.ToUpper(str[i])
                    .ToString()));

        return result;
    }
}