namespace codewars.Modules.Fundamentals.DirectionsReduction;

public class Kata
{
    enum Direction { NORTH = 1, SOUTH = -1, EAST = 2, WEST = -2 }

    private static List<Direction> result;
    private static bool needReduction;

    public static string[] ReduceDirections(string[] directions)
    {
        result = new List<Direction>();

        for (int i = 0; i < directions.Length; i++)
            result.Add(Enum.Parse<Direction>(directions[i]));

        foreach (Direction d in result) System.Console.Write(d + " ");

        needReduction = true;
        while(needReduction)
        {
            needReduction = false;

            for (int i = 0; i < result.Count - 1; i++)
            {
                Direction dir1 = result[i];
                Direction dir2 = result[i + 1];

                if (DirectionsAreOpposite(dir1, dir2))
                {
                    result.RemoveAt(i + 1);
                    result.RemoveAt(i);
                    needReduction = true;
                    break;
                }
            }

            if (result.Count > 1)
                CheckDirections(result[0], result[^1]);
            
            System.Console.WriteLine("-");
                foreach (Direction d in result) System.Console.Write(d + " ");
        }

        return result.Select(x => x.ToString()).ToArray();
    }

    private static void CheckDirections(Direction dir1, Direction dir2)
    {
        if (!DirectionsAreOpposite(dir1, dir2)) return;

        result.RemoveAt(result.IndexOf(dir2));
        result.RemoveAt(result.IndexOf(dir1));
        needReduction = true;
    }

    private static bool DirectionsAreOpposite(Direction dir1, Direction dir2)
        => (int) dir1 + (int) dir2 == 0;
}