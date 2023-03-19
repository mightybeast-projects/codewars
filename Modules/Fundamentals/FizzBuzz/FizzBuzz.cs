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
    [TestCase(0, ExpectedResult = "1")]
    [TestCase(2, ExpectedResult = "Fizz")]
    [TestCase(4, ExpectedResult = "Buzz")]
    [TestCase(14, ExpectedResult = "FizzBuzz")]
    public string TestFizzBuzzElementAtIndex(int index) =>
        new FizzBuzz().ElementAt(index);
}