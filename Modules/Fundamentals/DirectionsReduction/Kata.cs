namespace codewars.Modules.Fundamentals.DirectionsReduction;

public class Kata
{
    enum Direction { NORTH = 1, SOUTH = -1, EAST = 2, WEST = -2 }

    public static string[] ReduceDirections(string[] directions)
    {
        Stack<Direction> result = new Stack<Direction>();

        foreach (string dirStr in directions)
            HandleDirection(result, dirStr);

        return result.Select(x => x.ToString()).Reverse().ToArray();
    }

    private static void HandleDirection(Stack<Direction> result, string d)
    {
        Direction dir = Enum.Parse<Direction>(d);

        if (result.Count != 0 && DirectionsAreOpposite(result.Peek(), dir))
            result.Pop();
        else
            result.Push(dir);
    }

    private static bool DirectionsAreOpposite(Direction dir1, Direction dir2)
        => (int) dir1 + (int) dir2 == 0;
}