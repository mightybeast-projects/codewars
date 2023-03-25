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

        foreach (string str in strMatrix)
            System.Console.WriteLine(str);

        index = strMatrix.IndexOf(s);
        encodedStr = "";

        foreach (string str in strMatrix)
            encodedStr += str[^1..];

        result = new Tuple<string, int>(encodedStr, index);

        return result;
    }

    public static string Decode(string s, int i)
    {
        return null;
    }
}

public class CaseSensitiveStringComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        if (char.IsUpper(x[0]) && char.IsUpper(y[0])) return x.CompareTo(y);
        if (char.IsUpper(x[0])) return -1;
        if (char.IsUpper(y[0])) return 1;
        return x.CompareTo(y);
    }
}