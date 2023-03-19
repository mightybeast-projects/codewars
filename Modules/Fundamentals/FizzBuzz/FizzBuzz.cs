using System.Text;
using NUnit.Framework;

namespace codewars.Modules.Fundamentals.FizzBuzz;

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
    [Test, TestCaseSource(nameof(cases))]
    public string TestFizzBuzzElementAtIndex(int index) =>
        new FizzBuzz().ElementAt(index);

    private static TestCaseData[] cases =
    {
        new TestCaseData(0).Returns("1"),
        new TestCaseData(2).Returns("Fizz"),
        new TestCaseData(4).Returns("Buzz"),
        new TestCaseData(14).Returns("FizzBuzz")
    };
}