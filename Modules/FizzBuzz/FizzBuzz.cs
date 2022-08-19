using System.Text;

namespace FizzBuzz;

public class FizzBuzz
{
    public int[] array => _array;

    private int[] _array = new int[100];

    private int _element;
    private StringBuilder _output;

    public FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
            _array[i - 1] = i;
    }

    public void Print()
    {
        for (int i = 0; i < 100; i++)
            Console.WriteLine(ElementAt(i));
    }

    internal string ElementAt(int index)
    {
        _element = _array[index];
        _output = new StringBuilder();

        CheckDivisibles();

        if (ElementIsNotDivisible())
            _output.Append(_element);

        return _output.ToString();
    }

    private void CheckDivisibles()
    {
        if (ElementDivisibleBy(3))
            _output.Append("Fizz");
        if (ElementDivisibleBy(5))
            _output.Append("Buzz");
    }

    private bool ElementDivisibleBy(int number)
    {
        return _element % number == 0;
    }

    private bool ElementIsNotDivisible()
    {
        return _output.ToString() == "";
    }
}