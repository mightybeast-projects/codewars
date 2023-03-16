using System.Text;
using NUnit.Framework;

namespace FizzBuzz;

public class FizzBuzz
{
    private StringBuilder output;
    private int[] array = new int[100];
    private int element;

    public FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
            array[i - 1] = i;
    }

    public string ElementAt(int index)
    {
        element = array[index];
        output = new StringBuilder();

        CheckDivisibles();

        if (ElementIsNotDivisible())
            output.Append(element);

        return output.ToString();
    }

    private void CheckDivisibles()
    {
        if (ElementDivisibleBy(3))
            output.Append("Fizz");
        if (ElementDivisibleBy(5))
            output.Append("Buzz");
    }

    private bool ElementDivisibleBy(int number) => element % number == 0;

    private bool ElementIsNotDivisible() => output.ToString() == "";
}

[TestFixture]
public class Tests
{
    [Test]
    [TestCase("1", 0)]
    [TestCase("Fizz", 2)]
    [TestCase("Buzz", 4)]
    [TestCase("FizzBuzz", 14)]
    public void ElementAtPositionEqualsTo(string element, int index) =>
        Assert.AreEqual(element, new FizzBuzz().ElementAt(index));
}