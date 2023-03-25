namespace codewars.Modules.Practice.BurrowsWheelerTransformation;

public class Kata
{
    public static Tuple<string, int> Encode(string s)
    {
        if (string.IsNullOrEmpty(s)) return Tuple.Create(s, 0);

        List<string> strMatrix = new List<string>();

        for (int i = 0; i < s.Length; i++)
            strMatrix.Add(s[^i..] + s.Substring(0, s.Length - i));

        strMatrix.Sort(StringComparer.Ordinal);

        string encodedStr = "";

        foreach (string str in strMatrix)
            encodedStr += str[^1..];

        return Tuple.Create(encodedStr, strMatrix.IndexOf(s));
    }

    public static string Decode(string s, int n)
    {
        if (string.IsNullOrEmpty(s)) return s;

        List<string> strMatrix = Enumerable.Repeat("", s.Length).ToList();

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < s.Length; j++)
                strMatrix[j] = s[j].ToString() + strMatrix[j];

            strMatrix.Sort(StringComparer.Ordinal);
        }

        return strMatrix[n];
    }
}