using System.Numerics;
using System.Text;

namespace codewars.Modules.Practice.SecretMessage;

public class Kata
{
    private const string KEY = "abcdefghijklmnopqrstuvwxyz" +
                                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                                "0123456789.,? =";
    private const string SPECIAL = "!@#$%^&*()_+-";
    private static StringBuilder result;

    public static string Encode(string str)
    {
        result = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            char current = str[i];
            if (SPECIAL.Contains(current))
                result.Append(current);
            else
                EncodeCharacter(current, i);
        }

        return result.ToString();
    }

    public static string Decode(string str)
    {
        result = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            char current = str[i];
            if (SPECIAL.Contains(current))
                result.Append(current);
            else
                DecodeCharacter(current, i);
        }

        return result.ToString();
    }

    private static void EncodeCharacter(char ch, int i)
    {
        int keyIndex = KEY.IndexOf(ch) + 1;
        BigInteger encodedI = keyIndex * BigInteger.Pow(2, i + 1);
        System.Console.WriteLine(ch + " " + keyIndex + " " + encodedI);

        if (encodedI > KEY.Length)
            encodedI = encodedI - encodedI / KEY.Length * KEY.Length;

        result.Append(KEY[(int)encodedI - 1]);
    }

    private static void DecodeCharacter(char ch, int i)
    {
        int keyIndex = KEY.IndexOf(ch) + 1;
        BigInteger multiplier = BigInteger.Pow(2, i + 1);
        for (int j = 1; j < KEY.Length + 1; j++)
        {
            BigInteger expectedResult = multiplier * j - keyIndex;
            if (expectedResult % KEY.Length != 0)
                continue;
            result.Append(KEY[j - 1]);
        }
    }
}