using System.Numerics;
using System.Text;

namespace codewars.Modules.Practice.SecretMessage;

public class Decoder
{
    private const string KEY = "abcdefghijklmnopqrstuvwxyz" +
                                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                                "0123456789.,? =";
    private const string SPECIAL = "!@#$%^&*()_+-";
    private static StringBuilder result;

    public static string Decode(string str)
    {
        result = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            char current = str[i];
            if (SPECIAL.Contains(current))
                result.Append(current);
            else
            {
                BigInteger keyIndex = KEY.IndexOf(current) + 1;
                BigInteger multiplier = (BigInteger) Math.Pow(2, i + 1);
                while (keyIndex % multiplier > 0)
                {
                    keyIndex += KEY.Length;
                    System.Console.WriteLine(keyIndex);
                }
                BigInteger decodedI = keyIndex / multiplier;

                result.Append(KEY[(int)decodedI - 1]);
            }
        }

        return result.ToString();
    }
}