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

        foreach (string str in strMatrix)
            System.Console.WriteLine(str);
        
        strMatrix.Sort();

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