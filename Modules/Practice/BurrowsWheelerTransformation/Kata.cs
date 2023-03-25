namespace codewars.Modules.Practice.BurrowsWheelerTransformation;

public class Kata
{
    public static Tuple<string, int> Encode(string s)
    {
        string encodedStr = s;
        int index = 0;
        Tuple<string, int> result = 
            new Tuple<string, int>(encodedStr, index);

        if (s.Count(x => x == s[0]) == s.Length)
            return result;

        List<string> strMatrix = new List<string>();
        
        for (int i = 0; i < s.Length; i++)
            strMatrix.Add(s[^i..] + s.Substring(0, s.Length - i));
        
        strMatrix.Sort(StringComparer.Ordinal);

        PrintMatrix(strMatrix);

        index = strMatrix.IndexOf(s);
        encodedStr = "";

        foreach (string str in strMatrix)
            encodedStr += str[^1..];

        result = new Tuple<string, int>(encodedStr, index);

        return result;
    }

    public static string Decode(string s, int n)
    {
        if (s.Length == 1) return s;

        string result = s;
        List<string> strMatrix = Enumerable.Repeat("", s.Length).ToList();

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < s.Length; j++)
                strMatrix[j] = s[j].ToString() + strMatrix[j];

            strMatrix.Sort(StringComparer.Ordinal);
        }

        return strMatrix[n];
    }

    private static void PrintMatrix(List<string> strMatrix)
    {
        foreach (string str in strMatrix)
            System.Console.WriteLine(str);
    }
}