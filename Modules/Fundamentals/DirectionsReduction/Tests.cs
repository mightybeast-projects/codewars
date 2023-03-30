using NUnit.Framework;

namespace codewars.Modules.Fundamentals.DirectionsReduction;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public void TestDirectionsReduction(string[] directions, string[] result) =>
        Assert.AreEqual(result, Kata.ReduceDirections(directions));

    private static object[] cases =
    {
        new object[] { new string[0], new string[0] },
        new object[] { new[] { "NORTH" }, new[] { "NORTH" } },
        new object[] { new[] { "NORTH", "SOUTH" }, new string[0] },
        new object[] { new[] { "SOUTH", "NORTH" }, new string[0] },
        new object[] { new[] { "WEST", "EAST" }, new string[0] },
        new object[] { new[] { "EAST", "WEST" }, new string[0] },
        new object[] { new[] { "NORTH", "SOUTH", "WEST" },
                        new [] { "WEST" } },
        new object[] { new[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" },
                        new [] { "WEST" } },
        new object[] { new[] { "NORTH", "WEST", "SOUTH", "EAST" },
                        new[] { "NORTH", "WEST", "SOUTH", "EAST" } },
        new object[] { new[] { "NORTH", "EAST", "NORTH", "EAST", "WEST", "WEST", "EAST", "EAST", "WEST", "SOUTH" },
                        new[] { "NORTH", "EAST" } },
        new object[] { new[] { "EAST", "EAST", "EAST", "EAST", "SOUTH", "EAST", "SOUTH", "SOUTH", "NORTH", "NORTH", "EAST", "NORTH", "NORTH", "EAST", "SOUTH" },
                        new[] { "EAST", "EAST", "EAST", "EAST", "SOUTH", "EAST", "EAST", "NORTH", "NORTH", "EAST", "SOUTH" } }
    };
}