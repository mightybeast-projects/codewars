using System.Text;

namespace codewars.Modules.Fundamentals.Tower;

public class Kata
{
    public static string[] TowerBuilder(int n)
    {
        List<string> result = new List<string>();

        int offset = 0;
        int maxLength = n * 2 - 1;

        for (int i = n; i > 0 ; i--, offset++)
        {
            StringBuilder row = new StringBuilder();

            for (int j = 0; j < maxLength; j++)
                if (j < offset || j > maxLength - 1 - offset)
                    row.Append(" ");
                else
                    row.Append("*");

            result.Add(row.ToString());
        }

        result.Reverse();

        return result.ToArray();
    }
}