using System.Text;

namespace codewars.Modules.Practice.SecretMessage;

public static class Kata
{
    public static string Encode(string str)
    {
        string key = "abcdefghijklmnopqrstuvwxyz" + 
                        "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                        "0123456789.,? =";
        StringBuilder result = new StringBuilder();
        
        for (int i = 0; i < str.Length; i++)
        {
            char current = str[i];
            int keyIndex = key.IndexOf(current);
            int encodedIndex = keyIndex * (int) Math.Pow(2, i + 1);
            result.Append(key[encodedIndex - 1]);
        }

        return result.ToString();
    }
}